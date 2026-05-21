using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace asek
{
    public class Koneksi
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataTable data;
        public Koneksi()
        {
            con = new SqlConnection("server=SEHATSEHATKI\\SQLEXPRESS;database=db_mks;integrated security=true;");
        }
        public void setQuery(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public bool execQuery()
        {
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable execTable()
        {
            try
            {
                data = null;
                adapter = new SqlDataAdapter(cmd);
                data = new DataTable();
                adapter.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public void parmString(string at, string val)
        {
            SqlParameter i = cmd.Parameters.AddWithValue(at, val);
            i.SqlDbType = SqlDbType.VarChar;
        }
        public void parmInt(string at, int val)
        {
            SqlParameter i = cmd.Parameters.AddWithValue(at, val);
            i.SqlDbType = SqlDbType.Int;
        }
        public void parmBigint(string at, long val)
        {
            SqlParameter i = cmd.Parameters.AddWithValue(at, val);
            i.SqlDbType = SqlDbType.BigInt;
        }
        public void parmDate(string at, DateTime val)
        {
            SqlParameter i = cmd.Parameters.AddWithValue(at, val);
            i.SqlDbType = SqlDbType.Date;
        }
        public void parmTimestamp(string at, DateTime val)
        {
            SqlParameter i = cmd.Parameters.AddWithValue(at, val);
            i.SqlDbType = SqlDbType.Timestamp;
        }
    }
}
