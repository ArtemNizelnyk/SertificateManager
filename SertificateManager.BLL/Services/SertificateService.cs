using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SertificateManager.BLL.DTO;
using SertificateManager.BLL.Interfaces;
using SertificateManager.DAL.Interfaces;
using SertificateManager.DAL.Entities;
using AutoMapper;
using System.ComponentModel;

namespace SertificateManager.BLL.Services
{
    public class SertificateService : IService
    {
        IUnitOfWork Database { get; set; }

        public SertificateService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void MakeSertificate(SertificateDTO sertificateDTO)
        {
            Sertificate sertificate = Database.Sertificates.Get(sertificateDTO.MySertificateId);

            if (sertificate == null)
            {
                Sertificate newSertificate = new Sertificate
                {
                    MySertificateId = sertificateDTO.MySertificateId,
                    EstimatedTime = sertificateDTO.EstimatedTime,
                    Name = sertificateDTO.Name,
                    SertificateTag = sertificateDTO.SertificateTag,
                    Creator = sertificateDTO.Creator,
                    Owner = sertificateDTO.Owner,
                    Validator = sertificateDTO.Validator,
                    QualityDocument = sertificateDTO.QualityDocument,
                    Items = sertificateDTO.Items,
                    ValidateTime = sertificateDTO.ValidateTime
                };
                Database.Sertificates.Create(newSertificate);
            }
            else 
            {
                    sertificate.EstimatedTime = sertificateDTO.EstimatedTime;
                    sertificate.Name = sertificateDTO.Name;
                    sertificate.SertificateTag = sertificateDTO.SertificateTag;
                    sertificate.Creator = sertificateDTO.Creator;
                    sertificate.Owner = sertificateDTO.Owner;
                    sertificate.Validator = sertificateDTO.Validator;
                    sertificate.QualityDocument = sertificateDTO.QualityDocument;
                    sertificate.Items = sertificateDTO.Items;
                    sertificate.ValidateTime = sertificateDTO.ValidateTime;
              
                Database.Sertificates.Update(sertificate);
            }
                Database.Save();
            
        }

        public SertificateDTO GetSertificate(string id)
        {
            if (id == null)
                throw new NullReferenceException("Не установлено id сертификата");
            var sertificate = Database.Sertificates.Get(id);
            if (sertificate == null)
                throw new NullReferenceException("Сертификат не найден");
            Mapper.CreateMap<Sertificate, SertificateDTO>();
            return Mapper.Map<Sertificate, SertificateDTO>(sertificate);
        }

        public List<SertificateDTO> GetSertificates()
        {
            Mapper.CreateMap<Sertificate, SertificateDTO>();
            return Mapper.Map<IEnumerable<Sertificate>, List<SertificateDTO>>(Database.Sertificates.GetAll());
        }
        public void Delete (string id)
        {
            Database.Sertificates.Delete(id);
            Database.Save();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
