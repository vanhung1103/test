using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IDspRepository
    {
        bool Add(DongSp obj);

        bool Update(DongSp obj);

        bool Delete(DongSp obj);

        DongSp GetById(Guid id); // tìm sp theo id
        DongSp GetbyNameDsp(string name);
        List<DongSp> GetAll();
    }
}
