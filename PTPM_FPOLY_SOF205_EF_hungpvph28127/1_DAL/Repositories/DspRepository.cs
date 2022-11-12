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
    public class DspRepository : IDspRepository
    {
        private FpolyDBContext _dbcontext;
        

        public DspRepository()
        {
            _dbcontext = new FpolyDBContext();
        }

        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.DongSps.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return _dbcontext.DongSps.ToList();
        }

        public DongSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.DongSps.FirstOrDefault(c => c.Id == id);
        }

        public DongSp GetbyNameDsp(string name)
        {
            if (name == "")
                return null;
            return _dbcontext.DongSps.FirstOrDefault(c => c.Ten == name);       
        }


        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;

            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
