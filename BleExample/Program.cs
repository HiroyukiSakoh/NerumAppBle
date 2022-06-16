using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BleExample
{
    public class Program
    {
        public static async Task Main()
        {
            //new アドバタイズ受信サンプル().サンプル();
            ulong bluetoothAddress = 0x30E283FFFFFF;
            await new サービスとキャラクタリスティックの列挙サンプル().サンプルAsync(bluetoothAddress);
        }
    }
}
