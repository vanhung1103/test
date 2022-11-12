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
    public class NhanVienRepository : INhanVienRepository
    {
        public FpolyDBContext _dbcontext;

        public NhanVienRepository()
        {
            _dbcontext = new FpolyDBContext();  
        }

        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.NhanViens.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return _dbcontext.NhanViens.ToList();   
        }

        public NhanVien GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.NhanViens.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.TrangThai = obj.TrangThai;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.Sdt = obj.Sdt;
            tempobj.IdCh = obj.IdCh;
            tempobj.IdCv = obj.IdCv;
            tempobj.IdGuiBc = obj.IdGuiBc;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.Ma = obj.Ma;
            

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
