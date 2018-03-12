using System;
namespace MomentuumApi.Model.CivicTrack
{
    public class TblEmployees
    {

        public int EmployeeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmployeeLogin { get; set; }
        public string EmployeeName { get; set; }
        public string EmailAddress { get; set; }
        public string UsrPassword { get; set; }
        public bool? Active { get; set; }
        public int? Attemptcount { get; set; }
        public DateTime? LastLogin { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string WorkPhoneExt { get; set; }
        public string Division { get; set; }
    
        public TblEmployees()
        { }
            
    }
}
