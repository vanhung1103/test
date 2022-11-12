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
    public class NsxRepository : INsxRepository
    {
        private FpolyDBContext _dbcontext;

        public NsxRepository()
        {
            _dbcontext = new FpolyDBContext();
        }

        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.Nsxes.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return _dbcontext.Nsxes.ToList();
        }

        public Nsx GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.Nsxes.FirstOrDefault(c => c.Id == id);
        }

        public Nsx GetbyNameNsx(string name)
        {
            if (name == "") return null;
            return _dbcontext.Nsxes.FirstOrDefault(c => c.Ten == name);
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
