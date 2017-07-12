using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Autofac;
using CodeBase.Model;

namespace CodeBase.Modules
{
    

    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
         
            builder.RegisterType(typeof(CodeBaseContext)).As(typeof(IContext)).InstancePerLifetimeScope();                 

        }

    }
}