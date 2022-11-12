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
    public class CuaHangService : IQLCuaHangService
    {
        public ICuaHangRespository _icuaHangRespository;
        public CuaHangService()
        {
            _icuaHangRespository = new CuaHangRespository();
        }
        public string Add(CuaHang CuaHang)
        {
            if (CuaHang == null)
            {
                return "Thêm không thành công";
            }

            if (_icuaHangRespository.Add(CuaHang)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(CuaHang CuaHang)
        {
            if (CuaHang == null)
            {
                return "Xóa không thành công";
            }

            if (_icuaHangRespository.Delete(CuaHang)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<CuaHang> GetAll()
        {
            return _icuaHangRespository.GetAll();
        }

        public CuaHang GetById(Guid id)
        {
            return _icuaHangRespository.GetById(id);
        }

        public CuaHang GetnameCuaHang(string name)
        {
            return _icuaHangRespository.GetnameCuaHang(name);
        }

        public string Update(CuaHang CuaHang)
        {
            if (CuaHang == null)
            {
                return "Sửa không thành công";
            }

            if (_icuaHangRespository.Update(CuaHang)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
