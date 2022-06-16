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
            this.LabelAddress = new System.Windows.Forms.Label();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.ButtonLounchBedController = new System.Windows.Forms.Button();
            this.ButtonDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelAddress
            // 
            this.LabelAddress.AutoSize = true;
            this.LabelAddress.Location = new System.Drawing.Point(12, 9);
            this.LabelAddress.Name = "LabelAddress";
            this.LabelAddress.Size = new System.Drawing.Size(49, 15);
            this.LabelAddress.TabIndex = 0;
            this.LabelAddress.Text = "Address";
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Location = new System.Drawing.Point(67, 5);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(124, 23);
            this.TextBoxAddress.TabIndex = 1;
            this.TextBoxAddress.Text = "30E283XXXXXX";
            // 
            // ButtonLounchBedController
            // 
            this.ButtonLounchBedController.Location = new System.Drawing.Point(197, 5);
            this.ButtonLounchBedController.Name = "ButtonLounchBedController";
            this.ButtonLounchBedController.Size = new System.Drawing.Size(75, 23);
            this.ButtonLounchBedController.TabIndex = 2;
            this.ButtonLounchBedController.Text = "接続";
            this.ButtonLounchBedController.UseVisualStyleBackColor = true;
            this.ButtonLounchBedController.Click += new System.EventHandler(this.ButtonLounchBedController_Click);
            // 
            // ButtonDebug
            // 
            this.ButtonDebug.Location = new System.Drawing.Point(197, 34);
            this.ButtonDebug.Name = "ButtonDebug";
            this.ButtonDebug.Size = new System.Drawing.Size(75, 23);
            this.ButtonDebug.TabIndex = 2;
            this.ButtonDebug.Text = "Debug";
            this.ButtonDebug.UseVisualStyleBackColor = true;
            this.ButtonDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 61);
            this.Controls.Add(this.ButtonDebug);
            this.Controls.Add(this.ButtonLounchBedController);
            this.Controls.Add(this.TextBoxAddress);
            this.Controls.Add(this.LabelAddress);
            this.MaximumSize = new System.Drawing.Size(300, 100);
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelAddress;
        private TextBox TextBoxAddress;
        private Button ButtonLounchBedController;
        private Button ButtonDebug;
    }
}