using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;

namespace NerumAppBle
{
    public class NerumAppDevice : IAsyncDisposable
    {
        private readonly BluetoothLEDevice bleDevice = null!;

        private GattCharacteristic ReadGattCharacteristic = null!;
        private GattCharacteristic WriteGattCharacteristic = null!;
        public string DeviceName { get; private set; } = null!;

        private readonly Guid ReadServiceUuid = new("0000ffe0-0000-1000-8000-00805f9b34fb");
        private readonly Guid WriteServiceUuid = new("0000ffe5-0000-1000-8000-00805f9b34fb");
        private readonly Guid ReadCharacteristicsUuid = new("0000ffe4-0000-1000-8000-00805f9b34fb");
        private readonly Guid WriteCharacteristicsUuid = new("0000ffe9-0000-1000-8000-00805f9b34fb");

        public NerumAppDevice(BluetoothLEDevice bleDevice)
        {
            this.bleDevice = bleDevice;
        }

        public async Task InitializeAsync()
        {
            DeviceName = bleDevice.Name;

            var readGattDeviceServicesResult = await bleDevice.GetGattServicesForUuidAsync(ReadServiceUuid);
            if (readGattDeviceServicesResult.Status != GattCommunicationStatus.Success)
            {
                WriteDebug($"Service:{ReadServiceUuid}が見つかりませんでした");
                throw new InvalidOperationException($"Service:{ReadServiceUuid}が見つかりませんでした");
            }
            WriteDebug($"Service:{ReadServiceUuid}が見つかりました");

            var readGattCharacteristicsResult = await readGattDeviceServicesResult.Services[0].GetCharacteristicsForUuidAsync(ReadCharacteristicsUuid);
            if (readGattCharacteristicsResult.Status != GattCommunicationStatus.Success)
            {
                WriteDebug($"Characteristics:{ReadCharacteristicsUuid}が見つかりませんでした");
                throw new InvalidOperationException($"Characteristics:{ReadCharacteristicsUuid}が見つかりませんでした");
            }
            WriteDebug($"Characteristics:{ReadCharacteristicsUuid}が見つかりました");
            ReadGattCharacteristic = readGattCharacteristicsResult.Characteristics[0];
            if (!ReadGattCharacteristic.CharacteristicProperties.HasFlag(GattCharacteristicProperties.Notify))
            {
                WriteDebug($"Characteristics:{ReadCharacteristicsUuid}がNotifyではありません");
                throw new InvalidOperationException($"Characteristics:{ReadCharacteristicsUuid}がNotifyではありません");
            }
            ReadGattCharacteristic.ValueChanged += ReadGattCharacteristic_ValueChanged;

            var gattWriteResult = await ReadGattCharacteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync(GattClientCharacteristicConfigurationDescriptorValue.Notify);
            if (gattWriteResult.Status == GattCommunicationStatus.Success)
            {
                WriteDebug($"WriteClientCharacteristicConfigurationDescriptorWithResultAsync None 設定成功 {gattWriteResult.Status},{gattWriteResult.ProtocolError}");
            }
            else
            {
                WriteDebug($"WriteClientCharacteristicConfigurationDescriptorWithResultAsync None 設定失敗 {gattWriteResult.Status},{gattWriteResult.ProtocolError}");
            }

            var writeGattDeviceServicesResult = await bleDevice.GetGattServicesForUuidAsync(WriteServiceUuid);
            if (writeGattDeviceServicesResult.Status != GattCommunicationStatus.Success)
            {
                WriteDebug($"Service:{WriteServiceUuid}が見つかりませんでした");
                throw new InvalidOperationException($"Service:{WriteServiceUuid}が見つかりませんでした");
            }
            WriteDebug($"Service:{WriteServiceUuid}が見つかりました");

            var writeGattCharacteristicsResult = await writeGattDeviceServicesResult.Services[0].GetCharacteristicsForUuidAsync(WriteCharacteristicsUuid);
            if (writeGattCharacteristicsResult.Status != GattCommunicationStatus.Success)
            {
                WriteDebug($"Characteristics:{WriteCharacteristicsUuid}が見つかりませんでした");
                throw new InvalidOperationException($"Characteristics:{WriteCharacteristicsUuid}が見つかりませんでした");
            }
            WriteGattCharacteristic = writeGattCharacteristicsResult.Characteristics[0];
            WriteDebug($"Characteristics:{WriteCharacteristicsUuid}が見つかりました");
        }

