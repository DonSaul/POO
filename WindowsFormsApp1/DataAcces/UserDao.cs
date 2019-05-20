using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;


namespace DataAcces
{
   public class UserDao : Csql
    {
        public bool Login(string user, string pass)
        {

            using (var con = GetConnection())
            {
                con.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = con;
                    command.CommandText = "Select *from Users where Lname= @user and Password= @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {

                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.Fname = reader.GetString(3);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
