using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentisoftEntities.Entities;
using DentalsoftDAL;
namespace CustomerBLL
{
    public class ZonaDLL
    {
        public Zona[] GetAll()
        {
            ZonaDal CusDAL = new ZonaDal();
            return CusDAL.GetALL();
        }
        public Zona GetById(int id)
        {
            ZonaDal CusDAL = new ZonaDal();
            return CusDAL.GetByID(id);
        }

        public void Insert(Customer cus)
        {
            ZonaDal CusDAL = new ZonaDal();
        }

        public void Update(Customer cus, int id)
        {
            ZonaDal CusDAL = new ZonaDal();
            CusDAL.Update( id,cus);
        }

         public void Delete(int id)
        {
            ZonaDal CusDAL = new ZonaDal();
            CusDAL.Delete(id);
        }
    }
}