        private byte[]? previousReadGattCharacteristicValue;
        private void ReadGattCharacteristic_ValueChanged(GattCharacteristic sender, GattValueChangedEventArgs args)
        {
            var currentValue = args.CharacteristicValue.ToArray();
            {
                if (currentValue.Length > 20)
                {
                    ParseReceivedData(currentValue);
                    return;
                }
                if (currentValue.Length > 3)
                {
                    if (currentValue[0] == 0xF4 && currentValue[1] == 0xFE && currentValue[2] == 0x16)
                    {
                        previousReadGattCharacteristicValue = currentValue;
                        return;
                    }
                    if (currentValue.Length == 10 || currentValue.Length == 16)
                    {
                        ParseReceivedData(currentValue);
                        return;
                    }
                    if (previousReadGattCharacteristicValue != null)
                    {
                        ParseReceivedData(previousReadGattCharacteristicValue.Concat(currentValue).ToArray());
                        previousReadGattCharacteristicValue = null;
                        return;
                    }
                    //20バイト以下3バイト超で、10バイト,16バイト以外 かつ previousが無い場合、破棄
                    WriteDebug($"Drop! {BitConverter.ToString(currentValue)}");
                    return;
                }
                if (previousReadGattCharacteristicValue != null)
                {
                    ParseReceivedData(previousReadGattCharacteristicValue.Concat(currentValue).ToArray());
                    previousReadGattCharacteristicValue = null;
                    return;
                }
                //破棄(来るケースはないはず)
                WriteDebug($"Drop!! {BitConverter.ToString(currentValue)}");
            }
        }


        private void ParseReceivedData(byte[] data)
        {
            try
            {

                if (data.Length > 3 && data[0] == 0xED && data[1] == 0x80)
                {
                    var checkSum = CalculateCheckSum(data[..^1]);
                    if (checkSum != data[^1])
                    {
                        WriteDebug($"{BitConverter.ToString(data)}⇒Break CheckSum {checkSum:X2}");
                    }
                    var response = new NotifyAlarmStatus()
                    {
                        Time1 = new TimeOnly(data[3], data[4]),
                        Repeat1 = (AlarmRepeat)data[5],
                        Type1 = (AlarmType)data[6],
                        Time2 = new TimeOnly(data[7], data[8]),
                        Repeat2 = (AlarmRepeat)data[9],
                        Type2 = (AlarmType)data[10],
                        Time3 = new TimeOnly(data[11], data[12]),
                        Repeat3 = (AlarmRepeat)data[13],
                        Type3 = (AlarmType)data[14]
                    };
                    WriteDebug($"{BitConverter.ToString(data)}⇒{response}");
                    OnNotifyAlarmStatus?.Invoke(this, response);
                }
                else if (data.Length > 3 && data[0] == 0xE7 && data[1] == 0x80)
                {
                    var checkSum = CalculateCheckSum(data[..^1]);
                    if (checkSum != data[^1])
                    {
                        WriteDebug($"{BitConverter.ToString(data)}⇒Break CheckSum {checkSum:X2}");
                    }

                    var response = new NotifyDateTime()
                    {
                        DateTime = new DateTime(data[3] + 1900, (data[4] & 0x0F) + 1, data[5], data[6], data[7], data[8]),
                    };
                    WriteDebug($"{BitConverter.ToString(data)}⇒{response}");
                    OnNotifyDateTime?.Invoke(this, response);
                }
                else
                {
                    var checkSum = CalculateCheckSum(data[..^1]);
                    if (checkSum != data[^1])
                    {
                        WriteDebug($"{BitConverter.ToString(data)}⇒Break CheckSum {checkSum:X2}");
                    }
                    if (data.Length > 18)//大抵 23 byte
                    {
                        var notify = new NotifyBedStatus()
                        {
                            HeadDegree = BitConverter.ToUInt16(data.AsSpan(3, 2)),
                            FootDegree = BitConverter.ToUInt16(data.AsSpan(5, 2)),
                            IsLightOn = data[18] == 0x40,
                        };
                        WriteDebug($"{BitConverter.ToString(data)}⇒{notify}");
                        OnNotifyBedStatus?.Invoke(this, notify);
                    }
                    else
                    {
                        WriteDebug($"{BitConverter.ToString(data)}⇒Invalid Length {data.Length}");
                    }
                }
            }
            catch (Exception ex)
            {
                WriteDebug($"{BitConverter.ToString(data)}⇒Exception {ex.Message}");
            }
        }

        private static byte CalculateCheckSum(byte[] data)
        {

            int temp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                temp += data[i];
            }
            return (byte)(~(byte)(temp & 0xff));
        }

