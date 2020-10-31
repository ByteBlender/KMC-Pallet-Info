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
        public DateTime Date { get; set; }
     
       
    }
}
