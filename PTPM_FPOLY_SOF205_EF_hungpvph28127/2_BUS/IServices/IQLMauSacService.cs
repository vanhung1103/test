using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLMauSacService
    {
        List<MauSac> GetAll();
        string Add(MauSac MauSac);
        string Delete(MauSac MauSac);
        string Update(MauSac MauSac);
    }
}
