using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Xml;
using System.Reflection;
using DentisoftEntities.Entities;

namespace DentisoftRepository
{
    public class BaseEntities
    {
        public TECNIDENTEntities1 _entities;
       
        public BaseEntities()
        {
            _entities = new TECNIDENTEntities1();
        }

    }
}
