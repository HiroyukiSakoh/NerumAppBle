namespace NerumAppBle
{
    partial class DebugForm
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
            this.ButtonClear = new System.Windows.Forms.Button();
            this.TextBoxDebug = new System.Windows.Forms.TextBox();
            this.CheckBoxEnableDebug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ButtonClear
            // 
            this.ButtonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClear.Location = new System.Drawing.Point(713, 12);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 0;
            this.ButtonClear.Text = "クリア";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // TextBoxDebug
            // 
            this.TextBoxDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxDebug.Location = new System.Drawing.Point(12, 41);
            this.TextBoxDebug.Multiline = true;
            this.TextBoxDebug.Name = "TextBoxDebug";
            this.TextBoxDebug.ReadOnly = true;
            this.TextBoxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxDebug.Size = new System.Drawing.Size(776, 403);
            this.TextBoxDebug.TabIndex = 1;
            // 
            // CheckBoxEnableDebug
            // 
            this.CheckBoxEnableDebug.AutoSize = true;
            this.CheckBoxEnableDebug.Checked = true;
            this.CheckBoxEnableDebug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxEnableDebug.Location = new System.Drawing.Point(621, 15);
            this.CheckBoxEnableDebug.Name = "CheckBoxEnableDebug";
            this.CheckBoxEnableDebug.Size = new System.Drawing.Size(86, 19);
            this.CheckBoxEnableDebug.TabIndex = 2;
            this.CheckBoxEnableDebug.Text = "デバッグ有効";
            this.CheckBoxEnableDebug.UseVisualStyleBackColor = true;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBoxEnableDebug);
            this.Controls.Add(this.TextBoxDebug);
            this.Controls.Add(this.ButtonClear);
            this.Name = "DebugForm";
            this.Text = "デバッグ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonClear;
        private TextBox TextBoxDebug;
        private CheckBox CheckBoxEnableDebug;
    }
}