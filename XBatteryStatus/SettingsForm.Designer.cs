
namespace XBatteryStatus
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            updateFrequency = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            notificationsEnabled = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            audioFileDropDown = new System.Windows.Forms.ComboBox();
            testAudio = new System.Windows.Forms.Button();
            audioEnabled = new System.Windows.Forms.CheckBox();
            audioLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            Warning0 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            Warning1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            Warning2 = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            logBattery = new System.Windows.Forms.CheckBox();
            OpenDataFolder = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            okButton = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            errorProvider = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // updateFrequency
            // 
            updateFrequency.Location = new System.Drawing.Point(4, 3);
            updateFrequency.Margin = new System.Windows.Forms.Padding(4, 3, 1, 2);
            updateFrequency.MaxLength = 5;
            updateFrequency.Name = "updateFrequency";
            updateFrequency.Size = new System.Drawing.Size(33, 23);
            updateFrequency.TabIndex = 0;
            updateFrequency.Validating += updateFrequency_Validating;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 9);
            label1.Margin = new System.Windows.Forms.Padding(7, 3, 7, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Update Frequency:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(notificationsEnabled, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(audioEnabled, 1, 3);
            tableLayoutPanel1.Controls.Add(audioLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 1, 5);
            tableLayoutPanel1.Location = new System.Drawing.Point(9, 8);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new System.Drawing.Size(348, 180);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(updateFrequency);
            flowLayoutPanel3.Controls.Add(label3);
            flowLayoutPanel3.Location = new System.Drawing.Point(167, 1);
            flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new System.Drawing.Size(93, 28);
            flowLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(38, 3);
            label3.Margin = new System.Windows.Forms.Padding(0, 3, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "seconds";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 37);
            label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 15);
            label2.TabIndex = 2;
            label2.Text = "Low Battery Notifications?";
            // 
            // notificationsEnabled
            // 
            notificationsEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            notificationsEnabled.AutoSize = true;
            notificationsEnabled.Location = new System.Drawing.Point(171, 40);
            notificationsEnabled.Margin = new System.Windows.Forms.Padding(4, 6, 2, 2);
            notificationsEnabled.Name = "notificationsEnabled";
            notificationsEnabled.Size = new System.Drawing.Size(15, 14);
            notificationsEnabled.TabIndex = 6;
            notificationsEnabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(94, 129);
            label4.Margin = new System.Windows.Forms.Padding(7, 3, 7, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Audio File:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(audioFileDropDown);
            flowLayoutPanel2.Controls.Add(testAudio);
            flowLayoutPanel2.Location = new System.Drawing.Point(167, 121);
            flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new System.Drawing.Size(181, 27);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // audioFileDropDown
            // 
            audioFileDropDown.FormattingEnabled = true;
            audioFileDropDown.ItemHeight = 15;
            audioFileDropDown.Location = new System.Drawing.Point(2, 2);
            audioFileDropDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            audioFileDropDown.Name = "audioFileDropDown";
            audioFileDropDown.Size = new System.Drawing.Size(95, 23);
            audioFileDropDown.TabIndex = 8;
            // 
            // testAudio
            // 
            testAudio.Location = new System.Drawing.Point(101, 2);
            testAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            testAudio.Name = "testAudio";
            testAudio.Size = new System.Drawing.Size(78, 20);
            testAudio.TabIndex = 9;
            testAudio.Text = "Test";
            testAudio.UseVisualStyleBackColor = true;
            testAudio.Click += testAudio_Click;
            // 
            // audioEnabled
            // 
            audioEnabled.Anchor = System.Windows.Forms.AnchorStyles.Left;
            audioEnabled.AutoSize = true;
            audioEnabled.Location = new System.Drawing.Point(171, 100);
            audioEnabled.Margin = new System.Windows.Forms.Padding(4, 6, 2, 2);
            audioEnabled.Name = "audioEnabled";
            audioEnabled.Size = new System.Drawing.Size(15, 14);
            audioEnabled.TabIndex = 7;
            audioEnabled.UseVisualStyleBackColor = true;
            // 
            // audioLabel
            // 
            audioLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            audioLabel.AutoSize = true;
            audioLabel.Location = new System.Drawing.Point(87, 99);
            audioLabel.Margin = new System.Windows.Forms.Padding(7, 3, 7, 0);
            audioLabel.Name = "audioLabel";
            audioLabel.Size = new System.Drawing.Size(73, 15);
            audioLabel.TabIndex = 3;
            audioLabel.Text = "Play Audio?";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(65, 69);
            label5.Margin = new System.Windows.Forms.Padding(7, 3, 7, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Warning Levels:";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(Warning0);
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Controls.Add(Warning1);
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Controls.Add(Warning2);
            flowLayoutPanel4.Controls.Add(label8);
            flowLayoutPanel4.Location = new System.Drawing.Point(167, 61);
            flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new System.Drawing.Size(177, 28);
            flowLayoutPanel4.TabIndex = 8;
            // 
            // Warning0
            // 
            Warning0.Location = new System.Drawing.Point(4, 3);
            Warning0.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            Warning0.MaxLength = 5;
            Warning0.Name = "Warning0";
            Warning0.Size = new System.Drawing.Size(33, 23);
            Warning0.TabIndex = 0;
            Warning0.Validating += Warning0_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(37, 4);
            label6.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(18, 15);
            label6.TabIndex = 1;
            label6.Text = "%";
            // 
            // Warning1
            // 
            Warning1.Location = new System.Drawing.Point(63, 3);
            Warning1.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            Warning1.MaxLength = 5;
            Warning1.Name = "Warning1";
            Warning1.Size = new System.Drawing.Size(33, 23);
            Warning1.TabIndex = 0;
            Warning1.Validating += Warning0_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(96, 4);
            label7.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(18, 15);
            label7.TabIndex = 1;
            label7.Text = "%";
            // 
            // Warning2
            // 
            Warning2.Location = new System.Drawing.Point(122, 3);
            Warning2.Margin = new System.Windows.Forms.Padding(4, 3, 0, 2);
            Warning2.MaxLength = 5;
            Warning2.Name = "Warning2";
            Warning2.Size = new System.Drawing.Size(33, 23);
            Warning2.TabIndex = 0;
            Warning2.Validating += Warning0_Validating;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(155, 4);
            label8.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(18, 15);
            label8.TabIndex = 1;
            label8.Text = "%";
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(53, 159);
            label9.Margin = new System.Windows.Forms.Padding(7, 3, 7, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(107, 15);
            label9.TabIndex = 2;
            label9.Text = "Log Battery Stats?";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(logBattery);
            flowLayoutPanel5.Controls.Add(OpenDataFolder);
            flowLayoutPanel5.Location = new System.Drawing.Point(167, 154);
            flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new System.Drawing.Size(127, 24);
            flowLayoutPanel5.TabIndex = 9;
            // 
            // logBattery
            // 
            logBattery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            logBattery.AutoSize = true;
            logBattery.Location = new System.Drawing.Point(4, 5);
            logBattery.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            logBattery.Name = "logBattery";
            logBattery.Size = new System.Drawing.Size(15, 14);
            logBattery.TabIndex = 7;
            logBattery.UseVisualStyleBackColor = true;
            // 
            // OpenDataFolder
            // 
            OpenDataFolder.Location = new System.Drawing.Point(23, 2);
            OpenDataFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            OpenDataFolder.Name = "OpenDataFolder";
            OpenDataFolder.Size = new System.Drawing.Size(102, 20);
            OpenDataFolder.TabIndex = 8;
            OpenDataFolder.Text = "Open Folder";
            OpenDataFolder.UseVisualStyleBackColor = true;
            OpenDataFolder.Click += OpenDataFolder_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            cancelButton.Location = new System.Drawing.Point(133, 2);
            cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 20);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "&Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            okButton.Location = new System.Drawing.Point(54, 2);
            okButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 20);
            okButton.TabIndex = 4;
            okButton.Text = "&OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(cancelButton);
            flowLayoutPanel1.Controls.Add(okButton);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new System.Drawing.Point(147, 195);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(210, 25);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(363, 220);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "XBatteryStatus Settings";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox updateFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label audioLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox audioEnabled;
        private System.Windows.Forms.CheckBox notificationsEnabled;
        private System.Windows.Forms.ComboBox audioFileDropDown;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button testAudio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox Warning0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Warning1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Warning2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox logBattery;
        private System.Windows.Forms.Button OpenDataFolder;
    }
}