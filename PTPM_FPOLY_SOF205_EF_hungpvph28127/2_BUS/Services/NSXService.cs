using _1_DAL.DomainClass;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class NSXService : IQLNsxService
    {
        private INsxRepository _insxRepository;
        public NSXService()
        {
           _insxRepository = new NsxRepository();
        }
        public string Add(Nsx Nsx)
        {

            if ( Nsx == null)
            {
                return "Thêm không thành công";
            }

            if (_insxRepository.Add(Nsx)) return "Thêm thành công";
            return "Thêm không thành công";
        }

        public string Delete(Nsx Nsx)
        {
            if (Nsx == null)
            {
                return "Xóa không thành công";
            }

            if (_insxRepository.Delete(Nsx)) return "Xóa thành công";
            return "Xóa không thành công";
        }

        public List<Nsx> GetAll()
        {
            return _insxRepository.GetAll();
        }

        public string Update(Nsx Nsx)
        {
            if (Nsx == null)
            {
                return "Sửa không thành công";
            }

            if (_insxRepository.Update(Nsx)) return "Sửa thành công";
            return "Sửa không thành công";
        }
    }
}
