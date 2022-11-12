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
    public class CuaHangRespository : ICuaHangRespository
    {
        FpolyDBContext _dbcontext;

        public CuaHangRespository()
        {
            _dbcontext = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.CuaHangs.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }
        public CuaHang GetnameCuaHang(string name)
        {
            if (name == "") return null;
            return _dbcontext.CuaHangs.FirstOrDefault(c => c.Ten == name);
        }
        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _dbcontext.CuaHangs.ToList();
        }

        public CuaHang GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.CuaHangs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;


            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
