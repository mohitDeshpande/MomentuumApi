using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblLocationAddress
    {
        public int LocationAddressId { get; set; }
        public int LocationId { get; set; }
        public string Division { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
