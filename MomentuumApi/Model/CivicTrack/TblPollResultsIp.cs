using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblPollResultsIp
    {
        public int FdPollResultsIpid { get; set; }
        public int? FdPollId { get; set; }
        public string FdPollResultsIp { get; set; }
        public DateTime? FdPollResultsIpdate { get; set; }
        public string FdPollResults { get; set; }
        public string FdPollResultsEmail { get; set; }
    }
}
