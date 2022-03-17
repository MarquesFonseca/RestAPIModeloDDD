using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIModeloDDD.Infrastructure.CrossCutting.IOC
{
    public class Infrastructure_CrossCutting_IOC_ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder buider)
        {
            Infrastructure_CrossCutting_IOC_ConfigurationIOC.Load(buider);
        }
    }
}
