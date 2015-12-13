using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;


namespace DentisoftAPI
{
    public class SetupController
    {
        public static void Setup()
        {
            SetupControllers();
        }
        private static void SetupControllers()
        {
            ControllerBuilder.Current.DefaultNamespaces.Add("DentisoftAPI.Controllers");
            ControllerBuilder.Current.DefaultNamespaces.Add("DentisoftUI.Controllers");
            
        }



    }

}
