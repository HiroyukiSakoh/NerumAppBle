namespace NerumAppBle
{
    partial class MainForm
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
            ButtonLounchBedController = new Button();
            ButtonDebug = new Button();
            ComboBoxAddresses = new ComboBox();
            ButtonScan = new Button();
            SuspendLayout();
            // 
            // ButtonLounchBedController
            // 
            ButtonLounchBedController.Location = new Point(149, 35);
            ButtonLounchBedController.Name = "ButtonLounchBedController";
            ButtonLounchBedController.Size = new Size(60, 23);
            ButtonLounchBedController.TabIndex = 2;
            ButtonLounchBedController.Text = "接続";
            ButtonLounchBedController.UseVisualStyleBackColor = true;
            ButtonLounchBedController.Click += ButtonLounchBedController_Click;
            // 
            // ButtonDebug
            // 
            ButtonDebug.Location = new Point(215, 34);
            ButtonDebug.Name = "ButtonDebug";
            ButtonDebug.Size = new Size(57, 23);
            ButtonDebug.TabIndex = 2;
            ButtonDebug.Text = "Debug";
            ButtonDebug.UseVisualStyleBackColor = true;
            ButtonDebug.Click += btnDebug_Click;
            // 
            // ComboBoxAddresses
            // 
            ComboBoxAddresses.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxAddresses.FormattingEnabled = true;
            ComboBoxAddresses.Location = new Point(12, 6);
            ComboBoxAddresses.Name = "ComboBoxAddresses";
            ComboBoxAddresses.Size = new Size(260, 23);
            ComboBoxAddresses.TabIndex = 3;
            // 
            // ButtonScan
            // 
            ButtonScan.Location = new Point(12, 34);
            ButtonScan.Name = "ButtonScan";
            ButtonScan.Size = new Size(131, 23);
            ButtonScan.TabIndex = 4;
            ButtonScan.Text = "アドバタイズ受信";
            ButtonScan.UseVisualStyleBackColor = true;
            ButtonScan.Click += ButtonScan_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 61);
            Controls.Add(ButtonScan);
            Controls.Add(ComboBoxAddresses);
            Controls.Add(ButtonDebug);
            Controls.Add(ButtonLounchBedController);
            MaximumSize = new Size(300, 100);
            MinimumSize = new Size(300, 100);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonLounchBedController;
        private Button ButtonDebug;
        private ComboBox ComboBoxAddresses;
        private Button ButtonScan;
    }
}