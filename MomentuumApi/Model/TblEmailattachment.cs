using System;
using System.Collections.Generic;

namespace MomentuumApi.Model
{
    public partial class TblEmailattachment
    {
        public int Id { get; set; }
        public int? TemplateId { get; set; }
        public string FilePathUrl { get; set; }
        public string Division { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
