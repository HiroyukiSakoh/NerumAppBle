using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;

namespace NerumAppBle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public DebugForm? DebugForm = null;

        private async void ButtonLounchBedController_Click(object sender, EventArgs e)
        {
            try
            {
                var device = await BluetoothLEDevice.FromBluetoothAddressAsync(ulong.Parse(TextBoxAddress.Text,NumberStyles.AllowHexSpecifier));
                var bedControllerForm = new BedControllerForm(device);
                bedControllerForm.Show(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDebug_Click(object sender, EventArgs e)
        {
            if (DebugForm == null)
            {
                DebugForm = new DebugForm();
                DebugForm.FormClosed += (s, e) =>
                {
                    DebugForm.Dispose();
                    DebugForm = null;
                };
                DebugForm.Show();
            }
            else
            {
                DebugForm.Focus();
            }
        }
    }
}
