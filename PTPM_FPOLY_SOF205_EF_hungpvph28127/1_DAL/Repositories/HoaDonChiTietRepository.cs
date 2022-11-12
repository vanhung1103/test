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
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        public FpolyDBContext _dbcontext;

        public HoaDonChiTietRepository() { 
            _dbcontext = new FpolyDBContext();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            ;
            _dbcontext.HoaDonChiTiets.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<HoaDonChiTiet> GetAll()
        {
            throw new NotImplementedException();
        }

        public HoaDonChiTiet GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == id);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempobj.SoLuong = obj.SoLuong;
            tempobj. DonGia = obj. DonGia;
            

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
