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
    public class HoaDonChiTietRespository : IQLHoaDonChiTietService
    {
        private IHoaDonChiTietRepository _iHoaDonChiTietRepository;
        private IHoaDonChiTietRepository _ihoaDonChiTietRepository;
        public HoaDonChiTietRespository()
        {
            _ihoaDonChiTietRepository = new HoaDonChiTietRepository();
            _iHoaDonChiTietRepository = new HoaDonChiTietRepository();

        }
        public string Add(HoaDonChiTiet HoaDonChiTiet)
        {
            //if (HoaDonChiTiet == null) return "Thêm không thành công";
            //var chiTietSanPham = HoaDonChiTiet.HoaDonChiTiet;
            //if (_iHoaDonChiTietRepository.Add(chiTietSanPham)) return "Thêm  thành công";
            return "Thêm không thành công";
        }
    

        public string Delete(HoaDonChiTiet HoaDonChiTiet)
        {
            //if (HoaDonChiTiet == null) return "Xóa không thành công";
            //var chiTietSanPham = HoaDonChiTiet.HoaDonChiTiet;
            //if (_iHoaDonChiTietRepository.Delete(chiTietSanPham)) return "Xóa  thành công";
            return "Xóa không thành công";
        }

        public List<HoaDonChiTiet> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(HoaDonChiTiet HoaDonChiTiet)
        {
            throw new NotImplementedException();
        }
    }
}

