using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblClientSource
    {
        public int ClientSourceId { get; set; }
        public int ClientId { get; set; }
        public string SourceCode { get; set; }
    }
}
