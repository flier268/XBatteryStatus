﻿using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;
using Windows.Storage.Streams;

namespace XBatteryStatus
{
    public class MyApplicationContext : ApplicationContext
    {
        private NotifyIcon notifyIcon = new NotifyIcon();

        private Timer timer1;
        private ContextMenuStrip contextMenu;

        public BluetoothLEDevice pairedGamepad;
        public GattCharacteristic batteryCharacteristic;

        private SettingsForm settingsForm;

        private StreamWriter BatteryLogStream;

        public MyApplicationContext()
        {
            notifyIcon.Icon = Properties.Resources.iconQ;
            notifyIcon.Text = "XBatteryStatus: Looking for paired controller";
            notifyIcon.Visible = true;

            contextMenu = new ContextMenuStrip();
            contextMenu.ShowImageMargin = false;
            contextMenu.ShowCheckMargin = false;
            contextMenu.ShowItemToolTips = false;
            ToolStripButton settingsButton = new ToolStripButton("Settings", null, new EventHandler(SettingsClicked), "Settings");
            settingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            settingsButton.AutoSize = true;
            settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settingsButton.Margin = Padding.Empty;
            contextMenu.Items.Add(settingsButton);
            ToolStripButton exitButton = new ToolStripButton("Exit", null, new EventHandler(ExitClicked), "Exit");
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exitButton.AutoSize = true;
            exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            exitButton.Margin = Padding.Empty;
            contextMenu.Items.Add(exitButton);

            contextMenu.Dock = DockStyle.Top;

            notifyIcon.ContextMenuStrip = contextMenu;

            FindBleController();

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = UserSettings.Get().UpdateFrequencyMs;
            timer1.Start();
        }

        private async void FindBleController()
        {
            int count = 0;
            foreach (var device in await DeviceInformation.FindAllAsync())
            {
                try
                {
                    BluetoothLEDevice bleDevice = await BluetoothLEDevice.FromIdAsync(device.Id);

                    if (bleDevice != null && bleDevice.Appearance.SubCategory == BluetoothLEAppearanceSubcategories.Gamepad)//get the gamepads
                    {
                        GattDeviceService service = bleDevice.GetGattService(new Guid("0000180f-0000-1000-8000-00805f9b34fb"));
                        GattCharacteristic characteristic = service.GetCharacteristics(new Guid("00002a19-0000-1000-8000-00805f9b34fb")).First();

                        if (service != null && characteristic != null)//get the gamepads with battery status
                        {
                            bleDevice.ConnectionStatusChanged += ConnectionStatusChanged;
                            count++;
                            if (bleDevice.ConnectionStatus == BluetoothConnectionStatus.Connected)
                            {
                                ConnectGamepad(bleDevice);
                            }
                        }
                    }
                }
                catch { }
            }

            if (count == 0)
            {
                notifyIcon.Icon = Properties.Resources.iconE;
                notifyIcon.Text = "XBatteryStatus: No paired controller with battery service found";
            }
            else
            {
                Update();
            }
        }

        private async void ReadBattery()
        {
            var settings = UserSettings.Get();

            if (pairedGamepad != null && batteryCharacteristic != null &&
                pairedGamepad.ConnectionStatus == BluetoothConnectionStatus.Connected)
            {
                GattReadResult result = await batteryCharacteristic.ReadValueAsync();

                if (result.Status == GattCommunicationStatus.Success)
                {
                    var reader = DataReader.FromBuffer(result.Value);
                    int val = reader.ReadByte();
                    string notify = val.ToString() + "% - " + pairedGamepad.Name;
                    notifyIcon.Text = "XBatteryStatus: " + notify;
                    if (val < 5) notifyIcon.Icon = Properties.Resources.icon00;
                    else if (val < 15) notifyIcon.Icon = Properties.Resources.icon10;
                    else if (val < 25) notifyIcon.Icon = Properties.Resources.icon20;
                    else if (val < 35) notifyIcon.Icon = Properties.Resources.icon30;
                    else if (val < 45) notifyIcon.Icon = Properties.Resources.icon40;
                    else if (val < 55) notifyIcon.Icon = Properties.Resources.icon50;
                    else if (val < 65) notifyIcon.Icon = Properties.Resources.icon60;
                    else if (val < 75) notifyIcon.Icon = Properties.Resources.icon70;
                    else if (val < 85) notifyIcon.Icon = Properties.Resources.icon80;
                    else if (val < 95) notifyIcon.Icon = Properties.Resources.icon90;
                    else notifyIcon.Icon = Properties.Resources.icon100;

                    if (settings.EnableLowBatteryNotifications &&
                        (settings.LastBatteryReading > settings.WarningLevel0 && val <= settings.WarningLevel0) ||
                        (settings.LastBatteryReading > settings.WarningLevel1 && val <= settings.WarningLevel1) ||
                        (settings.LastBatteryReading > settings.WarningLevel2 && val <= settings.WarningLevel2))
                    {
                        ToastContentBuilder builder = new ToastContentBuilder()
                            .AddText("Low Battery")
                            .AddText(notify);

                        if (settings.EnableNotificationAudio)
                        {
                            builder.AddAudio(new ToastAudio()
                            {
                                Src = new Uri(settings.NotificationAudio),
                                Loop = false
                            });
                        }
                        builder.Show();
                    }

                    if (val != settings.LastBatteryReading)
                    {
                        MaybeLogBatteryChange(pairedGamepad.Name, val);
                        settings.LastBatteryReading = val;
                        settings.Save();
                    }
                }
            }
            else
            {
                notifyIcon.Icon = Properties.Resources.iconNone;
                notifyIcon.Text = "XBatteryStatus: Controller disconnected";
            }
        }

        private async void MaybeLogBatteryChange(string name, int reading)
        {
            if (UserSettings.Get().EnableBatteryLog)
            {
                try
                {
                    if (BatteryLogStream == null)
                    {
                        string filename = Path.Combine(FileHelpers.GetAppDataFolder(), "batterylog.csv");
                        BatteryLogStream = new(filename, true);
                    }

                    string line = $"{DateTime.Now.ToString(DateTimeFormatInfo.InvariantInfo)},{name},{reading}";
                    await BatteryLogStream.WriteLineAsync(line);
                    await BatteryLogStream.FlushAsync();
                }
                catch (Exception) { }
            }
        }

        private void ConnectionStatusChanged(BluetoothLEDevice sender, object args)
        {
            ConnectGamepad(sender);
            Update();
        }

        public void ConnectGamepad(BluetoothLEDevice device)
        {
            if (pairedGamepad == null || pairedGamepad.ConnectionStatus == BluetoothConnectionStatus.Disconnected)
            {
                try
                {
                    GattDeviceService service = device.GetGattService(new Guid("0000180f-0000-1000-8000-00805f9b34fb"));
                    GattCharacteristic characteristic = service.GetCharacteristics(new Guid("00002a19-0000-1000-8000-00805f9b34fb")).First();

                    if (service != null && characteristic != null)
                    {
                        pairedGamepad = device;
                        batteryCharacteristic = characteristic;
                    }
                }
                catch { }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReadBattery();
        }

        private void ExitClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            // Prevent double-opening
            if (settingsForm == null)
            {
                settingsForm = new SettingsForm();
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    timer1.Interval = UserSettings.Get().UpdateFrequencyMs;
                }
                settingsForm = null;
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            if (BatteryLogStream != null)
            {
                BatteryLogStream.Close();
            }
        }

        public void Update()
        {
            ReadBattery();
        }
    }
}