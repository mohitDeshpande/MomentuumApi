using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblCase
    {
        public int? IdClient { get; set; }
        public int Caseid { get; set; }
        public DateTime? CaseOpenDate { get; set; }
        public string Casetype { get; set; }
        public string Casedescription { get; set; }
        public string Casestatus { get; set; }
        public string CaseAssignedTo { get; set; }
        public string CaseNature { get; set; }
        public DateTime? CaseClosedDate { get; set; }
        public string CaseCode { get; set; }
        public string CaseSource { get; set; }
        public string Deleted { get; set; }
        public DateTime? Timeprocess { get; set; }
        public string Userid { get; set; }
        public string Createdby { get; set; }
        public string Subtype { get; set; }
        public string Casein { get; set; }
        // public string Createddate { get; set; }
        // public string Updateddate { get; set; }

        //public TblClient IdNavigation { get; set; }
    }
}
