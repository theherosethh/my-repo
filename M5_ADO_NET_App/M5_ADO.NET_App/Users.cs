using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace M5_ADO.NET_App
{
    public class Users
    {
        
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        string cs = "Server=DESKTOP-JA85VTV;Database=STEP_DB;User Id=sa;Password=123";
        string id, user, pwd, role;
        //Check connection Establish
        /*
        public void ConnectSQL()
        {
            cn = new SqlConnection(cs);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open) 
            {
                Console.WriteLine("Connected");
            }
            cn.Close();
        }
        */
        public void ViewUser()
        {
            cn = new SqlConnection(cs);
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM users", cn);
            cn = cmd.Connection;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Console.WriteLine("User ID \t\t Username \t\t Password \t\t Role");
                while (dr.Read()) 
                {
                    Console.WriteLine("{0}{1}{2}{3}", dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3));
                }

            }
        }
        public void AddUser()
        {
            Console.Write("Input your user Id: ");
            id = Console.ReadLine();
            Console.Write("Input your user User Name: ");
            user = Console.ReadLine();
            Console.Write("Input your user User Password: ");
            pwd = Console.ReadLine();
            Console.Write("Input your user role: ");
            role = Console.ReadLine();


            cn = new SqlConnection(cs);
            cn.Open();
            cmd = new SqlCommand("INSERT INTO users VALUES(@id @user, @pwd, @role)", cn);
            cmd.Parameters.Add("@id", System.Data.SqlDbType.NChar, 10).Value = id;
            cmd.Parameters.Add("@user", System.Data.SqlDbType.NChar, 10).Value = user;
            cmd.Parameters.Add("@pwd", System.Data.SqlDbType.NChar, 10).Value = pwd;
            cmd.Parameters.Add("@role", System.Data.SqlDbType.NChar, 10).Value = role;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Insert was successful");
        }
        public void EditUser()
        {

        }
    }
}
