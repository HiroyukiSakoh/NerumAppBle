using BleExample.Utils;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;


namespace BleExample
{
    public class アドバタイズ受信サンプル
    {
        public void サンプル()
        {
            var advWatcher = new BluetoothLEAdvertisementWatcher()
            {
                //スキャンモードを切り替えPassive
                ScanningMode = BluetoothLEScanningMode.Active,
            };

            //Nerum appはパッシブのアドバタイズでは、ServiceUuidとして 0xfff0,0xffb0を持つ
            if (advWatcher.ScanningMode == BluetoothLEScanningMode.Passive)
            {
                advWatcher.AdvertisementFilter.Advertisement.ServiceUuids.Add(BluetoothUuidHelper.FromShortId(0xfff0));
                advWatcher.AdvertisementFilter.Advertisement.ServiceUuids.Add(BluetoothUuidHelper.FromShortId(0xffb0));
            }

            advWatcher.SignalStrengthFilter.SamplingInterval = TimeSpan.FromMilliseconds(1000);
            advWatcher.Received += (BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs args) =>
            {
                try
                {
                    Console.WriteLine($"===============================");
                    //https://docs.microsoft.com/en-us/uwp/api/windows.devices.bluetooth.advertisement.bluetoothleadvertisementtype?view=winrt-22621#fields
                    Console.WriteLine($"AdvertisementType:{args.AdvertisementType}");

                    Console.WriteLine($"Address:{args.BluetoothAddress:X} Type:{args.BluetoothAddressType}");

                    Console.WriteLine($"LocalName:{args.Advertisement.LocalName}");
                    Console.WriteLine($"Flags:{args.Advertisement.Flags}");

                    Console.WriteLine($"ManufacturerData");
                    foreach (var bluetoothLEManufacturerData in args.Advertisement.ManufacturerData)
                    {
                        Console.WriteLine($"\tCompanyId:0x{bluetoothLEManufacturerData.CompanyId:X4}({BluetoothCompanyIdentifiers.GetCompanyName(bluetoothLEManufacturerData.CompanyId)})");
                        Console.WriteLine($"\tData:{BitConverter.ToString(bluetoothLEManufacturerData.Data.ToArray())}");
                    }
                    Console.WriteLine($"ServiceUuids");
                    foreach (var guid in args.Advertisement.ServiceUuids)
                    {
                        Console.WriteLine($"\t{guid}");
                    }
                    Console.WriteLine($"DataSections");
                    foreach (var adv in args.Advertisement.DataSections)
                    {
                        Console.WriteLine($"\t{adv.DataType:X2}({adv.DataTypeName()}):{BitConverter.ToString(adv.Data.ToArray())}");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex);
                }
            };
            advWatcher.Start();
            Console.ReadLine();
            advWatcher.Stop();
        }
    }
}
