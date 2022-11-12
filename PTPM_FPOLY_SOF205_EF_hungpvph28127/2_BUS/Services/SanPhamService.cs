using _1_DAL.Context;
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
    public class SanPhamService : IQLSanPhamService
    {
        private IChiTietSPRepository _ichiTietSPRepository;
        private INsxRepository _iNsxRepository;
        private IMauSacRepository _iMauSacRepository;
        private ISanPhamRepository _iSanPhamRepository;
        private IDspRepository _idspRepository;

        public SanPhamService()
        {
            _ichiTietSPRepository = new ChiTietSPRepository();
            _iNsxRepository = new NsxRepository();
            _iSanPhamRepository = new SanPhamRepository();
            _iMauSacRepository = new MauSacRepository();
            _idspRepository = new DspRepository();
        }
        FpolyDBContext _dbcontext = new FpolyDBContext();
        public SanPham GetNameSp(string name)
        {
            return _iSanPhamRepository.GetbyNameSp(name);
        }
        public DongSp GetNameDsp(string name)
        {
            return _idspRepository.GetbyNameDsp(name);
        }
        public Nsx GetNameNsx(string name)
        {
            return _iNsxRepository.GetbyNameNsx(name);
        }
        public MauSac GetNameMs(string name)
        {
            return _iMauSacRepository.GetbyNameMs(name);
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null) return "Thêm không thành công";
            var chiTietSanPham = obj.ChiTietSp;
            if(_ichiTietSPRepository.Add(chiTietSanPham)) return "Thêm  thành công";
            return "Thêm không thành công";
        }

        public string Delete(SanPhamView obj)
        {

            if (obj == null) return "Xóa không thành công";
            var chiTietSanPham = obj.ChiTietSp;
           if(_ichiTietSPRepository.Delete(chiTietSanPham)) return "Xóa  thành công";
            return "Xóa không thành công";
        }
        public List<MauSac> GetAllMau()
        {
            return _iMauSacRepository.GetAll().ToList();
        }
        public List<DongSp> GetAllDongsp()
        {
            return _idspRepository.GetAll().ToList();
        }
        public List<Nsx> GetAllNsx()
        {
            return _iNsxRepository.GetAll().ToList();
        }
        public List<SanPham> GetAllSanPham()
        {
            return _iSanPhamRepository.GetAll().ToList();
        }
        public List<SanPhamView> GetAll()
        {
           List<SanPhamView> lstsanPhamViews = new List<SanPhamView>();
            lstsanPhamViews = (
                from a in _ichiTietSPRepository.GetAll()
                join b in _iSanPhamRepository.GetAll() on a.IdSp equals b.Id
                join c in _iMauSacRepository.GetAll() on a.IdMauSac equals c.Id
                join d in _iNsxRepository.GetAll() on a.IdNsx equals d.Id
                join e in _idspRepository.GetAll() on a.IdDongSp equals e.Id
                select new SanPhamView()
                {
                    ChiTietSp = a,
                    SanPham = b,
                    MauSac = c,
                    Nsx = d,
                    DongSp = e
                }).ToList();
            return lstsanPhamViews;
            
        }

        public string Update(SanPhamView obj)
        {
            if (obj == null) return "sửa không thành công";
            var chiTietSanPham = obj.ChiTietSp;
            if (_ichiTietSPRepository.Update(chiTietSanPham)) return "Sửa thành công";
            return "sửa không thành công";
        }
    }
}
