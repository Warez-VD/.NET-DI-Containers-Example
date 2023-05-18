using Built_In_DI_Container.Services.Interfaces;

namespace Built_In_DI_Container.Services
{
	public class DateService : IDateService
	{
		public DateTime Now()
		{
			return DateTime.UtcNow;
		}
	}
}
