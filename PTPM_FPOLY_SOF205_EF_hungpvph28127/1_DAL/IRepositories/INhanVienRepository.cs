using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
   public interface INhanVienRepository
    {
        bool Add(NhanVien obj);

        bool Update(NhanVien obj);

        bool Delete(NhanVien obj);

        NhanVien GetById(Guid id); // tìm sp theo id

        List<NhanVien> GetAll();
    }
}