        public async ValueTask DisposeAsync()
        {
            if (ReadGattCharacteristic != null)
            {
                ReadGattCharacteristic.ValueChanged -= ReadGattCharacteristic_ValueChanged;

                var gattWriteResult = await ReadGattCharacteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync(GattClientCharacteristicConfigurationDescriptorValue.None);
                if (gattWriteResult.Status == GattCommunicationStatus.Success)
                {
                    WriteDebug($"WriteClientCharacteristicConfigurationDescriptorWithResultAsync None 設定成功 {gattWriteResult.Status},{gattWriteResult.ProtocolError}");
                }
                else
                {
                    WriteDebug($"WriteClientCharacteristicConfigurationDescriptorWithResultAsync None 設定失敗 {gattWriteResult.Status},{gattWriteResult.ProtocolError}");
                }
            }
            GC.SuppressFinalize(this);
        }

        public async Task SetNotifyAlarmStatusAsync()
        {
            //E28003009A
            await WriteCommandAsync(new byte[] { 0xE2, 0x80, 0x03, 0x00 });
        }

        public async Task SetNotifyBedStatusAsync()
        {
            //E6FE16030000000002
            await WriteCommandAsync(GetE6FE16Command(E6FE16.Query));
        }

        public async Task SetAlarmAsync(
            TimeOnly time1, AlarmRepeat alarmRepeat1, AlarmType alarmType1,
            TimeOnly time2, AlarmRepeat alarmRepeat2, AlarmType alarmType2,
            TimeOnly time3, AlarmRepeat alarmRepeat3, AlarmType alarmType3)
        {
            //例
            //ed80030700ff13000000000000000076
            //3byte ed8003 magic
            //1byte 07 hour
            //1byte 00 min
            //1byte ff repeat be=平日,ff=全部,c0=土曜日,00=empty(1bit目=on/off)
            //1byte 13 type 00=なし,11=M1,13=M2,12=灯り(1bit目=on/off?)
            //1byte 07 hour
            //1byte 00 min
            //1byte ff repeat be=平日,ff=全部,c0=土曜日,00=empty(1bit目=on/off)
            //1byte 13 type 00=なし,11=M1,13=M2,12=灯り(1bit目=on/off?)
            //1byte 07 hour
            //1byte 00 min
            //1byte ff repeat be=平日,ff=全部,c0=土曜日,00=empty(1bit目=on/off)
            //1byte 13 type 00=なし,11=M1,13=M2,12=灯り(1bit目=on/off?)
            await WriteCommandAsync(new byte[] {
                0xED, 0x80, 0x03
                , (byte)time1.Hour
                , (byte)time1.Minute
                ,(byte)alarmRepeat1
                ,(byte)alarmType1
                , (byte)time2.Hour
                , (byte)time2.Minute
                ,(byte)alarmRepeat2
                ,(byte)alarmType2
                , (byte)time3.Hour
                , (byte)time3.Minute
                ,(byte)alarmRepeat3
                ,(byte)alarmType3});
            await SetDateTimeAsync(DateTime.Now);
        }

        public async Task SetDateTimeAsync(DateTime dateTime)
        {
            await WriteCommandAsync(new byte[] {
                0xE7, 0x80, 0x01
                , (byte)(dateTime.Year - 1900)
                ,(byte)(dateTime.Month - 1)
                ,(byte)dateTime.Day
                ,(byte)dateTime.Hour
                ,(byte)dateTime.Minute
                ,(byte)dateTime.Second});
        }

        [Flags]
        public enum AlarmRepeat
        {
            なし = 0x00,
            日曜日 = 0x01,
            月曜日 = 0x02,
            火曜日 = 0x04,
            水曜日 = 0x08,
            木曜日 = 0x10,
            金曜日 = 0x20,
            土曜日 = 0x40,
            あり = 0x80,
        }

        public enum AlarmType : byte
        {
            なし = 0x00,
            M1 = 0x11,
            M2 = 0x13,
            灯り = 0x12,
        }

