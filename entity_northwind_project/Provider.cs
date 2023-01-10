using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_northwind_project
{
    class Provider
    {

        public static DataTable GetQueryDataTable(string SQL)
        {
            SqlConnection DB = Provider.DBConnection();
            if (DB.State != ConnectionState.Open)
            {
                DB.Open();
            }
            DataTable Table = new DataTable("CustomTable");
            new SqlDataAdapter
            {
                SelectCommand = new SqlCommand
                { CommandText = SQL, Connection = DB, CommandTimeout = 0, CommandType = CommandType.Text }
            }.Fill(Table);
            DB.Close();
            DB.Dispose();  // değişkeni öldürmek yok etmek.. SQL ram de yer tutmasın diye..
            return Table;

        }
        private static SqlConnection DBConnection()
        {
            SqlConnection Conn = new SqlConnection { ConnectionString = @"Data source = localhost; initial Catalog= NorthwindTR_DB; Connection Timeout = 0; Integrated Security=true" };
            Conn.Open();
            return Conn;

        }

        public static string ExecuteNonQuery(string SQL)

        {
            SqlConnection DB = Provider.DBConnection();
            if (DB.State != ConnectionState.Open)
            {
                DB.Open();
            }
            string S = new SqlCommand
            {
                CommandText = SQL,
                Connection = DB,
                CommandTimeout = 0

            }.ExecuteNonQuery().ToString();
            DB.Close();
            DB.Dispose();
            return S;
        }

    }
}
