using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface INsxRepository
    {
        bool Add(Nsx obj);

        bool Update(Nsx obj);

        bool Delete(Nsx obj);

        Nsx GetById(Guid id); // tìm sp theo id
        Nsx GetbyNameNsx (string name);
        List<Nsx> GetAll();
    }
}
