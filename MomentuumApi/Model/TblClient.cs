using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblClient
    {
        public TblClient()
        {
            //TblCase = new HashSet<TblCase>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Class { get; set; }
        public string Status { get; set; }
        public string Lastname { get; set; }
        public string FirstName { get; set; }
        public string Middlename { get; set; }
        public string MaidenName { get; set; }
        public string AlsoKnownAs { get; set; }
        public string MaritalStatus { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddleName { get; set; }
        public string SpouseLastName { get; set; }
        public string SpouseMaidenName { get; set; }
        public string SpouseAlsoKnownAs { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Division { get; set; }
        public string Filename { get; set; }
        public string MainPhone { get; set; }
        public string MainPhoneType { get; set; }
        public string HomeArea { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string WorkArea { get; set; }
        public string WorkPhone { get; set; }
        public string FaxArea { get; set; }
        public string FaxPhone { get; set; }
        public string Email { get; set; }
        public int? Score { get; set; }
        public string SignedOut { get; set; }
        public int? Complete { get; set; }
        public string Cust1 { get; set; }
        public string Cust2 { get; set; }
        public string Cust3 { get; set; }
        public bool? Dnc { get; set; }
        public bool? Dnm { get; set; }
        public bool? Dne { get; set; }
        public int? Sin { get; set; }
        public DateTime? Dob { get; set; }
        public string PreferredContact { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedTimestamp { get; set; }
        public string Seq { get; set; }

        //public ICollection<TblCase> TblCase { get; set; }
    }
}
