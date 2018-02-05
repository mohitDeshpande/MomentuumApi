using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblPlan
    {
        public int PlanId { get; set; }
        public string Division { get; set; }
        public int ClientId { get; set; }
        public int ParentPlanId { get; set; }
        public int ChildPlanId { get; set; }
        public decimal PlanAmount { get; set; }
        public decimal Balance { get; set; }
        public decimal TotalFees { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Bank { get; set; }
        public string BankTransitNo { get; set; }
        public string BankInstituteNo { get; set; }
        public string BankDesignationNo { get; set; }
        public string BankAccountNo { get; set; }
        public string PlanType { get; set; }
        public string Status { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int ModifiedEmployeeId { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedEmployeeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
