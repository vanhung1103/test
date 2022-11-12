using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLChucVuService
    {
        List<ChucVu> GetAll();
        string Add(ChucVu chucvu);
        string Delete(ChucVu chucvu);
        string Update(ChucVu chucvu);
        ChucVu Getnamechucvu(string name);
        ChucVu GetById(Guid id);
    }
}
