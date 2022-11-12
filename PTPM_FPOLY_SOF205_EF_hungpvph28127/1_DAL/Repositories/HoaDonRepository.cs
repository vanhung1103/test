using _1_DAL.Context;
using _1_DAL.DomainClass;
using _1_DAL.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        FpolyDBContext _dbcontext;

        public HoaDonRepository()
        {
            _dbcontext = new FpolyDBContext();
        }

        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.HoaDons.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        bool IHoaDonRepository.Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        List<HoaDon> IHoaDonRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        HoaDon IHoaDonRepository.GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.HoaDons.FirstOrDefault(c => c.Id == id);
        }

        bool IHoaDonRepository.Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TinhTrang = obj.TinhTrang;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.TenNguoiNhan = tempobj.TenNguoiNhan;
            tempobj.Sdt = obj.Sdt;

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
