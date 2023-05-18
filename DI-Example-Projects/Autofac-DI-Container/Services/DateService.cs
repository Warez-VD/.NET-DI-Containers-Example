using Autofac_DI_Container.Services.Interfaces;

namespace Autofac_DI_Container.Services
{
	public class DateService : IDateService
	{
		public DateTime Now()
		{
			return DateTime.UtcNow;
		}
	}
}
