using _1_DAL.Context;
using _1_DAL.DomainClass;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repositories
{
    public class MauSacRepository : IMauSacRepository
    {
        private FpolyDBContext _dbcontext;

        public MauSacRepository()
        {
            _dbcontext = new FpolyDBContext();    
        }

        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.MauSacs.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dbcontext.MauSacs.ToList();
        }

        public MauSac GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.MauSacs.FirstOrDefault(c => c.Id == id);
        }

        public MauSac GetbyNameMs(string name)
        {
            if(name == "") return null;
            return _dbcontext.MauSacs.FirstOrDefault(c => c.Ten == name);
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
