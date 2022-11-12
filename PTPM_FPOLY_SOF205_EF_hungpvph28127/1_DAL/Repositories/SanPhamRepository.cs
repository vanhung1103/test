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
    public class SanPhamRepository : ISanPhamRepository
    {
        private FpolyDBContext _dbcontext;

        public SanPhamRepository()
        {
            _dbcontext = new FpolyDBContext();    
        }

        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.SanPhams.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
            return _dbcontext.SanPhams.ToList();
        }

        public SanPham GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.SanPhams.FirstOrDefault(c => c.Id == id);
        }

        public SanPham GetbyNameSp(string name)
        {
            if(name == "") return null;
            return _dbcontext.SanPhams.FirstOrDefault(c => c.Ten == name);
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ten = obj.Ten;
            tempobj.Ma = obj.Ma;
            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
