using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.BLL.DTO;
using System.ComponentModel;

namespace SertificateManager.BLL.Interfaces
{
    public interface IService
    {
        void MakeSertificate(SertificateDTO sertificateDTO);
        SertificateDTO GetSertificate(string id);
        List<SertificateDTO> GetSertificates();
        void Delete(string id);
        void Dispose();
    }
}
