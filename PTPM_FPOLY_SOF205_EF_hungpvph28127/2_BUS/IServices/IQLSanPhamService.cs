using _1_DAL.Context;
using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IQLSanPhamService
    {
        
        string Add(SanPhamView obj);

        string Update(SanPhamView obj);

        string Delete(SanPhamView obj);
       
        List<SanPhamView> GetAll();
        SanPham GetNameSp(string text);
        DongSp GetNameDsp(string name);
        Nsx GetNameNsx(string text);
        MauSac GetNameMs(string text);
        List<MauSac> GetAllMau();
        List<DongSp> GetAllDongsp();
        List<Nsx> GetAllNsx();
        public List<SanPham> GetAllSanPham();
    }
}
