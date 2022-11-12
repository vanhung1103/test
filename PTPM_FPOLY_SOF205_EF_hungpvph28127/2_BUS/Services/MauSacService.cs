using _1_DAL.DomainClass;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class MauSacService : IQLMauSacService

    {
        public IMauSacRepository _imauSacRepository;
        public MauSacService()
        {
            _imauSacRepository = new MauSacRepository();
        }
        public string Add(MauSac MauSac)
        {
            if (MauSac == null)
            {
                return "Thêm không thành công";
            }

            if (_imauSacRepository.Add(MauSac)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(MauSac MauSac)
        {
            if (MauSac == null)
            {
                return "Xóa không thành công";
            }

            if (_imauSacRepository.Delete(MauSac)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<MauSac> GetAll()
        {
            return _imauSacRepository.GetAll();
        }

        public string Update(MauSac MauSac)
        {
            if(MauSac == null)
            {
                return "Sửa không thành công";
            }

            if (_imauSacRepository.Update(MauSac)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
