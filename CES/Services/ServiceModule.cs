using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Module = Autofac.Module;

namespace CES.Services
{
	public class ServiceModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			var types = typeof(ServiceModule).GetTypeInfo().Assembly.GetTypes();

			// register services
			builder.RegisterTypes(types)
				.Where(t => t.Namespace != null && t.Namespace.Contains(nameof(Services)))
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}
	}
}
