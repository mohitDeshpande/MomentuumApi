using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblRoundCase
    {
        public int? Id { get; set; }
        public int CaseId { get; set; }
        public string CaseType { get; set; }
        public string CaseSubType { get; set; }
        public string CaseDetail { get; set; }
        public string CaseStatus { get; set; }
        public string CaseOpenDate { get; set; }
        public string CaseClosedDate { get; set; }
        public string CaseRoundTableDate { get; set; }
        public string CaseBringForwardDate { get; set; }
        public string CreatedBy { get; set; }
        public string Deleted { get; set; }
        public int? Userid { get; set; }
        public string Timeprocess { get; set; }
        public string Riding { get; set; }
        public string CaseDescription { get; set; }
        public bool? Attended { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
    }
}
