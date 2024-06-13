using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;

namespace NerumAppBle
{
    public partial class MainForm : Form
    {

        public BluetoothLEAdvertisementWatcher AdvWatcher;
        public BindingList<BLEDevice> BLEDeviceList = new();

        public class BLEDevice
        {
            public ulong BluetoothAddress { get; set; }
            public string Label { get; set; } = default!;
        }

        public MainForm()
        {
            InitializeComponent();

            AdvWatcher = new BluetoothLEAdvertisementWatcher()
            {
                //スキャンモードを切り替えPassive
                ScanningMode = BluetoothLEScanningMode.Active,
            };
            //Nerum appはパッシブのアドバタイズでは、ServiceUuidとして 0xfff0,0xffb0を持つ
            if (AdvWatcher.ScanningMode == BluetoothLEScanningMode.Passive)
            {
                AdvWatcher.AdvertisementFilter.Advertisement.ServiceUuids.Add(BluetoothUuidHelper.FromShortId(0xfff0));
                AdvWatcher.AdvertisementFilter.Advertisement.ServiceUuids.Add(BluetoothUuidHelper.FromShortId(0xffb0));
            }

            AdvWatcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(1000);
            AdvWatcher.Received += (BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args) =>
            {
                try
                {
                    var bleDevice = BLEDeviceList.FirstOrDefault(x => x.BluetoothAddress == args.BluetoothAddress);
                    if (bleDevice == null)
                    {
                        bleDevice = new BLEDevice()
                        {
                            BluetoothAddress = args.BluetoothAddress,
                        };
                        BLEDeviceList.Add(bleDevice);

                        var sb = new StringBuilder();
                        sb.AppendLine($"===============================");
                        //https://docs.microsoft.com/en-us/uwp/api/windows.devices.bluetooth.advertisement.bluetoothleadvertisementtype?view=winrt-22621#fields
                        sb.AppendLine($"AdvertisementType:{args.AdvertisementType}");

                        sb.AppendLine($"Address:{args.BluetoothAddress:X} Type:{args.BluetoothAddressType}");

                        sb.AppendLine($"LocalName:{args.Advertisement.LocalName}");
                        sb.AppendLine($"Flags:{args.Advertisement.Flags}");

                        sb.AppendLine($"ManufacturerData");
                        foreach (var bluetoothLEManufacturerData in args.Advertisement.ManufacturerData)
                        {
                            sb.AppendLine($"\tCompanyId:0x{bluetoothLEManufacturerData.CompanyId:X4}");
                            sb.AppendLine($"\tData:{BitConverter.ToString(bluetoothLEManufacturerData.Data.ToArray())}");
                        }
                        sb.AppendLine($"ServiceUuids");
                        foreach (var guid in args.Advertisement.ServiceUuids)
                        {
                            sb.AppendLine($"\t{guid}");
                        }
                        sb.AppendLine($"DataSections");
                        foreach (var adv in args.Advertisement.DataSections)
                        {
                            sb.AppendLine($"\t{adv.DataType:X2}:{BitConverter.ToString(adv.Data.ToArray())}");
                        }
                        DebugForm?.DebugAppend(sb.ToString());
                    }
                    bleDevice.Label = $"{args.BluetoothAddress:X} {args.BluetoothAddressType} {args.Advertisement.LocalName}";

                    ComboBoxAddresses.Invoke(() => BLEDeviceList.ResetBindings());
                }
                catch (Exception ex)
                {
                    DebugForm?.DebugAppend(ex.ToString());
                }
            };

            ComboBoxAddresses.DataSource = BLEDeviceList;
            ComboBoxAddresses.DisplayMember = nameof(BLEDevice.Label);
        }

        public DebugForm? DebugForm = null;

        private async void ButtonLounchBedController_Click(object sender, EventArgs e)
        {
            try
            {
                var device = await BluetoothLEDevice.FromBluetoothAddressAsync(((BLEDevice)ComboBoxAddresses.SelectedItem).BluetoothAddress);
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

        private void ButtonScan_Click(object sender, EventArgs e)
        {
            if (ButtonScan.Text == "アドバタイズ受信")
            {
                AdvWatcher.Start();
                ButtonScan.Text = "アドバタイズ受信停止";
            }
            else
            {
                AdvWatcher.Stop();
                ButtonScan.Text = "アドバタイズ受信";
            }
        }
    }
}
