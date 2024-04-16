using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Text;
using System.Data.SQLite;

namespace WorkApp.Entities
{
    [Table("Work")]
    public class Work
    {

        public int WorkId { get; set; }
        public string Name { get; set; }
        public string WorkName { get; set; }
        public string Timer { get; set; }

        static string myconn = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
        public DataTable Select()
        {
            SQLiteConnection conn = new SQLiteConnection(myconn);
            DataTable dt2 = new DataTable();
            try
            {
                string sql = "SELECT * FROM Work";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt2);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt2;
        }
        public bool Insert(Work c)
        {
            bool isSuccess = false;

            SQLiteConnection conn = new SQLiteConnection (myconn);
            try
            {
                string sql = "INSERT INTO Work('Name','WorkName','Timer')VALUES(@Name,@WorkName,@Timer)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@WorkName", c.WorkName);
                cmd.Parameters.AddWithValue("@Timer", c.Timer);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Update(Work c)
        {
            bool isSuccess = false;
            SQLiteConnection conn = new SQLiteConnection(myconn);
            try
            {
                string sql = "UPDATE Work Set 'Name'=@Name, 'WorkName'=@WorkName,'Timer'=@Timer WHERE WorkId=@WorkId";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@WorkId", c.WorkId);
                cmd.Parameters.AddWithValue("@Name", c.Name);
                cmd.Parameters.AddWithValue("@WorkName", c.WorkName);
                cmd.Parameters.AddWithValue("@Timer", c.Timer);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete(Work c)
        {
            bool isSuccess = false;

            SQLiteConnection conn = new SQLiteConnection(myconn);
            try
            {
                string sql = "DELETE FROM Work WHERE WorkId=@WorkId";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@WorkId", c.WorkId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
