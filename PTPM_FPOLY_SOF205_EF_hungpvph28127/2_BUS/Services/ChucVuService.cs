using _1_DAL.DomainClass;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class ChucVuService :IQLChucVuService
    {
        private IChucVuRepository _ichucVuRepository;
        public ChucVuService()
        {
            _ichucVuRepository = new ChucVuRepository();
        }

        public string Add(ChucVu chucvu)
        {
            if (chucvu == null)
            {
                return "Thêm không thành công";
            }
            
            if(_ichucVuRepository.Add(chucvu)) return "Thêm thành công";
            return "Thêm không thành công";

        }

        public string Delete(ChucVu chucvu)
        {
            if (chucvu == null)
            {
                return "Xóa không thành công";
            }

            if (_ichucVuRepository.Delete(chucvu)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<ChucVu> GetAll()
        {
            return _ichucVuRepository.GetAll();
        }

        public ChucVu GetById(Guid id)
        {
            return _ichucVuRepository.GetById(id);
        }

        public ChucVu Getnamechucvu(string name)
        {
            return _ichucVuRepository.Getnamechucvu(name);
        }

        public string Update(ChucVu chucvu)
        {
            if (chucvu == null)
            {
                return "Sửa không thành công";
            }

            if (_ichucVuRepository.Update(chucvu)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
