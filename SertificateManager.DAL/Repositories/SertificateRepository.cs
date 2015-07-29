using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.DAL.Interfaces;
using SertificateManager.DAL.Entities;
using System.Data.Entity;
using System.ComponentModel;
using SertificateManager.DAL.EF;

namespace SertificateManager.DAL.Repositories
{
    public class SertificateRepository:IRepository<Sertificate> 
    {
        private SertificateContext db;

        public SertificateRepository(SertificateContext context)
        {
            this.db = context;
        }

        public IEnumerable<Sertificate> GetAll()
        {
            return db.Sertificates;
        }

        public Sertificate Get(string id)
        {
            return db.Sertificates.Find(id);
        }

        public void Create (Sertificate sertificate)
        {
            db.Sertificates.Add(sertificate);
        }

        public void Update (Sertificate sertificate)
        {
            db.Entry(sertificate).State = EntityState.Modified;
        }

        public IEnumerable<Sertificate> Find(Func<Sertificate, Boolean> predicate)
        {
            return db.Sertificates.Where(predicate).ToList();
        }
        public void Delete (string id)
        {
           Sertificate sertificate=db.Sertificates.Find(id);
           if (sertificate != null)
               db.Sertificates.Remove(sertificate);
        }
    }
}
