using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IChucVuRepository
    {
        bool Add(ChucVu obj);

        bool Update(ChucVu obj);

        bool Delete(ChucVu obj);

        ChucVu GetById(Guid id); // tìm sp theo id

        List<ChucVu> GetAll();
        ChucVu Getnamechucvu(string name);
    }
}
