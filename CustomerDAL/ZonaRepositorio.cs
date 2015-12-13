using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentisoftEntities.Entities;

namespace DentisoftRepository
{
    public class ZonaRepositorio:BaseEntities
    {
        public Zona[] GetALL()
        {
            return _entities.Zona.ToArray();
        }

        public Zona GetByID(int id)
        {
            ///TECNIDENTEntities ctx = new TECNIDENTEntities();
            //return ctx.Zona.Where(c => c.Id == id).ToArray()[0] as Zona;
            return new Zona();
        }

        public bool Insert(Zona cus)
        {
            try
            {
                _entities.Zona.Add(cus);
                _entities.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int id, Zona _zona)
        {
            try
            {
                //using (TECNIDENTEntities ctx = new TECNIDENTEntities())
                //{
                //    var _ob = ctx.Zona.SingleOrDefault(b => b.Id == id);
                //    if (_ob != null)
                //    {
                //        _ob.Nombre = _zona.Nombre.Trim();
                //        _ob.Codigo = _zona.Codigo.Trim();
                //        _ob.CuidadId = _zona.CuidadId;
                //        _ob.estado = _zona.estado;
                //        ctx.SaveChanges();
                //    }
                //}

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                //using (TECNIDENTEntities ctx = new TECNIDENTEntities())
                //{
                //    var _ob = ctx.Zona.SingleOrDefault(b => b.Id == id);
                //    if (_ob != null)
                //    {
                //        ctx.Zona.Remove(_ob);
                //        ctx.SaveChanges();
                //    }
                //}

                return true;

            }
            catch
            {
                return false;
            }

        }

    }
}
