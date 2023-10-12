using BetwayBackend.Controllers;
using BetwayBackend.Service.Appsettings;
using BetwayBackend.Service.AppSettings;
using BetwayBackend.Service.Players;
using Microsoft.Extensions.Logging;

namespace BetwayTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			// Arrange
			int a = 2;
			int b = 3;

			// Act
			int result = a + b;

			// Assert
			Assert.Equal(5, result);
		}

		public void GetAppSettings()
		{
			// Arrange
			IPlayerService  PS = new PlayerService();  // List of Valid Players and passwords.
			IAppsettingsService appsettings = new AppsettingsService();
		
			//ILogger daLogger = new Logger();

			//var bc = new BetwayController(daLogger, PS, appsettings);

			// var bcAppsettings = bc.GetAppSettings();

			// Act
			int result = 5;

			// Assert
			Assert.Equal(5, result);
		}



	}
}