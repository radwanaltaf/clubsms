using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clubs_Management_System
{
    class Controller
    {
        SqlConnection conn;
        User usr = new User();


        // A method which initiates an SQL Connection. If the connection is closed, it opens it. 
        public void Connect()
        {
             conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\ClubsMS.mdf';Integrated Security=True;Connect Timeout=30");

            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // A method which will verify if the user trying to log in exits in the database & allow log in if the reord exists. 
        public bool Login(User usr)
        {
            string Em = usr.emailProp;
            string Ps = usr.passwordProp;
            bool Succes = false;

            Connect();
            
            string loginQuerySql = "SELECT * FROM Users WHERE Email=@useremail AND UserPassword=@userpassword"; // Using parameters in Query for security purposes. 

            SqlCommand cmd = new SqlCommand(loginQuerySql, conn);
            
            cmd.Parameters.AddWithValue("@useremail", Em); // Giving the Paramter a value. 
            cmd.Parameters.AddWithValue("@userpassword", Ps); // Giving the Paramter a value. 

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                dr.Read();
                Succes = true;
            }

            dr.Close();
            conn.Close();
            return Succes;
        }

    }
}
