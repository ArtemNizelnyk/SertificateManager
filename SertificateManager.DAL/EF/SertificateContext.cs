using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.DAL.Entities;

namespace SertificateManager.DAL.EF
{
    public class SertificateContext:DbContext
    {
        public SertificateContext()
            : base("SertificateContext") { }

        public DbSet<Sertificate> Sertificates { get; set; }
    }
}
