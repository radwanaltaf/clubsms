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


        // A method which will verify if the user trying to log in exists in the database & allow log in if the reord exists. 
        public bool Login(User usr)
        {
            string EmailParam = usr.emailProp;
            string PasswordParam = usr.passwordProp;
            string RoleParam = usr.roleProp;
            bool Succes = false;
            Connect();

            // Using parameters in Query for security purposes. 
            string loginQuerySql = "SELECT * FROM Users WHERE Email=@useremail AND UserPassword=@userpassword AND Role=@role"; 
            SqlCommand cmd = new SqlCommand(loginQuerySql, conn);
         
            cmd.Parameters.AddWithValue("@useremail", EmailParam); // Giving the Paramter a value. 
            cmd.Parameters.AddWithValue("@userpassword", PasswordParam);
            cmd.Parameters.AddWithValue("@role", RoleParam);

            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr.GetValue(5).ToString().ToLower() == "admin")
                    {
                        role.UserRole = "admin";
                    }
                    else if (dr.GetValue(5).ToString().ToLower() == "club secretary")
                    {
                        role.UserRole = "secretary";
                    }
                    else
                    {
                        role.UserRole = "student";
                    }
                    User.firstNameProp = dr.GetValue(3).ToString();
                }
                Succes = true;
            }

            dr.Close();
            conn.Close();
            return Succes;
        }

        //A method which will Hide & Show the menu items for the Admin
        public void DisplayMenuAdmin(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity)
        {
                updateClubDescItem.Visible = false;
                updateClubActivity.Visible = false;
                searchItem.Visible = true;
                registerItem.Visible = true;
                deregisterItem.Visible = true;
                updateClubItem.Visible = true;
                clubReportItem.Visible = true;
                activityReportItem.Visible = true;
        }

        //A method which will Hide & Show the menu items for the Secretary
        public void DisplayMenuSecretary(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity)
        {
            updateClubDescItem.Visible = true;
            updateClubActivity.Visible = true;
            searchItem.Visible = false;
            registerItem.Visible = false;
            deregisterItem.Visible = false;
            updateClubItem.Visible = false;
            clubReportItem.Visible = false;
            activityReportItem.Visible = false;
        }

        //A method which will Hide & Show the menu items for the student
        public void DisplayMenuStudent(ToolStripMenuItem searchItem, ToolStripMenuItem registerItem, ToolStripMenuItem deregisterItem, ToolStripMenuItem updateClubItem, ToolStripMenuItem clubReportItem, ToolStripMenuItem activityReportItem, ToolStripMenuItem updateClubDescItem, ToolStripMenuItem updateClubActivity)
        {
            updateClubDescItem.Visible = false;
            updateClubActivity.Visible = false;
            searchItem.Visible = true;
            registerItem.Visible = false;
            deregisterItem.Visible = false;
            updateClubItem.Visible = false;
            clubReportItem.Visible = false;
            activityReportItem.Visible = false;
        }

    }
}
