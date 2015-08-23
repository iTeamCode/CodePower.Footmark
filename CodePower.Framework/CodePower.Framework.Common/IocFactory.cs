using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace CodePower.Framework.Common
{
    /// <summary>
    /// Ioc Container
    /// </summary>
    public static class IocFactory
    {
        static IocFactory()
        {
            RegisterComponents();
        }

        /// <summary>
        /// save the Ioc information.
        /// </summary>
        private static WindsorContainer _container;
        public static WindsorContainer Container
        {
            get { return _container; }
            set { _container = value; }
        }
        /// <summary>
        /// Register Components to '_container'
        /// </summary>
        private static void RegisterComponents()
        {
            var container = new WindsorContainer();

            container.Register(Component
                .For<IWindsorContainer>()
                .Instance(container));

            #region register data visitor.
            Assembly asmDataAccess = Assembly.Load("CodePower.Footmark.DataAccess");

            //ActivityDataVisitor
            container.Register(Component
                .For(asmDataAccess.GetType("CodePower.Footmark.DataAccess.IActivityDataVisitor"))
                .ImplementedBy(asmDataAccess.GetType("CodePower.Footmark.DataAccess.ActivityDataVisitor"))
                .Named("ActivityDataVisitor"));

            //ProjectDataVisitor
            container.Register(Component
                .For(asmDataAccess.GetType("CodePower.Footmark.DataAccess.IProjectDataVisitor"))
                .ImplementedBy(asmDataAccess.GetType("CodePower.Footmark.DataAccess.ProjectDataVisitor"))
                .Named("ProjectDataVisitor"));

            //UserDataVisitor
            container.Register(Component
                .For(asmDataAccess.GetType("CodePower.Footmark.DataAccess.IUserDataVisitor"))
                .ImplementedBy(asmDataAccess.GetType("CodePower.Footmark.DataAccess.UserDataVisitor"))
                .Named("UserDataVisitor"));
            #endregion register data access.

            _container = container;
        }

        /// <summary>
        /// create object
        /// </summary>
        /// <typeparam name="T">object type</typeparam>
        /// <returns></returns>
        public static T CreateObject<T>(string key)
        {
            return _container.Resolve<T>(key);
        }

        public static T CreateObject<T>()
        {
            return _container.Resolve<T>();
        }

    }  
}
