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
    public class ChucVuRepository : IChucVuRepository
    {
        public FpolyDBContext _dbcontext;
        public ChucVuRepository()
        {
            _dbcontext = new FpolyDBContext();
        }
        public bool Add(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.ChucVus.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAll()
        {
            return _dbcontext.ChucVus.ToList();
        }

        public ChucVu GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.ChucVus.FirstOrDefault(c => c.Id == id);
        }
        
        public ChucVu Getnamechucvu(string name)
        {
            if (name == "") return null;
            return _dbcontext.ChucVus.FirstOrDefault(c => c.Ten == name);
        }
        public bool Update(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
