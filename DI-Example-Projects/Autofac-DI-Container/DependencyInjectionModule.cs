using Autofac;
using Autofac_DI_Container.Services;
using Autofac_DI_Container.Services.Interfaces;

namespace Autofac_DI_Container
{
	public class DependencyInjectionModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			// Match Scoped scope in .NET Built In DI Container
			builder.RegisterType<DateService>().As<IDateService>().InstancePerLifetimeScope();

			// Match Transient scope in .NET Built In DI Container
			// builder.RegisterType<DateService>().As<IDateService>().InstancePerDependency();

			// Match Singleton scope in .NET Built In DI Container
			// builder.RegisterType<DateService>().As<IDateService>().SingleInstance();
		}
	}
}
