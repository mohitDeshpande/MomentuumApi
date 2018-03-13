using System;
using System.Collections.Generic;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblRoundtablequeue
    {
        public int Caseid { get; set; }
        public int Voterid { get; set; }
        public DateTime Locktime { get; set; }
        public string Riding { get; set; }
    }
}
