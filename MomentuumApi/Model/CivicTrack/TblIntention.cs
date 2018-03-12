using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblIntention
    {
        public int? Id { get; set; }
        public int? Tempid { get; set; }
        public int IntId { get; set; }
        public string WrapUpCode { get; set; }
        public string FirstChoice { get; set; }
        public string SecondChoice { get; set; }
        public string PrimaryIssue { get; set; }
        public string SecondaryIssue { get; set; }
        public string Timeprocess { get; set; }
        public string Userid { get; set; }
        public string Source { get; set; }
        public string Callback { get; set; }
        public string Deleted { get; set; }
        public string Age { get; set; }
        public string Intriding { get; set; }
    }
}
