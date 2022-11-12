using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IDongspService
    {
        List<DongSp> GetAll();
        string Add(DongSp DongSp);
        string Delete(DongSp DongSp);
        string Update(DongSp DongSp);
    }
}
