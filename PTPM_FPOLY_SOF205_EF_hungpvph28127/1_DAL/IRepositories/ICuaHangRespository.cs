using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface ICuaHangRespository
    {
        bool Add(CuaHang obj);

        bool Update(CuaHang obj);

        bool Delete(CuaHang obj);

        CuaHang GetById(Guid id); // tìm sp theo id

        List<CuaHang> GetAll();
        CuaHang GetnameCuaHang(string name);
    }
}
