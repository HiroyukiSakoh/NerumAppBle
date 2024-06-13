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
            ButtonHeadUp = new Button();
            ButtonHeadDown = new Button();
            ButtonFootUp = new Button();
            ButtonFootDown = new Button();
            ButtonMemory1 = new Button();
            ButtonLight = new Button();
            ButtonAntiSnore = new Button();
            ButtonZeroG = new Button();
            ButtonReading = new Button();
            ButtonFlat = new Button();
            ButtonMemory2 = new Button();
            ListBoxAlarmMode = new ListBox();
            CheckedListBoxAlarmDayOfWeek = new CheckedListBox();
            DateTimePickerAlarmTime = new DateTimePicker();
            RadioButtonAlarmOn = new RadioButton();
            RadioButtonAlarmOff = new RadioButton();
            ButtonSaveAlarm = new Button();
            LabelLightValue = new Label();
            LabelDescriptionLight = new Label();
            LabelFootValue = new Label();
            LabelDescriptionFoot = new Label();
            LabelHeadValue = new Label();
            LabelDescriptionHead = new Label();
            TabControlMain = new TabControl();
            TabPageBed = new TabPage();
            ButtonUnionDown = new Button();
            ButtonUnionUp = new Button();
            ButtonQuery = new Button();
            ButtonAllNone = new Button();
            TabPageAlarm = new TabPage();
            ListBoxAlarmMode3 = new ListBox();
            CheckedListBoxAlarmDayOfWeek3 = new CheckedListBox();
            DateTimePickerAlarmTime3 = new DateTimePicker();
            RadioButtonAlarmOn3 = new RadioButton();
            RadioButtonAlarmOff3 = new RadioButton();
            ListBoxAlarmMode2 = new ListBox();
            CheckedListBoxAlarmDayOfWeek2 = new CheckedListBox();
            DateTimePickerAlarmTime2 = new DateTimePicker();
            RadioButtonAlarmOn2 = new RadioButton();
            RadioButtonAlarmOff2 = new RadioButton();
            ButtonSetDateTime = new Button();
            LabelDateTimeValue = new Label();
            LabelDateTime = new Label();
            LabelEditMode = new Label();
            ButtonToggleEditMode = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            TabControlMain.SuspendLayout();
            TabPageBed.SuspendLayout();
            TabPageAlarm.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonHeadUp
            // 
            ButtonHeadUp.Location = new Point(72, 152);
            ButtonHeadUp.Name = "ButtonHeadUp";
            ButtonHeadUp.Size = new Size(55, 55);
            ButtonHeadUp.TabIndex = 3;
            ButtonHeadUp.Text = "HEAD UP";
            ButtonHeadUp.UseVisualStyleBackColor = true;
            ButtonHeadUp.Click += ButtonHeadUp_Click;
            // 
            // ButtonHeadDown
            // 
            ButtonHeadDown.Location = new Point(72, 274);
            ButtonHeadDown.Name = "ButtonHeadDown";
            ButtonHeadDown.Size = new Size(55, 55);
            ButtonHeadDown.TabIndex = 7;
            ButtonHeadDown.Text = "HEAD DOWN";
            ButtonHeadDown.UseVisualStyleBackColor = true;
            ButtonHeadDown.Click += ButtonHeadDown_Click;
            // 
            // ButtonFootUp
            // 
            ButtonFootUp.Location = new Point(11, 213);
            ButtonFootUp.Name = "ButtonFootUp";
            ButtonFootUp.Size = new Size(55, 55);
            ButtonFootUp.TabIndex = 4;
            ButtonFootUp.Text = "FOOT UP";
            ButtonFootUp.UseVisualStyleBackColor = true;
            ButtonFootUp.Click += ButtonFootUp_Click;
            // 
            // ButtonFootDown
            // 
            ButtonFootDown.Location = new Point(133, 213);
            ButtonFootDown.Name = "ButtonFootDown";
            ButtonFootDown.Size = new Size(55, 55);
            ButtonFootDown.TabIndex = 6;
            ButtonFootDown.Text = "FOOT DOWN";
            ButtonFootDown.UseVisualStyleBackColor = true;
            ButtonFootDown.Click += ButtonFootDown_Click;
            // 
            // ButtonMemory1
            // 
            ButtonMemory1.Location = new Point(11, 97);
            ButtonMemory1.Name = "ButtonMemory1";
            ButtonMemory1.Size = new Size(55, 55);
            ButtonMemory1.TabIndex = 1;
            ButtonMemory1.Text = "MEMORY 1";
            ButtonMemory1.UseVisualStyleBackColor = true;
            ButtonMemory1.Click += ButtonMemory1_Click;
            // 
            // ButtonLight
            // 
            ButtonLight.Location = new Point(72, 73);
            ButtonLight.Name = "ButtonLight";
            ButtonLight.Size = new Size(55, 55);
            ButtonLight.TabIndex = 0;
            ButtonLight.Text = "LIGHT";
            ButtonLight.UseVisualStyleBackColor = true;
            ButtonLight.Click += ButtonLight_Click;
            // 
            // ButtonAntiSnore
            // 
            ButtonAntiSnore.Location = new Point(11, 335);
            ButtonAntiSnore.Name = "ButtonAntiSnore";
            ButtonAntiSnore.Size = new Size(55, 55);
            ButtonAntiSnore.TabIndex = 8;
            ButtonAntiSnore.Text = "ANTI SNORE";
            ButtonAntiSnore.UseVisualStyleBackColor = true;
            ButtonAntiSnore.Click += ButtonAntiSnore_Click;
            // 
            // ButtonZeroG
            // 
            ButtonZeroG.Location = new Point(72, 335);
            ButtonZeroG.Name = "ButtonZeroG";
            ButtonZeroG.Size = new Size(55, 55);
            ButtonZeroG.TabIndex = 9;
            ButtonZeroG.Text = "Zero G";
            ButtonZeroG.UseVisualStyleBackColor = true;
            ButtonZeroG.Click += ButtonZeroG_Click;
            // 
            // ButtonReading
            // 
            ButtonReading.Location = new Point(133, 335);
            ButtonReading.Name = "ButtonReading";
            ButtonReading.Size = new Size(55, 55);
            ButtonReading.TabIndex = 10;
            ButtonReading.Text = "READING";
            ButtonReading.UseVisualStyleBackColor = true;
            ButtonReading.Click += ButtonReading_Click;
            // 
            // ButtonFlat
            // 
            ButtonFlat.Location = new Point(72, 213);
            ButtonFlat.Name = "ButtonFlat";
            ButtonFlat.Size = new Size(55, 55);
            ButtonFlat.TabIndex = 5;
            ButtonFlat.Text = "FLAT";
            ButtonFlat.UseVisualStyleBackColor = true;
            ButtonFlat.Click += ButtonFlat_Click;
            // 
            // ButtonMemory2
            // 
            ButtonMemory2.Location = new Point(133, 97);
            ButtonMemory2.Name = "ButtonMemory2";
            ButtonMemory2.Size = new Size(55, 55);
            ButtonMemory2.TabIndex = 2;
            ButtonMemory2.Text = "MEMORY 2";
            ButtonMemory2.UseVisualStyleBackColor = true;
            ButtonMemory2.Click += ButtonMemory2_Click;
            // 
            // ListBoxAlarmMode
            // 
            ListBoxAlarmMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxAlarmMode.Enabled = false;
            ListBoxAlarmMode.FormattingEnabled = true;
            ListBoxAlarmMode.ItemHeight = 15;
            ListBoxAlarmMode.Items.AddRange(new object[] { "なし", "M1", "M2", "灯り" });
            ListBoxAlarmMode.Location = new Point(6, 200);
            ListBoxAlarmMode.Name = "ListBoxAlarmMode";
            ListBoxAlarmMode.Size = new Size(110, 64);
            ListBoxAlarmMode.TabIndex = 6;
            // 
            // CheckedListBoxAlarmDayOfWeek
            // 
            CheckedListBoxAlarmDayOfWeek.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CheckedListBoxAlarmDayOfWeek.Enabled = false;
            CheckedListBoxAlarmDayOfWeek.FormattingEnabled = true;
            CheckedListBoxAlarmDayOfWeek.Items.AddRange(new object[] { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" });
            CheckedListBoxAlarmDayOfWeek.Location = new Point(6, 35);
            CheckedListBoxAlarmDayOfWeek.Name = "CheckedListBoxAlarmDayOfWeek";
            CheckedListBoxAlarmDayOfWeek.Size = new Size(110, 130);
            CheckedListBoxAlarmDayOfWeek.TabIndex = 1;
            // 
            // DateTimePickerAlarmTime
            // 
            DateTimePickerAlarmTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DateTimePickerAlarmTime.CustomFormat = "HH:mm";
            DateTimePickerAlarmTime.Enabled = false;
            DateTimePickerAlarmTime.Format = DateTimePickerFormat.Custom;
            DateTimePickerAlarmTime.Location = new Point(6, 171);
            DateTimePickerAlarmTime.Name = "DateTimePickerAlarmTime";
            DateTimePickerAlarmTime.ShowUpDown = true;
            DateTimePickerAlarmTime.Size = new Size(110, 23);
            DateTimePickerAlarmTime.TabIndex = 2;
            // 
            // RadioButtonAlarmOn
            // 
            RadioButtonAlarmOn.AutoSize = true;
            RadioButtonAlarmOn.Checked = true;
            RadioButtonAlarmOn.Enabled = false;
            RadioButtonAlarmOn.Location = new Point(2, 2);
            RadioButtonAlarmOn.Name = "RadioButtonAlarmOn";
            RadioButtonAlarmOn.Size = new Size(43, 19);
            RadioButtonAlarmOn.TabIndex = 3;
            RadioButtonAlarmOn.TabStop = true;
            RadioButtonAlarmOn.Text = "ON";
            RadioButtonAlarmOn.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlarmOff
            // 
            RadioButtonAlarmOff.AutoSize = true;
            RadioButtonAlarmOff.Enabled = false;
            RadioButtonAlarmOff.Location = new Point(51, 2);
            RadioButtonAlarmOff.Name = "RadioButtonAlarmOff";
            RadioButtonAlarmOff.Size = new Size(46, 19);
            RadioButtonAlarmOff.TabIndex = 4;
            RadioButtonAlarmOff.Text = "OFF";
            RadioButtonAlarmOff.UseVisualStyleBackColor = true;
            // 
            // ButtonSaveAlarm
            // 
            ButtonSaveAlarm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSaveAlarm.Enabled = false;
            ButtonSaveAlarm.Location = new Point(279, 6);
            ButtonSaveAlarm.Name = "ButtonSaveAlarm";
            ButtonSaveAlarm.Size = new Size(63, 23);
            ButtonSaveAlarm.TabIndex = 5;
            ButtonSaveAlarm.Text = "保存";
            ButtonSaveAlarm.UseVisualStyleBackColor = true;
            ButtonSaveAlarm.Click += ButtonSaveAlarm_Click;
            // 
            // LabelLightValue
            // 
            LabelLightValue.AutoSize = true;
            LabelLightValue.Location = new Point(50, 43);
            LabelLightValue.Name = "LabelLightValue";
            LabelLightValue.Size = new Size(25, 15);
            LabelLightValue.TabIndex = 0;
            LabelLightValue.Text = "ON";
            // 
            // LabelDescriptionLight
            // 
            LabelDescriptionLight.AutoSize = true;
            LabelDescriptionLight.Location = new Point(6, 43);
            LabelDescriptionLight.Name = "LabelDescriptionLight";
            LabelDescriptionLight.Size = new Size(39, 15);
            LabelDescriptionLight.TabIndex = 0;
            LabelDescriptionLight.Text = "LIGHT";
            // 
            // LabelFootValue
            // 
            LabelFootValue.AutoSize = true;
            LabelFootValue.Location = new Point(50, 28);
            LabelFootValue.Name = "LabelFootValue";
            LabelFootValue.Size = new Size(17, 15);
            LabelFootValue.TabIndex = 0;
            LabelFootValue.Text = "%";
            // 
            // LabelDescriptionFoot
            // 
            LabelDescriptionFoot.AutoSize = true;
            LabelDescriptionFoot.Location = new Point(6, 28);
            LabelDescriptionFoot.Name = "LabelDescriptionFoot";
            LabelDescriptionFoot.Size = new Size(37, 15);
            LabelDescriptionFoot.TabIndex = 0;
            LabelDescriptionFoot.Text = "FOOT";
            // 
            // LabelHeadValue
            // 
            LabelHeadValue.AutoSize = true;
            LabelHeadValue.Location = new Point(50, 13);
            LabelHeadValue.Name = "LabelHeadValue";
            LabelHeadValue.Size = new Size(17, 15);
            LabelHeadValue.TabIndex = 0;
            LabelHeadValue.Text = "%";
            // 
            // LabelDescriptionHead
            // 
            LabelDescriptionHead.AutoSize = true;
            LabelDescriptionHead.Location = new Point(6, 13);
            LabelDescriptionHead.Name = "LabelDescriptionHead";
            LabelDescriptionHead.Size = new Size(38, 15);
            LabelDescriptionHead.TabIndex = 0;
            LabelDescriptionHead.Text = "HEAD";
            // 
            // TabControlMain
            // 
            TabControlMain.Controls.Add(TabPageBed);
            TabControlMain.Controls.Add(TabPageAlarm);
            TabControlMain.Dock = DockStyle.Fill;
            TabControlMain.Enabled = false;
            TabControlMain.Location = new Point(0, 0);
            TabControlMain.Name = "TabControlMain";
            TabControlMain.SelectedIndex = 0;
            TabControlMain.Size = new Size(353, 431);
            TabControlMain.TabIndex = 4;
            TabControlMain.SelectedIndexChanged += TabControlMain_SelectedIndexChanged;
            // 
            // TabPageBed
            // 
            TabPageBed.Controls.Add(ButtonUnionDown);
            TabPageBed.Controls.Add(ButtonUnionUp);
            TabPageBed.Controls.Add(ButtonQuery);
            TabPageBed.Controls.Add(ButtonAllNone);
            TabPageBed.Controls.Add(LabelLightValue);
            TabPageBed.Controls.Add(ButtonLight);
            TabPageBed.Controls.Add(LabelDescriptionLight);
            TabPageBed.Controls.Add(ButtonMemory1);
            TabPageBed.Controls.Add(LabelFootValue);
            TabPageBed.Controls.Add(ButtonFootDown);
            TabPageBed.Controls.Add(LabelDescriptionFoot);
            TabPageBed.Controls.Add(ButtonMemory2);
            TabPageBed.Controls.Add(LabelHeadValue);
            TabPageBed.Controls.Add(LabelDescriptionHead);
            TabPageBed.Controls.Add(ButtonReading);
            TabPageBed.Controls.Add(ButtonHeadUp);
            TabPageBed.Controls.Add(ButtonZeroG);
            TabPageBed.Controls.Add(ButtonHeadDown);
            TabPageBed.Controls.Add(ButtonAntiSnore);
            TabPageBed.Controls.Add(ButtonFootUp);
            TabPageBed.Controls.Add(ButtonFlat);
            TabPageBed.Location = new Point(4, 24);
            TabPageBed.Name = "TabPageBed";
            TabPageBed.Padding = new Padding(3);
            TabPageBed.Size = new Size(345, 403);
            TabPageBed.TabIndex = 0;
            TabPageBed.Text = "操作";
            TabPageBed.UseVisualStyleBackColor = true;
            // 
            // ButtonUnionDown
            // 
            ButtonUnionDown.BackColor = Color.Gray;
            ButtonUnionDown.Location = new Point(137, 184);
            ButtonUnionDown.Name = "ButtonUnionDown";
            ButtonUnionDown.Size = new Size(49, 23);
            ButtonUnionDown.TabIndex = 12;
            ButtonUnionDown.Text = "U↓";
            ButtonUnionDown.UseVisualStyleBackColor = false;
            ButtonUnionDown.Click += ButtonUnionDown_Click;
            // 
            // ButtonUnionUp
            // 
            ButtonUnionUp.BackColor = Color.Gray;
            ButtonUnionUp.Location = new Point(137, 158);
            ButtonUnionUp.Name = "ButtonUnionUp";
            ButtonUnionUp.Size = new Size(49, 23);
            ButtonUnionUp.TabIndex = 12;
            ButtonUnionUp.Text = "U↑";
            ButtonUnionUp.UseVisualStyleBackColor = false;
            ButtonUnionUp.Click += ButtonUnionUp_Click;
            // 
            // ButtonQuery
            // 
            ButtonQuery.BackColor = Color.Silver;
            ButtonQuery.Location = new Point(125, 37);
            ButtonQuery.Name = "ButtonQuery";
            ButtonQuery.Size = new Size(61, 30);
            ButtonQuery.TabIndex = 11;
            ButtonQuery.Text = "Query";
            ButtonQuery.UseVisualStyleBackColor = false;
            ButtonQuery.Click += ButtonQuery_Click;
            // 
            // ButtonAllNone
            // 
            ButtonAllNone.BackColor = Color.Silver;
            ButtonAllNone.Location = new Point(125, 7);
            ButtonAllNone.Name = "ButtonAllNone";
            ButtonAllNone.Size = new Size(61, 30);
            ButtonAllNone.TabIndex = 11;
            ButtonAllNone.Text = "AllNone";
            ButtonAllNone.UseVisualStyleBackColor = false;
            ButtonAllNone.Click += ButtonStop_Click;
            // 
            // TabPageAlarm
            // 
            TabPageAlarm.Controls.Add(panel3);
            TabPageAlarm.Controls.Add(panel2);
            TabPageAlarm.Controls.Add(panel1);
            TabPageAlarm.Controls.Add(ListBoxAlarmMode3);
            TabPageAlarm.Controls.Add(CheckedListBoxAlarmDayOfWeek3);
            TabPageAlarm.Controls.Add(DateTimePickerAlarmTime3);
            TabPageAlarm.Controls.Add(ListBoxAlarmMode2);
            TabPageAlarm.Controls.Add(CheckedListBoxAlarmDayOfWeek2);
            TabPageAlarm.Controls.Add(DateTimePickerAlarmTime2);
            TabPageAlarm.Controls.Add(ButtonSetDateTime);
            TabPageAlarm.Controls.Add(LabelDateTimeValue);
            TabPageAlarm.Controls.Add(LabelDateTime);
            TabPageAlarm.Controls.Add(LabelEditMode);
            TabPageAlarm.Controls.Add(ButtonToggleEditMode);
            TabPageAlarm.Controls.Add(ListBoxAlarmMode);
            TabPageAlarm.Controls.Add(CheckedListBoxAlarmDayOfWeek);
            TabPageAlarm.Controls.Add(DateTimePickerAlarmTime);
            TabPageAlarm.Controls.Add(ButtonSaveAlarm);
            TabPageAlarm.Location = new Point(4, 24);
            TabPageAlarm.Name = "TabPageAlarm";
            TabPageAlarm.Padding = new Padding(3);
            TabPageAlarm.Size = new Size(345, 403);
            TabPageAlarm.TabIndex = 1;
            TabPageAlarm.Text = "アラーム";
            TabPageAlarm.UseVisualStyleBackColor = true;
            // 
            // ListBoxAlarmMode3
            // 
            ListBoxAlarmMode3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxAlarmMode3.Enabled = false;
            ListBoxAlarmMode3.FormattingEnabled = true;
            ListBoxAlarmMode3.ItemHeight = 15;
            ListBoxAlarmMode3.Items.AddRange(new object[] { "なし", "M1", "M2", "灯り" });
            ListBoxAlarmMode3.Location = new Point(232, 200);
            ListBoxAlarmMode3.Name = "ListBoxAlarmMode3";
            ListBoxAlarmMode3.Size = new Size(110, 64);
            ListBoxAlarmMode3.TabIndex = 21;
            // 
            // CheckedListBoxAlarmDayOfWeek3
            // 
            CheckedListBoxAlarmDayOfWeek3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CheckedListBoxAlarmDayOfWeek3.Enabled = false;
            CheckedListBoxAlarmDayOfWeek3.FormattingEnabled = true;
            CheckedListBoxAlarmDayOfWeek3.Items.AddRange(new object[] { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" });
            CheckedListBoxAlarmDayOfWeek3.Location = new Point(232, 35);
            CheckedListBoxAlarmDayOfWeek3.Name = "CheckedListBoxAlarmDayOfWeek3";
            CheckedListBoxAlarmDayOfWeek3.Size = new Size(110, 130);
            CheckedListBoxAlarmDayOfWeek3.TabIndex = 17;
            // 
            // DateTimePickerAlarmTime3
            // 
            DateTimePickerAlarmTime3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DateTimePickerAlarmTime3.CustomFormat = "HH:mm";
            DateTimePickerAlarmTime3.Enabled = false;
            DateTimePickerAlarmTime3.Format = DateTimePickerFormat.Custom;
            DateTimePickerAlarmTime3.Location = new Point(232, 171);
            DateTimePickerAlarmTime3.Name = "DateTimePickerAlarmTime3";
            DateTimePickerAlarmTime3.ShowUpDown = true;
            DateTimePickerAlarmTime3.Size = new Size(110, 23);
            DateTimePickerAlarmTime3.TabIndex = 18;
            // 
            // RadioButtonAlarmOn3
            // 
            RadioButtonAlarmOn3.AutoSize = true;
            RadioButtonAlarmOn3.Checked = true;
            RadioButtonAlarmOn3.Enabled = false;
            RadioButtonAlarmOn3.Location = new Point(3, 2);
            RadioButtonAlarmOn3.Name = "RadioButtonAlarmOn3";
            RadioButtonAlarmOn3.Size = new Size(43, 19);
            RadioButtonAlarmOn3.TabIndex = 19;
            RadioButtonAlarmOn3.TabStop = true;
            RadioButtonAlarmOn3.Text = "ON";
            RadioButtonAlarmOn3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlarmOff3
            // 
            RadioButtonAlarmOff3.AutoSize = true;
            RadioButtonAlarmOff3.Enabled = false;
            RadioButtonAlarmOff3.Location = new Point(52, 2);
            RadioButtonAlarmOff3.Name = "RadioButtonAlarmOff3";
            RadioButtonAlarmOff3.Size = new Size(46, 19);
            RadioButtonAlarmOff3.TabIndex = 20;
            RadioButtonAlarmOff3.Text = "OFF";
            RadioButtonAlarmOff3.UseVisualStyleBackColor = true;
            // 
            // ListBoxAlarmMode2
            // 
            ListBoxAlarmMode2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ListBoxAlarmMode2.Enabled = false;
            ListBoxAlarmMode2.FormattingEnabled = true;
            ListBoxAlarmMode2.ItemHeight = 15;
            ListBoxAlarmMode2.Items.AddRange(new object[] { "なし", "M1", "M2", "灯り" });
            ListBoxAlarmMode2.Location = new Point(119, 200);
            ListBoxAlarmMode2.Name = "ListBoxAlarmMode2";
            ListBoxAlarmMode2.Size = new Size(110, 64);
            ListBoxAlarmMode2.TabIndex = 16;
            // 
            // CheckedListBoxAlarmDayOfWeek2
            // 
            CheckedListBoxAlarmDayOfWeek2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CheckedListBoxAlarmDayOfWeek2.Enabled = false;
            CheckedListBoxAlarmDayOfWeek2.FormattingEnabled = true;
            CheckedListBoxAlarmDayOfWeek2.Items.AddRange(new object[] { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日" });
            CheckedListBoxAlarmDayOfWeek2.Location = new Point(119, 35);
            CheckedListBoxAlarmDayOfWeek2.Name = "CheckedListBoxAlarmDayOfWeek2";
            CheckedListBoxAlarmDayOfWeek2.Size = new Size(110, 130);
            CheckedListBoxAlarmDayOfWeek2.TabIndex = 12;
            // 
            // DateTimePickerAlarmTime2
            // 
            DateTimePickerAlarmTime2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DateTimePickerAlarmTime2.CustomFormat = "HH:mm";
            DateTimePickerAlarmTime2.Enabled = false;
            DateTimePickerAlarmTime2.Format = DateTimePickerFormat.Custom;
            DateTimePickerAlarmTime2.Location = new Point(119, 171);
            DateTimePickerAlarmTime2.Name = "DateTimePickerAlarmTime2";
            DateTimePickerAlarmTime2.ShowUpDown = true;
            DateTimePickerAlarmTime2.Size = new Size(110, 23);
            DateTimePickerAlarmTime2.TabIndex = 13;
            // 
            // RadioButtonAlarmOn2
            // 
            RadioButtonAlarmOn2.AutoSize = true;
            RadioButtonAlarmOn2.Checked = true;
            RadioButtonAlarmOn2.Enabled = false;
            RadioButtonAlarmOn2.Location = new Point(3, 2);
            RadioButtonAlarmOn2.Name = "RadioButtonAlarmOn2";
            RadioButtonAlarmOn2.Size = new Size(43, 19);
            RadioButtonAlarmOn2.TabIndex = 14;
            RadioButtonAlarmOn2.TabStop = true;
            RadioButtonAlarmOn2.Text = "ON";
            RadioButtonAlarmOn2.UseVisualStyleBackColor = true;
            // 
            // RadioButtonAlarmOff2
            // 
            RadioButtonAlarmOff2.AutoSize = true;
            RadioButtonAlarmOff2.Enabled = false;
            RadioButtonAlarmOff2.Location = new Point(52, 2);
            RadioButtonAlarmOff2.Name = "RadioButtonAlarmOff2";
            RadioButtonAlarmOff2.Size = new Size(46, 19);
            RadioButtonAlarmOff2.TabIndex = 15;
            RadioButtonAlarmOff2.Text = "OFF";
            RadioButtonAlarmOff2.UseVisualStyleBackColor = true;
            // 
            // ButtonSetDateTime
            // 
            ButtonSetDateTime.Location = new Point(3, 320);
            ButtonSetDateTime.Name = "ButtonSetDateTime";
            ButtonSetDateTime.Size = new Size(67, 23);
            ButtonSetDateTime.TabIndex = 11;
            ButtonSetDateTime.Text = "時刻設定";
            ButtonSetDateTime.UseVisualStyleBackColor = true;
            ButtonSetDateTime.Click += ButtonSetDateTime_Click;
            // 
            // LabelDateTimeValue
            // 
            LabelDateTimeValue.AutoSize = true;
            LabelDateTimeValue.Location = new Point(59, 302);
            LabelDateTimeValue.Name = "LabelDateTimeValue";
            LabelDateTimeValue.Size = new Size(134, 15);
            LabelDateTimeValue.TabIndex = 10;
            LabelDateTimeValue.Text = "yyyy/MM/dd HH:mm:ss";
            // 
            // LabelDateTime
            // 
            LabelDateTime.AutoSize = true;
            LabelDateTime.Location = new Point(6, 302);
            LabelDateTime.Name = "LabelDateTime";
            LabelDateTime.Size = new Size(55, 15);
            LabelDateTime.TabIndex = 9;
            LabelDateTime.Text = "内部時刻";
            // 
            // LabelEditMode
            // 
            LabelEditMode.AutoSize = true;
            LabelEditMode.Location = new Point(84, 10);
            LabelEditMode.Name = "LabelEditMode";
            LabelEditMode.Size = new Size(43, 15);
            LabelEditMode.TabIndex = 8;
            LabelEditMode.Text = "表示中";
            // 
            // ButtonToggleEditMode
            // 
            ButtonToggleEditMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonToggleEditMode.Location = new Point(8, 6);
            ButtonToggleEditMode.Name = "ButtonToggleEditMode";
            ButtonToggleEditMode.Size = new Size(73, 23);
            ButtonToggleEditMode.TabIndex = 7;
            ButtonToggleEditMode.Text = "モード変更";
            ButtonToggleEditMode.UseVisualStyleBackColor = true;
            ButtonToggleEditMode.Click += ButtonToggleEditMode_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(RadioButtonAlarmOn);
            panel1.Controls.Add(RadioButtonAlarmOff);
            panel1.Location = new Point(8, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 26);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(RadioButtonAlarmOn2);
            panel2.Controls.Add(RadioButtonAlarmOff2);
            panel2.Location = new Point(119, 268);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 26);
            panel2.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(RadioButtonAlarmOn3);
            panel3.Controls.Add(RadioButtonAlarmOff3);
            panel3.Location = new Point(233, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(109, 26);
            panel3.TabIndex = 24;
            // 
            // BedControllerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 431);
            Controls.Add(TabControlMain);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BedControllerForm";
            Text = "NerumApp BLE Contoller";
            FormClosing += BedControllerForm_FormClosing;
            Load += BedControllerForm_Load;
            TabControlMain.ResumeLayout(false);
            TabPageBed.ResumeLayout(false);
            TabPageBed.PerformLayout();
            TabPageAlarm.ResumeLayout(false);
            TabPageAlarm.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private ListBox ListBoxAlarmMode3;
        private CheckedListBox CheckedListBoxAlarmDayOfWeek3;
        private DateTimePicker DateTimePickerAlarmTime3;
        private RadioButton RadioButtonAlarmOn3;
        private RadioButton RadioButtonAlarmOff3;
        private ListBox ListBoxAlarmMode2;
        private CheckedListBox CheckedListBoxAlarmDayOfWeek2;
        private DateTimePicker DateTimePickerAlarmTime2;
        private RadioButton RadioButtonAlarmOn2;
        private RadioButton RadioButtonAlarmOff2;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
    }
}