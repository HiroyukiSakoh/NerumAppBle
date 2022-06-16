namespace NerumAppBle
{
    partial class BedControllerForm
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
            this.ButtonHeadUp = new System.Windows.Forms.Button();
            this.ButtonHeadDown = new System.Windows.Forms.Button();
            this.ButtonFootUp = new System.Windows.Forms.Button();
            this.ButtonFootDown = new System.Windows.Forms.Button();
            this.ButtonMemory1 = new System.Windows.Forms.Button();
            this.ButtonLight = new System.Windows.Forms.Button();
            this.ButtonAntiSnore = new System.Windows.Forms.Button();
            this.ButtonZeroG = new System.Windows.Forms.Button();
            this.ButtonReading = new System.Windows.Forms.Button();
            this.ButtonFlat = new System.Windows.Forms.Button();
            this.ButtonMemory2 = new System.Windows.Forms.Button();
            this.ListBoxAlarmMode = new System.Windows.Forms.ListBox();
            this.CheckedListBoxAlarmDayOfWeek = new System.Windows.Forms.CheckedListBox();
            this.DateTimePickerAlarmTime = new System.Windows.Forms.DateTimePicker();
            this.RadioButtonAlarmOn = new System.Windows.Forms.RadioButton();
            this.RadioButtonAlarmOff = new System.Windows.Forms.RadioButton();
            this.ButtonSaveAlarm = new System.Windows.Forms.Button();
            this.LabelLightValue = new System.Windows.Forms.Label();
            this.LabelDescriptionLight = new System.Windows.Forms.Label();
            this.LabelFootValue = new System.Windows.Forms.Label();
            this.LabelDescriptionFoot = new System.Windows.Forms.Label();
            this.LabelHeadValue = new System.Windows.Forms.Label();
            this.LabelDescriptionHead = new System.Windows.Forms.Label();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageBed = new System.Windows.Forms.TabPage();
            this.ButtonUnionDown = new System.Windows.Forms.Button();
            this.ButtonUnionUp = new System.Windows.Forms.Button();
            this.ButtonQuery = new System.Windows.Forms.Button();
            this.ButtonAllNone = new System.Windows.Forms.Button();
            this.TabPageAlarm = new System.Windows.Forms.TabPage();
            this.ButtonSetDateTime = new System.Windows.Forms.Button();
            this.LabelDateTimeValue = new System.Windows.Forms.Label();
            this.LabelDateTime = new System.Windows.Forms.Label();
            this.LabelEditMode = new System.Windows.Forms.Label();
            this.ButtonToggleEditMode = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.TabPageBed.SuspendLayout();
            this.TabPageAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonHeadUp
            // 
            this.ButtonHeadUp.Location = new System.Drawing.Point(72, 152);
            this.ButtonHeadUp.Name = "ButtonHeadUp";
            this.ButtonHeadUp.Size = new System.Drawing.Size(55, 55);
            this.ButtonHeadUp.TabIndex = 3;
            this.ButtonHeadUp.Text = "HEAD UP";
            this.ButtonHeadUp.UseVisualStyleBackColor = true;
            this.ButtonHeadUp.Click += new System.EventHandler(this.ButtonHeadUp_Click);
            // 
            // ButtonHeadDown
            // 
            this.ButtonHeadDown.Location = new System.Drawing.Point(72, 274);
            this.ButtonHeadDown.Name = "ButtonHeadDown";
            this.ButtonHeadDown.Size = new System.Drawing.Size(55, 55);
            this.ButtonHeadDown.TabIndex = 7;
            this.ButtonHeadDown.Text = "HEAD DOWN";
            this.ButtonHeadDown.UseVisualStyleBackColor = true;
            this.ButtonHeadDown.Click += new System.EventHandler(this.ButtonHeadDown_Click);
            // 
            // ButtonFootUp
            // 
            this.ButtonFootUp.Location = new System.Drawing.Point(11, 213);
            this.ButtonFootUp.Name = "ButtonFootUp";
            this.ButtonFootUp.Size = new System.Drawing.Size(55, 55);
            this.ButtonFootUp.TabIndex = 4;
            this.ButtonFootUp.Text = "FOOT UP";
            this.ButtonFootUp.UseVisualStyleBackColor = true;
            this.ButtonFootUp.Click += new System.EventHandler(this.ButtonFootUp_Click);
            // 
            // ButtonFootDown
            // 
            this.ButtonFootDown.Location = new System.Drawing.Point(133, 213);
            this.ButtonFootDown.Name = "ButtonFootDown";
            this.ButtonFootDown.Size = new System.Drawing.Size(55, 55);
            this.ButtonFootDown.TabIndex = 6;
            this.ButtonFootDown.Text = "FOOT DOWN";
            this.ButtonFootDown.UseVisualStyleBackColor = true;
            this.ButtonFootDown.Click += new System.EventHandler(this.ButtonFootDown_Click);
            // 
            // ButtonMemory1
            // 
            this.ButtonMemory1.Location = new System.Drawing.Point(11, 97);
            this.ButtonMemory1.Name = "ButtonMemory1";
            this.ButtonMemory1.Size = new System.Drawing.Size(55, 55);
            this.ButtonMemory1.TabIndex = 1;
            this.ButtonMemory1.Text = "MEMORY 1";
            this.ButtonMemory1.UseVisualStyleBackColor = true;
            this.ButtonMemory1.Click += new System.EventHandler(this.ButtonMemory1_Click);
            // 
            // ButtonLight
            // 
            this.ButtonLight.Location = new System.Drawing.Point(72, 73);
            this.ButtonLight.Name = "ButtonLight";
            this.ButtonLight.Size = new System.Drawing.Size(55, 55);
            this.ButtonLight.TabIndex = 0;
            this.ButtonLight.Text = "LIGHT";
            this.ButtonLight.UseVisualStyleBackColor = true;
            this.ButtonLight.Click += new System.EventHandler(this.ButtonLight_Click);
            // 
            // ButtonAntiSnore
            // 
            this.ButtonAntiSnore.Location = new System.Drawing.Point(11, 335);
            this.ButtonAntiSnore.Name = "ButtonAntiSnore";
            this.ButtonAntiSnore.Size = new System.Drawing.Size(55, 55);
            this.ButtonAntiSnore.TabIndex = 8;
            this.ButtonAntiSnore.Text = "ANTI SNORE";
            this.ButtonAntiSnore.UseVisualStyleBackColor = true;
            this.ButtonAntiSnore.Click += new System.EventHandler(this.ButtonAntiSnore_Click);
            // 
            // ButtonZeroG
            // 
            this.ButtonZeroG.Location = new System.Drawing.Point(72, 335);
            this.ButtonZeroG.Name = "ButtonZeroG";
            this.ButtonZeroG.Size = new System.Drawing.Size(55, 55);
            this.ButtonZeroG.TabIndex = 9;
            this.ButtonZeroG.Text = "Zero G";
            this.ButtonZeroG.UseVisualStyleBackColor = true;
            this.ButtonZeroG.Click += new System.EventHandler(this.ButtonZeroG_Click);
            // 
            // ButtonReading
            // 
            this.ButtonReading.Location = new System.Drawing.Point(133, 335);
            this.ButtonReading.Name = "ButtonReading";
            this.ButtonReading.Size = new System.Drawing.Size(55, 55);
            this.ButtonReading.TabIndex = 10;
            this.ButtonReading.Text = "READING";
            this.ButtonReading.UseVisualStyleBackColor = true;
            this.ButtonReading.Click += new System.EventHandler(this.ButtonReading_Click);
            // 
            // ButtonFlat
            // 
            this.ButtonFlat.Location = new System.Drawing.Point(72, 213);
            this.ButtonFlat.Name = "ButtonFlat";
            this.ButtonFlat.Size = new System.Drawing.Size(55, 55);
            this.ButtonFlat.TabIndex = 5;
            this.ButtonFlat.Text = "FLAT";
            this.ButtonFlat.UseVisualStyleBackColor = true;
            this.ButtonFlat.Click += new System.EventHandler(this.ButtonFlat_Click);
            // 
            // ButtonMemory2
            // 
            this.ButtonMemory2.Location = new System.Drawing.Point(133, 97);
            this.ButtonMemory2.Name = "ButtonMemory2";
            this.ButtonMemory2.Size = new System.Drawing.Size(55, 55);
            this.ButtonMemory2.TabIndex = 2;
            this.ButtonMemory2.Text = "MEMORY 2";
            this.ButtonMemory2.UseVisualStyleBackColor = true;
            this.ButtonMemory2.Click += new System.EventHandler(this.ButtonMemory2_Click);
            // 
            // ListBoxAlarmMode
            // 
            this.ListBoxAlarmMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxAlarmMode.Enabled = false;
            this.ListBoxAlarmMode.FormattingEnabled = true;
            this.ListBoxAlarmMode.ItemHeight = 15;
            this.ListBoxAlarmMode.Items.AddRange(new object[] {
            "なし",
            "M1",
            "M2",
            "灯り"});
            this.ListBoxAlarmMode.Location = new System.Drawing.Point(6, 200);
            this.ListBoxAlarmMode.Name = "ListBoxAlarmMode";
            this.ListBoxAlarmMode.Size = new System.Drawing.Size(187, 64);
            this.ListBoxAlarmMode.TabIndex = 6;
            // 
            // CheckedListBoxAlarmDayOfWeek
            // 
            this.CheckedListBoxAlarmDayOfWeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedListBoxAlarmDayOfWeek.Enabled = false;
            this.CheckedListBoxAlarmDayOfWeek.FormattingEnabled = true;
            this.CheckedListBoxAlarmDayOfWeek.Items.AddRange(new object[] {
            "日曜日",
            "月曜日",
            "火曜日",
            "水曜日",
            "木曜日",
            "金曜日",
            "土曜日"});
            this.CheckedListBoxAlarmDayOfWeek.Location = new System.Drawing.Point(6, 35);
            this.CheckedListBoxAlarmDayOfWeek.Name = "CheckedListBoxAlarmDayOfWeek";
            this.CheckedListBoxAlarmDayOfWeek.Size = new System.Drawing.Size(187, 130);
            this.CheckedListBoxAlarmDayOfWeek.TabIndex = 1;
            // 
            // DateTimePickerAlarmTime
            // 
            this.DateTimePickerAlarmTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerAlarmTime.CustomFormat = "HH:mm";
            this.DateTimePickerAlarmTime.Enabled = false;
            this.DateTimePickerAlarmTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerAlarmTime.Location = new System.Drawing.Point(6, 171);
            this.DateTimePickerAlarmTime.Name = "DateTimePickerAlarmTime";
            this.DateTimePickerAlarmTime.ShowUpDown = true;
            this.DateTimePickerAlarmTime.Size = new System.Drawing.Size(187, 23);
            this.DateTimePickerAlarmTime.TabIndex = 2;
            // 
            // RadioButtonAlarmOn
            // 
            this.RadioButtonAlarmOn.AutoSize = true;
            this.RadioButtonAlarmOn.Checked = true;
            this.RadioButtonAlarmOn.Enabled = false;
            this.RadioButtonAlarmOn.Location = new System.Drawing.Point(6, 268);
            this.RadioButtonAlarmOn.Name = "RadioButtonAlarmOn";
            this.RadioButtonAlarmOn.Size = new System.Drawing.Size(43, 19);
            this.RadioButtonAlarmOn.TabIndex = 3;
            this.RadioButtonAlarmOn.TabStop = true;
            this.RadioButtonAlarmOn.Text = "ON";
            this.RadioButtonAlarmOn.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlarmOff
            // 
            this.RadioButtonAlarmOff.AutoSize = true;
            this.RadioButtonAlarmOff.Enabled = false;
            this.RadioButtonAlarmOff.Location = new System.Drawing.Point(55, 268);
            this.RadioButtonAlarmOff.Name = "RadioButtonAlarmOff";
            this.RadioButtonAlarmOff.Size = new System.Drawing.Size(46, 19);
            this.RadioButtonAlarmOff.TabIndex = 4;
            this.RadioButtonAlarmOff.Text = "OFF";
            this.RadioButtonAlarmOff.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveAlarm
            // 
            this.ButtonSaveAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSaveAlarm.Enabled = false;
            this.ButtonSaveAlarm.Location = new System.Drawing.Point(127, 6);
            this.ButtonSaveAlarm.Name = "ButtonSaveAlarm";
            this.ButtonSaveAlarm.Size = new System.Drawing.Size(64, 23);
            this.ButtonSaveAlarm.TabIndex = 5;
            this.ButtonSaveAlarm.Text = "保存";
            this.ButtonSaveAlarm.UseVisualStyleBackColor = true;
            this.ButtonSaveAlarm.Click += new System.EventHandler(this.ButtonSaveAlarm_Click);
            // 
            // LabelLightValue
            // 
            this.LabelLightValue.AutoSize = true;
            this.LabelLightValue.Location = new System.Drawing.Point(50, 43);
            this.LabelLightValue.Name = "LabelLightValue";
            this.LabelLightValue.Size = new System.Drawing.Size(25, 15);
            this.LabelLightValue.TabIndex = 0;
            this.LabelLightValue.Text = "ON";
            // 
            // LabelDescriptionLight
            // 
            this.LabelDescriptionLight.AutoSize = true;
            this.LabelDescriptionLight.Location = new System.Drawing.Point(6, 43);
            this.LabelDescriptionLight.Name = "LabelDescriptionLight";
            this.LabelDescriptionLight.Size = new System.Drawing.Size(39, 15);
            this.LabelDescriptionLight.TabIndex = 0;
            this.LabelDescriptionLight.Text = "LIGHT";
            // 
            // LabelFootValue
            // 
            this.LabelFootValue.AutoSize = true;
            this.LabelFootValue.Location = new System.Drawing.Point(50, 28);
            this.LabelFootValue.Name = "LabelFootValue";
            this.LabelFootValue.Size = new System.Drawing.Size(17, 15);
            this.LabelFootValue.TabIndex = 0;
            this.LabelFootValue.Text = "%";
            // 
            // LabelDescriptionFoot
            // 
            this.LabelDescriptionFoot.AutoSize = true;
            this.LabelDescriptionFoot.Location = new System.Drawing.Point(6, 28);
            this.LabelDescriptionFoot.Name = "LabelDescriptionFoot";
            this.LabelDescriptionFoot.Size = new System.Drawing.Size(37, 15);
            this.LabelDescriptionFoot.TabIndex = 0;
            this.LabelDescriptionFoot.Text = "FOOT";
            // 
            // LabelHeadValue
            // 
            this.LabelHeadValue.AutoSize = true;
            this.LabelHeadValue.Location = new System.Drawing.Point(50, 13);
            this.LabelHeadValue.Name = "LabelHeadValue";
            this.LabelHeadValue.Size = new System.Drawing.Size(17, 15);
            this.LabelHeadValue.TabIndex = 0;
            this.LabelHeadValue.Text = "%";
            // 
            // LabelDescriptionHead
            // 
            this.LabelDescriptionHead.AutoSize = true;
            this.LabelDescriptionHead.Location = new System.Drawing.Point(6, 13);
            this.LabelDescriptionHead.Name = "LabelDescriptionHead";
            this.LabelDescriptionHead.Size = new System.Drawing.Size(38, 15);
            this.LabelDescriptionHead.TabIndex = 0;
            this.LabelDescriptionHead.Text = "HEAD";
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabPageBed);
            this.TabControlMain.Controls.Add(this.TabPageAlarm);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Enabled = false;
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(207, 431);
            this.TabControlMain.TabIndex = 4;
            this.TabControlMain.SelectedIndexChanged += new System.EventHandler(this.TabControlMain_SelectedIndexChanged);
            // 
            // TabPageBed
            // 
            this.TabPageBed.Controls.Add(this.ButtonUnionDown);
            this.TabPageBed.Controls.Add(this.ButtonUnionUp);
            this.TabPageBed.Controls.Add(this.ButtonQuery);
            this.TabPageBed.Controls.Add(this.ButtonAllNone);
            this.TabPageBed.Controls.Add(this.LabelLightValue);
            this.TabPageBed.Controls.Add(this.ButtonLight);
            this.TabPageBed.Controls.Add(this.LabelDescriptionLight);
            this.TabPageBed.Controls.Add(this.ButtonMemory1);
            this.TabPageBed.Controls.Add(this.LabelFootValue);
            this.TabPageBed.Controls.Add(this.ButtonFootDown);
            this.TabPageBed.Controls.Add(this.LabelDescriptionFoot);
            this.TabPageBed.Controls.Add(this.ButtonMemory2);
            this.TabPageBed.Controls.Add(this.LabelHeadValue);
            this.TabPageBed.Controls.Add(this.LabelDescriptionHead);
            this.TabPageBed.Controls.Add(this.ButtonReading);
            this.TabPageBed.Controls.Add(this.ButtonHeadUp);
            this.TabPageBed.Controls.Add(this.ButtonZeroG);
            this.TabPageBed.Controls.Add(this.ButtonHeadDown);
            this.TabPageBed.Controls.Add(this.ButtonAntiSnore);
            this.TabPageBed.Controls.Add(this.ButtonFootUp);
            this.TabPageBed.Controls.Add(this.ButtonFlat);
            this.TabPageBed.Location = new System.Drawing.Point(4, 24);
            this.TabPageBed.Name = "TabPageBed";
            this.TabPageBed.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageBed.Size = new System.Drawing.Size(199, 403);
            this.TabPageBed.TabIndex = 0;
            this.TabPageBed.Text = "操作";
            this.TabPageBed.UseVisualStyleBackColor = true;
            // 
            // ButtonUnionDown
            // 
            this.ButtonUnionDown.BackColor = System.Drawing.Color.Gray;
            this.ButtonUnionDown.Location = new System.Drawing.Point(137, 184);
            this.ButtonUnionDown.Name = "ButtonUnionDown";
            this.ButtonUnionDown.Size = new System.Drawing.Size(49, 23);
            this.ButtonUnionDown.TabIndex = 12;
            this.ButtonUnionDown.Text = "U↓";
            this.ButtonUnionDown.UseVisualStyleBackColor = false;
            this.ButtonUnionDown.Click += new System.EventHandler(this.ButtonUnionDown_Click);
            // 
            // ButtonUnionUp
            // 
            this.ButtonUnionUp.BackColor = System.Drawing.Color.Gray;
            this.ButtonUnionUp.Location = new System.Drawing.Point(137, 158);
            this.ButtonUnionUp.Name = "ButtonUnionUp";
            this.ButtonUnionUp.Size = new System.Drawing.Size(49, 23);
            this.ButtonUnionUp.TabIndex = 12;
            this.ButtonUnionUp.Text = "U↑";
            this.ButtonUnionUp.UseVisualStyleBackColor = false;
            this.ButtonUnionUp.Click += new System.EventHandler(this.ButtonUnionUp_Click);
            // 
            // ButtonQuery
            // 
            this.ButtonQuery.BackColor = System.Drawing.Color.Silver;
            this.ButtonQuery.Location = new System.Drawing.Point(125, 37);
            this.ButtonQuery.Name = "ButtonQuery";
            this.ButtonQuery.Size = new System.Drawing.Size(61, 30);
            this.ButtonQuery.TabIndex = 11;
            this.ButtonQuery.Text = "Query";
            this.ButtonQuery.UseVisualStyleBackColor = false;
            this.ButtonQuery.Click += new System.EventHandler(this.ButtonQuery_Click);
            // 
            // ButtonAllNone
            // 
            this.ButtonAllNone.BackColor = System.Drawing.Color.Silver;
            this.ButtonAllNone.Location = new System.Drawing.Point(125, 7);
            this.ButtonAllNone.Name = "ButtonAllNone";
            this.ButtonAllNone.Size = new System.Drawing.Size(61, 30);
            this.ButtonAllNone.TabIndex = 11;
            this.ButtonAllNone.Text = "AllNone";
            this.ButtonAllNone.UseVisualStyleBackColor = false;
            this.ButtonAllNone.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // TabPageAlarm
            // 
            this.TabPageAlarm.Controls.Add(this.ButtonSetDateTime);
            this.TabPageAlarm.Controls.Add(this.LabelDateTimeValue);
            this.TabPageAlarm.Controls.Add(this.LabelDateTime);
            this.TabPageAlarm.Controls.Add(this.LabelEditMode);
            this.TabPageAlarm.Controls.Add(this.ButtonToggleEditMode);
            this.TabPageAlarm.Controls.Add(this.ListBoxAlarmMode);
            this.TabPageAlarm.Controls.Add(this.CheckedListBoxAlarmDayOfWeek);
            this.TabPageAlarm.Controls.Add(this.DateTimePickerAlarmTime);
            this.TabPageAlarm.Controls.Add(this.ButtonSaveAlarm);
            this.TabPageAlarm.Controls.Add(this.RadioButtonAlarmOn);
            this.TabPageAlarm.Controls.Add(this.RadioButtonAlarmOff);
            this.TabPageAlarm.Location = new System.Drawing.Point(4, 24);
            this.TabPageAlarm.Name = "TabPageAlarm";
            this.TabPageAlarm.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAlarm.Size = new System.Drawing.Size(199, 403);
            this.TabPageAlarm.TabIndex = 1;
            this.TabPageAlarm.Text = "アラーム";
            this.TabPageAlarm.UseVisualStyleBackColor = true;
            // 
            // ButtonSetDateTime
            // 
            this.ButtonSetDateTime.Location = new System.Drawing.Point(8, 320);
            this.ButtonSetDateTime.Name = "ButtonSetDateTime";
            this.ButtonSetDateTime.Size = new System.Drawing.Size(67, 23);
            this.ButtonSetDateTime.TabIndex = 11;
            this.ButtonSetDateTime.Text = "時刻設定";
            this.ButtonSetDateTime.UseVisualStyleBackColor = true;
            this.ButtonSetDateTime.Click += new System.EventHandler(this.ButtonSetDateTime_Click);
            // 
            // LabelDateTimeValue
            // 
            this.LabelDateTimeValue.AutoSize = true;
            this.LabelDateTimeValue.Location = new System.Drawing.Point(59, 302);
            this.LabelDateTimeValue.Name = "LabelDateTimeValue";
            this.LabelDateTimeValue.Size = new System.Drawing.Size(134, 15);
            this.LabelDateTimeValue.TabIndex = 10;
            this.LabelDateTimeValue.Text = "yyyy/MM/dd HH:mm:ss";
            // 
            // LabelDateTime
            // 
            this.LabelDateTime.AutoSize = true;
            this.LabelDateTime.Location = new System.Drawing.Point(6, 302);
            this.LabelDateTime.Name = "LabelDateTime";
            this.LabelDateTime.Size = new System.Drawing.Size(55, 15);
            this.LabelDateTime.TabIndex = 9;
            this.LabelDateTime.Text = "内部時刻";
            // 
            // LabelEditMode
            // 
            this.LabelEditMode.AutoSize = true;
            this.LabelEditMode.Location = new System.Drawing.Point(78, 10);
            this.LabelEditMode.Name = "LabelEditMode";
            this.LabelEditMode.Size = new System.Drawing.Size(43, 15);
            this.LabelEditMode.TabIndex = 8;
            this.LabelEditMode.Text = "表示中";
            // 
            // ButtonToggleEditMode
            // 
            this.ButtonToggleEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonToggleEditMode.Location = new System.Drawing.Point(6, 6);
            this.ButtonToggleEditMode.Name = "ButtonToggleEditMode";
            this.ButtonToggleEditMode.Size = new System.Drawing.Size(69, 23);
            this.ButtonToggleEditMode.TabIndex = 7;
            this.ButtonToggleEditMode.Text = "モード変更";
            this.ButtonToggleEditMode.UseVisualStyleBackColor = true;
            this.ButtonToggleEditMode.Click += new System.EventHandler(this.ButtonToggleEditMode_Click);
            // 
            // BedControllerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 431);
            this.Controls.Add(this.TabControlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BedControllerForm";
            this.Text = "NerumApp BLE Contoller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BedControllerForm_FormClosing);
            this.Load += new System.EventHandler(this.BedControllerForm_Load);
            this.TabControlMain.ResumeLayout(false);
            this.TabPageBed.ResumeLayout(false);
            this.TabPageBed.PerformLayout();
            this.TabPageAlarm.ResumeLayout(false);
            this.TabPageAlarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button ButtonHeadUp;
        private Button ButtonHeadDown;
        private Button ButtonFootUp;
        private Button ButtonFootDown;
        private Button ButtonMemory1;
        private Button ButtonLight;
        private Button ButtonAntiSnore;
        private Button ButtonZeroG;
        private Button ButtonReading;
        private Button ButtonFlat;
        private Button ButtonMemory2;
        private DateTimePicker DateTimePickerAlarmTime;
        private CheckedListBox CheckedListBoxAlarmDayOfWeek;
        private RadioButton RadioButtonAlarmOff;
        private RadioButton RadioButtonAlarmOn;
        private Button ButtonSaveAlarm;
        private ListBox ListBoxAlarmMode;
        private Label LabelHeadValue;
        private Label LabelDescriptionHead;
        private Label LabelLightValue;
        private Label LabelDescriptionLight;
        private Label LabelFootValue;
        private Label LabelDescriptionFoot;
        private TabControl TabControlMain;
        private TabPage TabPageBed;
        private TabPage TabPageAlarm;
        private Button ButtonToggleEditMode;
        private Label LabelEditMode;
        private Label LabelDateTime;
        private Label LabelDateTimeValue;
        private Button ButtonSetDateTime;
        private Button ButtonAllNone;
        private Button ButtonQuery;
        private Button ButtonUnionDown;
        private Button ButtonUnionUp;
    }
}