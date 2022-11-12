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
    public class KhachHangService : IQLKhachHangService
    {
        public IKhachHangRepository _ikhachHangRepository;
        public KhachHangService()
        {
            _ikhachHangRepository = new KhachHangRepository();
        }
        public string Add(KhachHangView KhachHang)
        {
            if (KhachHang == null)
            {
                return "Thêm không thành công";
            }
            var khachHang= KhachHang.KhachHang;
            if (_ikhachHangRepository.Add(khachHang)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(KhachHangView KhachHang)
        {
            if (KhachHang == null)
            {
                return "Xóa không thành công";
            }
            var khachHang = KhachHang.KhachHang;
            if (_ikhachHangRepository.Delete(khachHang)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<KhachHangView> GetAll()
        {
            List < KhachHangView > lstKH = new List<KhachHangView>();
            lstKH = (
                from a in _ikhachHangRepository.GetAll()
                select new KhachHangView()
                {
                    KhachHang = a
                }
                ).ToList();
            return lstKH;
        }

        public string Update(KhachHangView KhachHang)
        {
            if (KhachHang == null)
            {
                return "Sửa không thành công";
            }
            var khachHang = KhachHang.KhachHang;
            if (_ikhachHangRepository.Update(khachHang)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
