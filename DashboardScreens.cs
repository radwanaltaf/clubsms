using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clubs_Management_System
{
    class DashboardScreens
    {
        private DeregisterClub _DeregisterChild = null;
        private SearchClubs _SearchChild = null;
        private UpdateClubsDescription _UpdateClubDescChild = null;
        private ClubsReport _ClubsReportChild = null;
        private RegisterClub _RegisterChild = null;
        private UpdateClub _UpdateClubChild = null;
        private ReportActivities _ReportActivitiesChild = null;
        private UpdateClubActivity _UpdateClubActivityChild = null;
        private Login _LoginChild = null;
        private RegisterDeactiveClub _RegisterDeActiveClub= null;

        public DeregisterClub DeregisterChild { get => _DeregisterChild; set => _DeregisterChild = value; }
        public SearchClubs SearchChild { get => _SearchChild; set => _SearchChild = value; }
        public UpdateClubsDescription UpdateClubDescChild { get => _UpdateClubDescChild; set => _UpdateClubDescChild = value; }
        public ClubsReport ClubsReportChild { get => _ClubsReportChild; set => _ClubsReportChild = value; } 
        public RegisterClub RegisterChild { get => _RegisterChild; set => _RegisterChild = value; }
        public UpdateClub UpdateClubChild { get => _UpdateClubChild; set => _UpdateClubChild = value; }
        public ReportActivities ReportActivitiesChild { get => _ReportActivitiesChild; set => _ReportActivitiesChild = value; }
        public UpdateClubActivity UpdateClubActivityChild { get => _UpdateClubActivityChild; set => _UpdateClubActivityChild = value; }
        public Login LoginChild { get => _LoginChild; set => _LoginChild = value; }
        public RegisterDeactiveClub RegisterDeactiveChil { get => _RegisterDeActiveClub; set => _RegisterDeActiveClub = value; }
    }
}
