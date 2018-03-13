using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblImportHdr
    {
        public long ImportHdrId { get; set; }
        public string ClientLogin { get; set; }
        public string Password { get; set; }
        public string Ipaddress { get; set; }
        public string ImportedFiles { get; set; }
        public long? TotalLoadedRecords { get; set; }
        public long? TotalSavedRecords { get; set; }
        public DateTime? ExecutionStart { get; set; }
        public DateTime? ExecutionEnd { get; set; }
        public bool? IsAutoAssigned { get; set; }
        public int? ImportTypeId { get; set; }
        public string Complete { get; set; }
    }
}
