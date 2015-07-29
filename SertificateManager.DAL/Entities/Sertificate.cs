using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SertificateManager.DAL.Entities
{
    public class Sertificate
    {
        [Key]
      //  [Display(Name="№ Свідоцтва")]
        public string MySertificateId { get; set; }
      //  [Display(Name="Назва")]
        public string Name { get; set; }
     //   [Display(Name="Умовне позначення")]
        public string SertificateTag { get; set; }
     //   [Display(Name="Дійсне до")]
        public string EstimatedTime { get; set; }
      //  [Display(Name = "Виробник")]
        public string Creator { get; set; }
       // [Display(Name="Склад")]
        public string Items { get; set; }
      //  [Display(Name = "Власник")]
        public string Owner { get; set; }
      //  [Display(Name = "ДСТУ")]
        public string QualityDocument { get; set; }
      //  [Display(Name = "Перевірив")]
        public string Validator { get; set; }
       // [Display(Name = "Дата перевірки")]
        public string ValidateTime { get; set; }

    }
}
