using BleExample.Utils;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;


namespace BleExample
{
    public class サービスとキャラクタリスティックの列挙サンプル
    {
        public async Task サンプルAsync(ulong bluetoothAddress)
        {
            var device = await BluetoothLEDevice.FromBluetoothAddressAsync(bluetoothAddress);

            //GATTサービスを取得
            var gatt = await device.GetGattServicesAsync();
            Console.WriteLine($"{device.Name} Services: {gatt.Services.Count}, {gatt.Status} {gatt.ProtocolError}");

            //GATTサービスを列挙
            foreach (var service in gatt.Services)
            {
                Console.WriteLine("=========================");

                //GATTキャラクタリスティックを取得
                var characs = await service.GetCharacteristicsAsync();
                Console.WriteLine($"Service:0x{service.Uuid.ToShortId()} {service.Name()} {characs.Status} {characs.ProtocolError}");

                //GATTキャラクタリスティックを列挙
                foreach (var character in characs.Characteristics)
                {
                    //GATTディスクリプタを取得
                    var gattDescriptorsResult = await character.GetDescriptorsAsync();

                    Console.WriteLine($"\tCharacteristic:0x{character.Uuid.ToShortId()} {character.Name()} Description:{character.UserDescription},Properties:{character.CharacteristicProperties}");

                    Console.WriteLine($"\t\tGetDescriptors:{gattDescriptorsResult.Status},Count:{gattDescriptorsResult.Descriptors.Count} {gattDescriptorsResult.ProtocolError}");

                    //GATTディスクリプタを列挙
                    foreach (var descriptor in gattDescriptorsResult.Descriptors)
                    {
                        Console.WriteLine($"\t\t\t0x{descriptor.Uuid.ToShortId()} {descriptor.Name()} {descriptor.ProtectionLevel},{descriptor.AttributeHandle}");
                        var gattReadResult = await descriptor.ReadValueAsync();
                        if (gattReadResult.Status == GattCommunicationStatus.Success)
                        {
                            var data = gattReadResult.Value.ToArray();
                            string text = System.Text.Encoding.UTF8.GetString(data);
                            Console.WriteLine($"\t\t\t\t{gattReadResult.Status},value {BitConverter.ToString(data)} >> {text.Replace('\0', ' ')} {gattReadResult.ProtocolError}");
                        }
                        else
                        {
                            Console.WriteLine($"\t\t\t\t{gattReadResult.Status} {gattReadResult.ProtocolError}");
                        }
                    }

                    //GATTキャラクタリスティックがRead可能なら、値を取得
                    if (character.CharacteristicProperties.HasFlag(GattCharacteristicProperties.Read))
                    {
                        var result = await character.ReadValueAsync();
                        if (result.Status == GattCommunicationStatus.Success)
                        {
                            var data = result.Value.ToArray();
                            string text = System.Text.Encoding.UTF8.GetString(data);
                            Console.WriteLine("\t\tReadCurrentValue:" + BitConverter.ToString(data) + " >> " + text.Replace('\0', ' '));
                        }
                    }
                }
            }
        }
    }
    public static class GuidExtention
    {
        public static string ToShortId(this Guid guid)
        {
            return BluetoothUuidHelper.TryGetShortId(guid)?.ToString("X") ?? guid.ToString();
        }
    }
}