using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using test1.Data;
using MySql.Data.MySqlClient;

namespace test1.analitix
{
    public class analitixForStock
    {
        public static void getDataCompany(string shortNameCompany, string startDate, string endDate)
        {
            using (var conn = DatabaseConnect.GetDBConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmdSel = new MySqlCommand($"SELECT hg.date,hg.id,hg.company_shortName,hg.close_quotes FROM(SELECT c.Id,q.date,c.company_shortName,q.close_quotes FROM company c INNER JOIN quotes q on c.Id=q.companyId where company_shortName={shortNameCompany}) hg WHERE date BETWEEN {startDate} and {endDate};", conn))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                        DataSet dataSet = new DataSet();
                        da.Fill(dataSet);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
            }
        }

    }
}