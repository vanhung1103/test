using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        bool Add(HoaDonChiTiet obj);

        bool Update(HoaDonChiTiet obj);

        bool Delete(HoaDonChiTiet obj);

        HoaDonChiTiet GetById(Guid id); // tìm sp theo id

        List<HoaDonChiTiet> GetAll();
    }
}
