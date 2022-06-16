using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NerumAppBle
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxDebug.Clear();
        }

        public async Task DebugAppendAsync(Func<Task<string>> asyncAction)
        {
            if (CheckBoxEnableDebug.Checked)
            {
                var value = await asyncAction.Invoke();
                DebugAppend(value);
            }
        }
        public void DebugAppend(Func<string> action)
        {
            if (CheckBoxEnableDebug.Checked)
            {
                DebugAppend(action.Invoke());
            }
        }
        public void DebugAppend(string value)
        {
            if (CheckBoxEnableDebug.Checked)
            {
                this.Invoke(() =>
                {
                    TextBoxDebug.AppendText("\r\n" + value);
                });
            }
        }

    }
}
