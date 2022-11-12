using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLCuaHangService
    {
        List<CuaHang> GetAll();
        string Add(CuaHang CuaHang);
        string Delete(CuaHang CuaHang);
        string Update(CuaHang CuaHang);
        CuaHang GetnameCuaHang(string name);
        CuaHang GetById(Guid id);
    }
}
