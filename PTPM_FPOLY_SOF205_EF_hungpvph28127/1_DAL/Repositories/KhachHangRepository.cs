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
    public class KhachHangRepository : IKhachHangRepository
    {
        public FpolyDBContext _dbcontext;
        public KhachHangRepository()
        {
            _dbcontext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.KhachHangs.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is KhachHangRepository repository;
        }

        public List<KhachHang> GetAll()
        {
            return _dbcontext.KhachHangs.ToList();  
        }

        public KhachHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.KhachHangs.FirstOrDefault(c => c.Id == id);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.QuocGia = obj.QuocGia;
            tempobj.MatKhau = obj.MatKhau;

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
