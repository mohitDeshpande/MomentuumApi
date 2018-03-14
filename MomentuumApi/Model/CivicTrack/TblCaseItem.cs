using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MomentuumApi.Model.CivicTrack
{
    public partial class TblCaseItem
    {
        public int? IntId { get; set; }
        public int Caseid { get; set; }
        public String CaseItemDate { get; set; }
        public String CaseItemDescription { get; set; }
        public String CaseItemDetail { get; set; }
        public String CaseItemStatus { get; set; }
        public String CaseItemAction { get; set; }
        public String CaseItemAssigned { get; set; }
        public String CaseItemFollowUpdate { get; set; }
        public String Deleted { get; set; }
        public String UserId { get; set; }
        public String TimeProcess { get; set; }
        /*not in new db
        public String Priority { get; set; }
        public String CreatedBy { get; set; }
        public String CreatedDate { get; set; }
        public String UpdatedDate { get; set; }
        */
    }
}
