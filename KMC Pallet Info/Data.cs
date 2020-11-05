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
                var res = conn.Query<Pallet>(@"  SELECT P.fldPalletID as PalletID, D.fldTransactionID as SerialNo, R.fldProductEANBarcode as EAN, r.fldProductCode as Code, R.fldProductDescription as [Description],  [fldTransactionDateTime]  as [Date] , fldTransactionNetWeight as [Weight]
                                                FROM Pallet P inner join PalletDetails D on p.fldPalletID = d.fldPalletID
                                                inner join [TRANSACTION] T on D.fldTransactionID = T.fldTransactionID
                                                inner join PRODUCT R on R.fldProductCode = T.fldProductCode
                                                WHERE p.fldPalletID IN @palletID", new { palletID });
                return res.ToList();
            }

        }
    }
}
