﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dispatcher;
using System.Reflection;
using DentisoftAPI.Controllers;

namespace DentisoftUI.App_Start
{
    public class CustomAssemblyResolver : IAssembliesResolver
    {
        public ICollection<Assembly> GetAssemblies()
        {
            List<Assembly> baseAssemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();
            var controllersAssembly = Assembly.LoadFrom(@"DentisoftAPI.dll");
            baseAssemblies.Add(controllersAssembly);
            return baseAssemblies;
        }
    }
}