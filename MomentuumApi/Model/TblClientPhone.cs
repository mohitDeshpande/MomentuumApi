using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblClientPhone
    {
        public int ClientPhoneId { get; set; }
        public int? ClientId { get; set; }
        public int? DisplayOrder { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneType { get; set; }
    }
}
