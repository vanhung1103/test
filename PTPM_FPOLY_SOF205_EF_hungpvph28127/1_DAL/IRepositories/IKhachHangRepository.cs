using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IKhachHangRepository
    {
        bool Add(KhachHang obj);

        bool Update(KhachHang obj);

        bool Delete(KhachHang obj);

        KhachHang GetById(Guid id); // tìm sp theo id

        List<KhachHang> GetAll();
    }
}
