using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRepositories
{
    public interface IMauSacRepository
    {
        bool Add(MauSac obj);

        bool Update(MauSac obj);

        bool Delete(MauSac obj);

        MauSac GetById(Guid id); // tìm sp theo id
        MauSac GetbyNameMs(string name);
        List<MauSac> GetAll();
    }
}
