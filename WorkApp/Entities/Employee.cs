using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Text;

namespace WorkApp.Model
{
    [Table("Login")]
    public class Employee
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        static string myconn = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
        public DataTable Select()
        {
            SQLiteConnection conn = new SQLiteConnection(myconn);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Login";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert(Employee b)
        {
            bool isSuccess = false;

            SQLiteConnection conn = new SQLiteConnection(myconn);
            try
            {
                string sql = "INSERT INTO Login('UserName','Password')VALUES(@UserName,@Password)";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", b.UserName);
                cmd.Parameters.AddWithValue("@Password", b.Password);

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
        public bool Update(Employee b)
        {
            bool isSuccess = false;
            SQLiteConnection conn = new SQLiteConnection(myconn);
            try
            {
                string sql = "UPDATE Login Set 'Username'=@Username, 'Password'=@Password WHERE Id=@Id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", b.Id);
                cmd.Parameters.AddWithValue("@UserName", b.UserName);
                cmd.Parameters.AddWithValue("@Password", b.Password);

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
        public bool Delete(Employee b)
        {
            bool isSuccess = false;

            SQLiteConnection conn = new SQLiteConnection(myconn);
            try
            {
                string sql = "DELETE FROM Login WHERE Id=@Id";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);

                cmd.Parameters.AddWithValue("Id", b.Id);

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
