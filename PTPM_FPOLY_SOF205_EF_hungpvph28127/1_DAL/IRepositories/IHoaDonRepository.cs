using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonRepository
    {
        bool Add(HoaDon obj);

        bool Update(HoaDon obj);

        bool Delete(HoaDon obj);

        HoaDon GetById(Guid id); // tìm sp theo id

        List<HoaDon> GetAll();
    }
}