        public async Task ToggleLightAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.ToggleLight));
        }

        public async Task HeadUpAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.HeadUp));
        }

        public async Task HeadDownAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.HeadDown));
        }

        public async Task FootUpAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.FootUp));
        }

        public async Task FootDownAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.FootDown));
        }

        public async Task StopAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.AllNone));
        }
        public async Task QueryAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.AllNone));
        }
        public async Task UnionUpAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.UnionUp));
        }
        public async Task UnionDownAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.UnionDown));
        }

        public async Task ToFlatAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeFlat));
        }

        public async Task ToAntiSnoreAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeAntiSnore));
        }

        public async Task ToLoungeAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeLounge));
        }

        public async Task ToZeroGAsync()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeZeroG));
        }

        public async Task ToMemory1Async()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeMemory1));
        }

        public async Task ToMemory2Async()
        {
            await WriteCommandAsync(GetE6FE16Command(E6FE16.MemoryTypeMemory2));
        }

        private static byte[] GetE6FE16Command(E6FE16 command)
        {
            var values = BitConverter.GetBytes((ulong)command);
            return new byte[]
            {
                0xE6, 0xFE, 0x16
                ,values[4],values[3], values[2], values[1], values[0]
            };
        }

        /// <summary>
        /// E6FE16で始まるコマンド類
        /// マジックワードを除いて5バイト
        /// ulongで下位5バイトのみをコマンドとして使う
        /// </summary>
        private enum E6FE16 : ulong
        {
            HeadUp = 0x0100000000,
            HeadDown = 0x0200000000,
            FootUp = 0x0400000000,
            FootDown = 0x0800000000,

            //Head and Foot
            UnionUp = 0x0500000000,
            UnionDown = 0x0A00000000,

            AllNone = 0x0000000000,
            Query = 0x0300000000,

            MemoryTypeFlat = 0x0000000800,
            MemoryTypeAntiSnore = 0x0080000000,
            MemoryTypeLounge = 0x0020000000,
            MemoryTypeZeroG = 0x0010000000,
            MemoryTypeMemory1 = 0x0000010000,
            MemoryTypeMemory2 = 0x0000040000,
            ToggleLight = 0x0000020000,
        }

        private async Task WriteCommandAsync(byte[] command, [CallerMemberName] string callerMethodName = "")
        {
            var commandWithCheckSum = command.Concat(new byte[] { CalculateCheckSum(command) }).ToArray();
            var gattWriteResult = await WriteGattCharacteristic.WriteValueWithResultAsync(commandWithCheckSum.AsBuffer());
            if (gattWriteResult.Status == GattCommunicationStatus.Success)
            {
                WriteDebug($"Write:{callerMethodName} {BitConverter.ToString(commandWithCheckSum).Replace("-", "")} {gattWriteResult.Status}");
            }
            else
            {
                WriteDebug($"Write:{callerMethodName} {BitConverter.ToString(commandWithCheckSum).Replace("-", "")} {gattWriteResult.Status} {gattWriteResult.ProtocolError}");
            }
        }
        #region NotifyDateTime
        public event EventHandler<NotifyDateTime>? OnNotifyDateTime;
        public class NotifyDateTime
        {
            public DateTime DateTime { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append($"{nameof(DateTime)}={DateTime:yyyy/MM/dd HH:mm:ss}");
                return sb.ToString();
            }
        }
        #endregion

        #region NotifyBedStatus
        public event EventHandler<NotifyBedStatus>? OnNotifyBedStatus;
        public class NotifyBedStatus
        {
            public ushort HeadDegree { get; set; }
            public ushort FootDegree { get; set; }
            public bool IsLightOn { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append($"{nameof(HeadDegree)}={HeadDegree}");
                sb.Append($",{nameof(FootDegree)}={FootDegree}");
                sb.Append($",{nameof(IsLightOn)}={IsLightOn}");
                return sb.ToString();
            }
        }
        #endregion

        #region NotifyAlarmStatus
        public event EventHandler<NotifyAlarmStatus>? OnNotifyAlarmStatus;
        public class NotifyAlarmStatus
        {
            public TimeOnly Time1 { get; set; }
            public AlarmRepeat Repeat1 { get; set; }
            public AlarmType Type1 { get; set; }
            public TimeOnly Time2 { get; set; }
            public AlarmRepeat Repeat2 { get; set; }
            public AlarmType Type2 { get; set; }
            public TimeOnly Time3 { get; set; }
            public AlarmRepeat Repeat3 { get; set; }
            public AlarmType Type3 { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.Append($"{nameof(Time1)}={Time1:HH:mm}");
                sb.Append($",{nameof(Repeat1)}={Repeat1}");
                sb.Append($",{nameof(Type1)}={Type1}");
                sb.Append($"{nameof(Time2)}={Time2:HH:mm}");
                sb.Append($",{nameof(Repeat2)}={Repeat2}");
                sb.Append($",{nameof(Type2)}={Type2}");
                sb.Append($"{nameof(Time3)}={Time3:HH:mm}");
                sb.Append($",{nameof(Repeat3)}={Repeat3}");
                sb.Append($",{nameof(Type3)}={Type3}");
                return sb.ToString();
            }
        }
        #endregion

        #region DebugLog
        private void WriteDebug(string logText)
        {
            DebugLog?.Invoke(this, new LogItem() { Value = logText });
        }
        public event EventHandler<LogItem>? DebugLog;
        public class LogItem
        {
            public string Value { get; set; } = null!;
        }
        #endregion
    }
}