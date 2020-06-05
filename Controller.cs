using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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

            //Check if a record matches & store the user role of that record in a static property
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

        public int RegisterClub(string clubsname, string presidentsname, string vicepresidentsname, string secretarysname, string description, DateTime registerdate)
        {
            int status = 0;
            string registerSQLQuery = "INSERT INTO Clubs VALUES(@_clubsname, @_presidentsname, @_vicepresidentsname, @_secretarysname, @_clubsdescription, @_registerdate)";
            Connect();
            SqlCommand cmd = new SqlCommand(registerSQLQuery, conn);
            cmd.Parameters.AddWithValue("@_clubsname", clubsname);
            cmd.Parameters.AddWithValue("@_presidentsname", presidentsname);
            cmd.Parameters.AddWithValue("@_vicepresidentsname", vicepresidentsname);
            cmd.Parameters.AddWithValue("@_secretarysname", secretarysname);
            cmd.Parameters.AddWithValue("@_clubsdescription", description);
            cmd.Parameters.AddWithValue("@_registerdate", registerdate);

            status = cmd.ExecuteNonQuery();

            return status;
        }

        public List<String> DisplayAllClubs()
        {
            List<string> ClubsList = new List<string>();
            SqlDataAdapter da;
            Connect();
            string retreiveAllClubNames = "SELECT Club_Name FROM Clubs";

            da = new SqlDataAdapter(retreiveAllClubNames, conn);
            DataTable clubsnamedatatable = new DataTable();
            da.Fill(clubsnamedatatable);

            foreach(DataRow row in clubsnamedatatable.Rows)
            {
                ClubsList.Add( row["Club_Name"].ToString());
            }

            return ClubsList;            
        }

        public int UpdateClub(string clubname, string pname, string vpname, string secname, string clubdesc, string selectedclubname)
        {
            int status = 0;
            Connect();

            string updateQuerySql = "UPDATE Clubs SET Club_Name=@_clubname, President_Name=@_pname, VicePresident_Name=@_vpname, Secretary_Name=@_secname, Clubs_Description=@_clubsdesc WHERE Club_Name=@_selectedclubname";

            SqlCommand cmd = new SqlCommand(updateQuerySql, conn);
            cmd.Parameters.AddWithValue("@_clubname", clubname);
            cmd.Parameters.AddWithValue("@_pname", pname);
            cmd.Parameters.AddWithValue("@_vpname", vpname);
            cmd.Parameters.AddWithValue("@_secname", secname);
            cmd.Parameters.AddWithValue("@_clubsdesc", clubdesc);
            cmd.Parameters.AddWithValue("@_selectedclubname", selectedclubname);

            status = cmd.ExecuteNonQuery();

            return status;
        }

        public int DeRegisterClub(string clubname, DateTime deregdate)
        {
            int status = 0;
            Connect();

            string trasnfertableQuerySql = "INSERT INTO DeactiveClubs (Club_Name, President_Name, VicePresident_Name, Secretary_Name, Clubs_Description, Register_Date) SELECT Club_Name, President_Name, VicePresident_Name, Secretary_Name, Clubs_Description, Register_Date FROM Clubs WHERE Club_Name=@_clubname";
            SqlCommand cmd = new SqlCommand(trasnfertableQuerySql, conn);
            cmd.Parameters.AddWithValue("@_clubname", clubname);
            status = cmd.ExecuteNonQuery();

            string addDeRegDateQuerySql = "UPDATE DeactiveClubs SET Deregister_Date=@_deregdate WHERE Club_Name=@_selectedclubname";
            cmd.Parameters.AddWithValue("@_deregdate", deregdate);
            cmd.Parameters.AddWithValue("@_selectedclubname", clubname);
            cmd.CommandText = addDeRegDateQuerySql;            
            cmd.ExecuteNonQuery();

            if(status > 0)
            {
                string deleteDeregClub = "DELETE FROM Clubs WHERE Club_Name=@_delclubname";
                cmd.Parameters.AddWithValue("@_delclubname", clubname);
                cmd.CommandText = deleteDeregClub;
                cmd.ExecuteNonQuery();
            }

            return status;
        }

        public void SearchClub(string clubname)
        {
            SqlDataReader dr;
            //SqlDataAdapter da;
            //DataTable allclubsinfo;
            Connect();
            string readAllClubInfoQuerySql = "SELECT * FROM Clubs WHERE Club_Name=@clubname";

            SqlCommand cmd = new SqlCommand(readAllClubInfoQuerySql, conn);
            cmd.Parameters.AddWithValue("@clubname", clubname);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                ClubsInfo.ClubName = dr.GetValue(1).ToString();
                ClubsInfo.PName = dr.GetValue(2).ToString();
                ClubsInfo.VPName = dr.GetValue(3).ToString();
                ClubsInfo.SecName = dr.GetValue(4).ToString();
                ClubsInfo.ClubDesc = dr.GetValue(5).ToString();
            }

            //allclubsinfo = new DataTable();
            //da = new SqlDataAdapter(readAllClubInfoQuerySql, conn);
            //da.Fill(allclubsinfo);

            
        }
    }
}
