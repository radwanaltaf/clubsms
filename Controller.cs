using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
                        LoggedInUser.Username = dr.GetValue(3).ToString();
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

        public List<string> DisplayDeactiveClubs()
        {
            List<string> DeActiveClubsList = new List<string>();
            SqlDataAdapter da;
            Connect();
            string retrieveDeregclubnamesSqlQuery = "SELECT Club_Name FROM DeactiveClubs";

            da = new SqlDataAdapter(retrieveDeregclubnamesSqlQuery, conn);
            DataTable deactivedatatable = new DataTable();
            da.Fill(deactivedatatable);

            foreach (DataRow row in deactivedatatable.Rows)
            {
                DeActiveClubsList.Add(row["Club_Name"].ToString());
            }

            return DeActiveClubsList;
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
        }

        public bool CheckClubExists(string clubname)
        {
            SqlDataReader dr;
            bool exists = false;
            string checkClubExistsQuerySql = "SELECT * FROM Clubs WHERE Club_Name=@clubname";
            Connect();
            SqlCommand cmd = new SqlCommand(checkClubExistsQuerySql, conn);
            cmd.Parameters.AddWithValue("@clubname", clubname);
            dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                if(dr.GetValue(1).ToString() == clubname)
                {
                    exists = true;
                }
            }
            return exists;
        }

        public int UpdateClubsDesc(string secname, string newdesc)
        {
            int status = 0;
            Connect();
            string updateClubDescQuerySql = "UPDATE Clubs SET Clubs_Description=@_newdesc WHERE Secretary_Name=@_secname";
            SqlCommand cmd = new SqlCommand(updateClubDescQuerySql, conn);
            cmd.Parameters.AddWithValue("@_secname", secname);
            cmd.Parameters.AddWithValue("@_newdesc", newdesc);
            status = cmd.ExecuteNonQuery();

            return status;
        }

        public void LoggedInSecClub(string secname)
        {
            Connect();
            // Using parameters in Query for security purposes. 
            string getSecNameQuerySql = "SELECT * FROM Clubs WHERE Secretary_Name=@_secname";
            SqlCommand cmd = new SqlCommand(getSecNameQuerySql, conn);

            cmd.Parameters.AddWithValue("@_secname", secname); // Giving the Paramter a value.
            SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                                                            
                    LoggedInUser.ClubName = dr.GetValue(1).ToString();                                                                                                   
                }

            dr.Close();
            conn.Close();           
        }

        public int UpdateClubActivity(string loggedinclub, string activtyname, string achieversname, string activitydate, string desc)
        {
            int status = 0;
            Connect();
            string updateActivityQuerySql = "INSERT INTO ClubActivities VALUES(@_activityname, @_achieversname, @_activitydate, @_loggedinclubname, @_activDesc)";
            SqlCommand cmd = new SqlCommand(updateActivityQuerySql, conn);
            cmd.Parameters.AddWithValue("@_loggedinclubname", loggedinclub);
            cmd.Parameters.AddWithValue("@_activityname", activtyname);
            cmd.Parameters.AddWithValue("@_achieversname", achieversname);
            cmd.Parameters.AddWithValue("@_activitydate", activitydate);
            cmd.Parameters.AddWithValue("@_activDesc", desc);

            status = cmd.ExecuteNonQuery();

            return status;
        }


        public bool CheckActivityExists(string clubname, string activityname)
        {
            SqlDataReader dr;
            bool ActExists = false;
            string checkClubActExistsQuerySql = "SELECT * FROM ClubActivities WHERE Club_Name=@_clubname";
            Connect();
            SqlCommand cmd = new SqlCommand(checkClubActExistsQuerySql, conn);
            cmd.Parameters.AddWithValue("@_clubname", clubname);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.GetValue(1).ToString() == activityname)
                {
                    ActExists = true;
                }
            }
            return ActExists;
        }

        public int ActivateDeregClub(string clubname)
        {
            int status = 0;
            Connect();

            string trasnferDeActivtableQuerySql = "INSERT INTO Clubs (Club_Name, President_Name, VicePresident_Name, Secretary_Name, Clubs_Description, Register_Date) SELECT Club_Name, President_Name, VicePresident_Name, Secretary_Name, Clubs_Description, Register_Date FROM DeactiveClubs WHERE Club_Name=@_clubnamee";
            SqlCommand cmd = new SqlCommand(trasnferDeActivtableQuerySql, conn);
            cmd.Parameters.AddWithValue("@_clubnamee", clubname);
            status = cmd.ExecuteNonQuery();

            if (status > 0)
            {
                string deleteDeregClub = "DELETE FROM DeactiveClubs WHERE Club_Name=@_delclubnamee";
                cmd.Parameters.AddWithValue("@_delclubnamee", clubname);
                cmd.CommandText = deleteDeregClub;
                cmd.ExecuteNonQuery();
            }
            return status;
        }
    }
}
