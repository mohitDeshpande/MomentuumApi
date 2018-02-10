using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class LstType
    {
        public int LocationId { get; set; }
        public string Listtext { get; set; }
        public string Id { get; set; }
        public int? Refid { get; set; }
        public int? Score { get; set; }
        public string Code { get; set; }
    }
}
