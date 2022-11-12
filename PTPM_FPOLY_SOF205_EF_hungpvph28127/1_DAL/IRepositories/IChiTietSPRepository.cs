using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IChiTietSPRepository
    {
        bool Add(ChiTietSp obj);

        bool Update(ChiTietSp obj);

        bool Delete(ChiTietSp obj);

        ChiTietSp GetById(Guid id); // tìm sp theo id

        List<ChiTietSp> GetAll();
    }
}
