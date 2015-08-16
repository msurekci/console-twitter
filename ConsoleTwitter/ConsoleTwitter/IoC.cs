using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTwitter.Actions;
using ConsoleTwitter.Interfaces;
using Ninject;
using Ninject.Modules;

namespace ConsoleTwitter
{
    public class IoC : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IPublish>().To<Publish>();
            this.Bind<IReading>().To<Reading>();
            this.Bind<IFollow>().To<Follow>();
            this.Bind<IWall>().To<Wall>();
            this.Bind<IUserList>().To<UserList>();
        }
    }
}
