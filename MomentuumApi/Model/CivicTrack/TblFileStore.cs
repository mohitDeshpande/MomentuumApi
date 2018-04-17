using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MomentuumApi.Model.CivicTrack
{
    public class TblFileStore
    {
        public int? Id { get; set; }
        public string Riding { get; set; }
        public string CaseItemId { get; set; }
        public string UserId { get; set; }
        public string FileName { get; set; }
        public string TimeProcess { get; set; }
        public string Deleted { get; set; }
        public string Comments { get; set; }
        public string VoterId { get; set; }
        public string FileType { get; set; }
        public Byte[] File { get; set; }
        [NotMapped]
        public IFormFile FileUpload { get; set; }
    }
}
