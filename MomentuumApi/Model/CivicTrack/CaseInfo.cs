using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MomentuumApi.Model.CivicTrack
{
    public class CaseInfo
    {
        public List<TblCaseType> casetype { get; set; }
        public List<TblCaseStatus> casestatus { get; set; }
        public List<TblEmployees> caseassignedto { get; set; }
        public Object casedetails { get; set; }
    }
}