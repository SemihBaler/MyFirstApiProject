using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Tinsert(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetlist();
        T TGetById(int id);
    }
}
