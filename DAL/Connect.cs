using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using DTO;
using System.Diagnostics.Eventing.Reader;

namespace DAL
{
    public class Connect
    {
        private static Connect instance;
        string sql = "Data Source=KIKOKEKA\\SQLEXPRESS;Initial Catalog=DoAn1;Integrated Security=True";
        public static Connect Instance
        {
            get { if (instance == null) instance = new Connect(); return Connect.instance; }
            private set => Connect.instance = value;
        }
        public DataTable taobang(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection cnn = new SqlConnection(sql))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    SqlDataAdapter ds = new SqlDataAdapter(cmd);
                    ds.Fill(dt);
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                dt.TableName = ex.Message.ToString();
            }
            return dt;
        }
        public int excutenonquery(string query, out string error, params SqlParameter[] parameters)
        {
            int data = 0;
            try
            {
                using (SqlConnection cnn = new SqlConnection(sql))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    data = cmd.ExecuteNonQuery();
                    cnn.Close();
                    error = null;
                }
            }
            catch(Exception ex)
            {
                error = ex.Message.ToString();
                return -10;
            }
            return data;
        }
        public object excutescalar(string query,out string error, params SqlParameter[] parameters)
        {
            object data = -1;
            try
            {
                using (SqlConnection cnn = new SqlConnection(sql))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    data = cmd.ExecuteScalar();
                    cnn.Close();
                    error = null;
                }
            }
            catch (Exception ex)
            {
                error=ex.Message.ToString();
                return error;
            }
            return data;
        }
        public List<string> excuteReader(string query,out string error, params SqlParameter[] parameters)
        {
            List<string> data = new List<string>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(sql))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    foreach (SqlParameter p in parameters)
                    {
                        cmd.Parameters.Add(p);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string dt = reader.GetString(0);
                                data.Add(dt);
                            }
                        }
                    }
                    cnn.Close();
                    error = null;
                }
            }
            catch(Exception ex)
            {
                error=ex.Message.ToString();
                return null;
            }
            return data;
        }
        
    }
}
