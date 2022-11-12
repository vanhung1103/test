using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLNsxService
    {
        List<Nsx> GetAll();
        string Add(Nsx Nsx);
        string Delete(Nsx Nsx);
        string Update(Nsx Nsx);
    }
}
