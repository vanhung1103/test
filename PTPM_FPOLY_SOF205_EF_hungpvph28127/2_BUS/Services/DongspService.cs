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
    public class DongspService : IDongspService
    {
        public IDspRepository _idspRepository;
        public DongspService()
        {
            _idspRepository = new DspRepository();
        }
        public string Add(DongSp DongSp)
        {
            if (DongSp == null)
            {
                return "Thêm không thành công";
            }

            if (_idspRepository.Add(DongSp)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(DongSp DongSp)
        {
            if (DongSp == null)
            {
                return "Xóa không thành công";
            }

            if (_idspRepository.Delete(DongSp)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<DongSp> GetAll()
        {
            return _idspRepository.GetAll();
        }

        public string Update(DongSp DongSp)
        {
            if (DongSp == null)
            {
                return "Sửa không thành công";
            }

            if (_idspRepository.Update(DongSp)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
