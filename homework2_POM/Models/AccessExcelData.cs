using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_POM.Models
{
    public class AccessExcelData                                             
    {
        public static string DataExcelConnection()
        {
            var pathToDirectory = Environment.CurrentDirectory + ConfigurationManager.AppSettings["ExcelSheetName"];
            //var pathToDirectory = AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["ExcelSheetName"];     // Втори начин за достъп до ексел мапа от App.config, трябва да се направи промана и в него
            var fileName = "ExcelMap.xlsx";
            var connection = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0; HDR = YES; IMEX = 1;';", pathToDirectory + fileName);
            return connection;
        }
        public static RegistrationUserExcel GetData(string keyName)
        {
            using (var connection = new OleDbConnection(DataExcelConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [RegistrationFormSheet$] where key='{0}'", keyName);
                var value = connection.Query<RegistrationUserExcel>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
