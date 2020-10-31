using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace KMC_Pallet_Info
{
    public class Data
    {
        public static List<Pallet> GetPalletInfo(List<string> palletID)
        {

            using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConnStr"].ConnectionString))
            {
                var res = conn.Query<Pallet>(@"  select CAST ( [PalletPackOnDate] as date) as [Date], [fldTransactionID] as [SerialNo], p.fldPalletID as PalletID
  FROM[Pallet] P inner join[PalletDetails] D on p.fldPalletID = d.fldPalletID
  where p.fldPalletID in @palletID", new { palletID });
                return res.ToList();
            }

        }
    }
}
