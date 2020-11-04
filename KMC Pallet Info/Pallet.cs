using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMC_Pallet_Info
{
    public class Pallet
    {
        public int PalletID { get; set; }
        public string SerialNo { get; set; }
        public string EAN { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public DateTime Date { get; set; }
        public string GTIN { get; set; }

        public Pallet()
        {
            GTIN = $"(01 9{EAN} 0 (3102) {Weight})";
        }

        public static string GenerateGTIN(string ean, double weight, DateTime date, string serialNo)
        {
            string weightString = (weight*100).ToString();

            while (weightString.Length <6)
            {
                weightString = $"0{weightString}";
            }

            return $"019{ean}{calcChecksum(ean)}3102{weightString}13{date.ToString("yyMMdd")}21{serialNo}";
        }

        private static string calcChecksum(string ean)
        {
            int sum = 27;   
            char[] eanArr = ean.ToCharArray();
            for (int i = 0; i < eanArr.Length; i++)
            {
                if(i%2 == 0)
                {
                    sum += int.Parse(eanArr[i].ToString());
                }
                else
                {
                    sum += int.Parse(eanArr[i].ToString())*3;
                }
            }

            return (10 - (sum % 10)).ToString();

        }

    }
}
