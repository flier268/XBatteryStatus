﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

namespace XBatteryStatus
{
    public partial class SettingsForm : Form
    {
        private string[] audioOptions = {
            "ms-winsoundevent:Notification.Default",
            "ms-winsoundevent:Notification.IM",
            "ms-winsoundevent:Notification.Mail",
            "ms-winsoundevent:Notification.Reminder",
            "ms-winsoundevent:Notification.SMS",
            "ms-winsoundevent:Notification.Looping.Alarm",
            "ms-winsoundevent:Notification.Looping.Alarm2",
            "ms-winsoundevent:Notification.Looping.Alarm3",
            "ms-winsoundevent:Notification.Looping.Alarm4",
            "ms-winsoundevent:Notification.Looping.Alarm5",
            "ms-winsoundevent:Notification.Looping.Alarm6",
            "ms-winsoundevent:Notification.Looping.Alarm7",
            "ms-winsoundevent:Notification.Looping.Alarm8",
            "ms-winsoundevent:Notification.Looping.Alarm9",
            "ms-winsoundevent:Notification.Looping.Alarm10",
        };

        public SettingsForm()
        {
            InitializeComponent();

            this.CancelButton = cancelButton;

            var settings = UserSettings.Get();
            updateFrequency.Text = (settings.UpdateFrequencyMs / 1000).ToString();
            notificationsEnabled.Checked = settings.EnableLowBatteryNotifications;
            Warning0.Text = settings.WarningLevel0.ToString();
            Warning1.Text = settings.WarningLevel1.ToString();
            Warning2.Text = settings.WarningLevel2.ToString();
            audioEnabled.Checked = settings.EnableNotificationAudio;
            audioFileDropDown.Items.Clear();
            foreach (string opt in audioOptions)
            {
                string lastPart = opt.Split('.').Last();
                audioFileDropDown.Items.Add(lastPart);
            }
            audioFileDropDown.SelectedIndex = Array.FindIndex(audioOptions, item => item == settings.NotificationAudio);
            logBattery.Checked = settings.EnableBatteryLog;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var settings = UserSettings.Get();
                int newFreq = 0;
                if (int.TryParse(updateFrequency.Text, out newFreq))
                {
                    settings.UpdateFrequencyMs = newFreq * 1000;
                }
                int newPercent = 0;
                if (int.TryParse(Warning0.Text, out newPercent))
                {
                    settings.WarningLevel0 = newPercent;
                }
                if (int.TryParse(Warning1.Text, out newPercent))
                {
                    settings.WarningLevel1 = newPercent;
                }
                if (int.TryParse(Warning2.Text, out newPercent))
                {
                    settings.WarningLevel2 = newPercent;
                }
                settings.EnableLowBatteryNotifications = notificationsEnabled.Checked;
                settings.EnableNotificationAudio = audioEnabled.Checked;
                if (audioFileDropDown.SelectedIndex >= 0 && audioFileDropDown.SelectedIndex < audioOptions.Length)
                {
                    settings.NotificationAudio = audioOptions[audioFileDropDown.SelectedIndex];
                }
                settings.EnableBatteryLog = logBattery.Checked;
                settings.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void testAudio_Click(object sender, EventArgs e)
        {
            PlaySelectedAudio();
        }

        private void PlaySelectedAudio()
        {
            if (audioFileDropDown.SelectedIndex >= 0 && audioFileDropDown.SelectedIndex < audioOptions.Length)
            {
                // There's not a way to play toast audio directly here, so do a preview notification
                new ToastContentBuilder()
                    .AddText("Test Low Battery Notification")
                    .AddAudio(new ToastAudio()
                    {
                        Src = new Uri(audioOptions[audioFileDropDown.SelectedIndex]),
                        Loop = false
                    })
                    .Show();
            }
        }

        private void validateNumberText(TextBox tb, string context, bool mustBePositive, CancelEventArgs e)
        {
            errorProvider.SetError(tb, "");

            if (tb.TextLength == 0)
            {
                e.Cancel = true;
                tb.Focus();
                errorProvider.SetError(tb, $"{context} cannot be blank");
            }
            else
            {
                int val;
                if (!int.TryParse(tb.Text, System.Globalization.NumberStyles.Any, null, out val))
                {
                    e.Cancel = true;
                    tb.Focus();
                    errorProvider.SetError(tb, $"{context} is not a number");
                }
                else
                {
                    if (val <= 0 && mustBePositive)
                    {
                        e.Cancel = true;
                        tb.Focus();
                        errorProvider.SetError(tb, $"{context} must be greater than zero");
                    }
                }
            }
        }

        private void updateFrequency_Validating(object sender, CancelEventArgs e)
        {
            validateNumberText(updateFrequency, "Update Frequency", true, e);
        }

        private void Warning0_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                validateNumberText(tb, "Warning Level", true, e);
            }
        }

        private void OpenDataFolder_Click(object sender, EventArgs e)
        {
            // Note: Windows.Storage.ApplicationData is completely unreliable
            // So this data won't be in the same location as settings
            string baseAppData = FileHelpers.GetAppDataFolder();
            Process.Start(@"explorer.exe", baseAppData);
        }
    }
}