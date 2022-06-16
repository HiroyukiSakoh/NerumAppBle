using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Text;

namespace BleExample.Utils
{
    internal static class BluetoothCompanyIdentifiers
    {
        static Dictionary<ushort, CompanyIdentfier> CompanyDict = LoadDict();

        private static Dictionary<ushort, CompanyIdentfier> LoadDict()
        {
            var dict = new Dictionary<ushort, string>();

            using var reader = new StreamReader(".\\Utils\\CompanyIdentfiers.csv", Encoding.UTF8);
            using var csv = new CsvReader(reader,new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true});
            return csv.GetRecords<CompanyIdentfier>().ToDictionary(i=>i.Decimal);
        }

        public static string GetCompanyName(ushort companyId)
        {
            return CompanyDict.ContainsKey(companyId) ? CompanyDict[companyId].Company : $"不明:{companyId:X4}";
        }
        public class CompanyIdentfier
        {
            [Index(0)]
            public ushort Decimal { get; set; }
            [Index(1)]
            public string Hexadecimal { get; set; } = null!;
            [Index(2)]
            public string Company { get; set; } = null!;
        }
    }
}
