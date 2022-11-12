using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
   public interface IQLNhanVienService
    {
        List<NhanVienView> GetAll();
        string Add(NhanVienView NhanVien);
        string Delete(NhanVienView NhanVien);
        string Update(NhanVienView NhanVien);
        NhanVien GetByid(Guid id);
        ChucVu Getnamechucvu(string name);
        CuaHang GetnameCuaHang(string name);
        ChucVu GetByIdcv(Guid id);
        CuaHang GetByIdch(Guid id);
    }
}
