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
    public class NhanVienService : IQLNhanVienService
    {
        public INhanVienRepository _iNhanVienRepository;
        public IChucVuRepository  _iChucVuRepository;
        public ICuaHangRespository _icuaHangRespository;
        public NhanVienService()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _icuaHangRespository = new CuaHangRespository();
            _iChucVuRepository = new ChucVuRepository();
        }
        public string Add(NhanVienView NhanVienView)
        {
            if (NhanVienView == null)
            {
                return "Thêm không thành công";
            }
            var Nvview = NhanVienView.NhanVien;
            if (_iNhanVienRepository.Add(Nvview)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        

        public string Delete(NhanVienView NhanVienView)
        {
            if (NhanVienView == null) return "Xóa không thành công";
            var Nvview = NhanVienView.NhanVien;
            if (_iNhanVienRepository.Delete(Nvview)) return "Xóa  thành công";
            return "Xóa không thành công";
        }

        

        public List<NhanVienView> GetAll()
        {
            List<NhanVienView> lstnhanvienViews = new List<NhanVienView>();
            lstnhanvienViews = (
                from a in _iNhanVienRepository.GetAll()
                join b in _iChucVuRepository.GetAll() on a.IdCv equals b.Id
                join c in _icuaHangRespository.GetAll() on a.IdCh equals c.Id

                select new NhanVienView()
                {
                    NhanVien = a,
                    ChucVu = b,
                    CuaHang = c
                }).ToList();
            return lstnhanvienViews;
        }

        public NhanVien GetByid(Guid id)
        {
            return _iNhanVienRepository.GetById(id);
        }
        public CuaHang GetByIdch(Guid id)
        {
            return _icuaHangRespository.GetById(id);
        }
        public ChucVu GetByIdcv(Guid id)
        {
            return _iChucVuRepository.GetById(id);
        }
        public ChucVu Getnamechucvu(string name)
        {
            return _iChucVuRepository.Getnamechucvu(name);
        }

        public CuaHang GetnameCuaHang(string name)
        {
            return _icuaHangRespository.GetnameCuaHang(name);
        }

        public string Update(NhanVienView NhanVienView)
        {
            if (NhanVienView == null) return "sửa không thành công";
            var Nvview = NhanVienView.NhanVien;
            if (_iNhanVienRepository.Update(Nvview)) return "Sửa thành công";
            return "sửa không thành công";
        }

        

        
    }
}
