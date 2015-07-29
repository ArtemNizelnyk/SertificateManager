using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.DAL.Entities;

namespace SertificateManager.DAL.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<Sertificate> Sertificates { get; }

        void Save();
    }
}
