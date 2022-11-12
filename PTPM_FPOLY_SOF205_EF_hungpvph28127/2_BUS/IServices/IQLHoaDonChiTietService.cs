using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLHoaDonChiTietService
    {
        List<HoaDonChiTiet> GetAll();
        string Add(HoaDonChiTiet HoaDonChiTiet);
        string Delete(HoaDonChiTiet HoaDonChiTiet);
        string Update(HoaDonChiTiet HoaDonChiTiet);
    }
}
