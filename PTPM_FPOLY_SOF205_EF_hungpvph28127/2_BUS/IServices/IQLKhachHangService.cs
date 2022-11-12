using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLKhachHangService
    {
        List<KhachHangView> GetAll();
        string Add(KhachHangView KhachHang);
        string Delete(KhachHangView KhachHang);
        string Update(KhachHangView KhachHang);
    }
}
