using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.DAL.Interfaces;
using SertificateManager.DAL.Entities;
using SertificateManager.DAL.EF;

namespace SertificateManager.DAL.Repositories
{
    public class EFUnitOfWork: IDisposable, IUnitOfWork
    {
        private SertificateContext db;
        private SertificateRepository sertificateRepository;

        public EFUnitOfWork()
        {
            db = new SertificateContext();
        }

        public IRepository<Sertificate> Sertificates
        {
            get
            {
                if (sertificateRepository == null)
                    sertificateRepository = new SertificateRepository(db);
                return sertificateRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
