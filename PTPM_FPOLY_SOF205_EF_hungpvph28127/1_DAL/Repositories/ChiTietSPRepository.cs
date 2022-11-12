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
    public class ChiTietSPRepository : IChiTietSPRepository
    {
        FpolyDBContext _dbcontext;

        public ChiTietSPRepository()
        {
            _dbcontext = new FpolyDBContext();
        }
       
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _dbcontext.ChiTietSps.Add(obj);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbcontext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);

            _dbcontext.Remove(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<ChiTietSp> GetAll()
        {
            return _dbcontext.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(Guid id)
        {
            if (id == Guid.Empty) return null;
            return _dbcontext.ChiTietSps.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ChiTietSp obj)
        {

            if (obj == null) return false;
            var tempobj = _dbcontext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdSp = obj.IdSp;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.NamBh = obj.NamBh;
            tempobj.MoTa = obj.MoTa;
          
            _dbcontext.Update(tempobj);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
