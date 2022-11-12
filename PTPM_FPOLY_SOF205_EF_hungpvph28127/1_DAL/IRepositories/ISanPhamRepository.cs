using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public  interface ISanPhamRepository
    {
        bool Add(SanPham obj);

        bool Update(SanPham obj);

        bool Delete(SanPham obj);

        SanPham GetById(Guid id); // tìm sp theo id
        SanPham GetbyNameSp(string name);
        List<SanPham> GetAll();
    }
}
