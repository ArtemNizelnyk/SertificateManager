using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SertificateManager.BLL.DTO
{
    public class SertificateDTO
    {
        public string MySertificateId { get; set; }
        public string EstimatedTime { get; set; }
        public string Name { get; set; }
        public string SertificateTag { get; set; }
        public string Items { get; set; }
        public string Creator { get; set; }
        public string Owner { get; set; }
        public string QualityDocument { get; set; }
        public string Validator { get; set; }
        public string ValidateTime { get; set; }
    }
}
