using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblClientAdminInfo
    {
        public int ClientAdminInfoId { get; set; }
        public int ClientId { get; set; }
        public string Division { get; set; }
        public DateTime? SignupDate { get; set; }
        public DateTime? InsolvencyDate { get; set; }
        public DateTime? InitialContact { get; set; }
        public DateTime? DateAppointed { get; set; }
        public DateTime? IimeetingOn { get; set; }
        public DateTime? DateSent { get; set; }
        public DateTime? _45days { get; set; }
        public DateTime? DateDeemedAccepted { get; set; }
        public string Trustee { get; set; }
        public string EstateAdministrator { get; set; }
        public string Technician { get; set; }
        public string InitialInterview { get; set; }
        public string FileAdminVersion { get; set; }
        public string CourtName { get; set; }
        public string CourtNumber { get; set; }
        public string DivisionNumber { get; set; }
        public string District { get; set; }
        public string Location { get; set; }
        public string FileMgr { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? MeetingDate { get; set; }
        public string IntakeAgent { get; set; }
        public string FilingAgent { get; set; }
    }
}
