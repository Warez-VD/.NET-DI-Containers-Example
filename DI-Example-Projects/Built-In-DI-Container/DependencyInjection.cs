using Built_In_DI_Container.Services;
using Built_In_DI_Container.Services.Interfaces;

namespace Built_In_DI_Container
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
			services.AddScoped<IDateService, DateService>();

			// Example how you could register as different scope:
			// services.AddTransient<IDateService, DateService>();
			// services.AddSingleton<IDateService, DateService>();

			return services;
		}
	}
}
