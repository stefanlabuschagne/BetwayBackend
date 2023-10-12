using BetwayBackend.Controllers;
using BetwayBackend.Models.Appsettings;
using BetwayBackend.Models.Requests;
using BetwayBackend.Models.Responses;
using BetwayBackend.Service.Appsettings;
using BetwayBackend.Service.AppSettings;
using BetwayBackend.Service.Players;
using Microsoft.Extensions.Configuration;
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
			Assert.Equal(6, result);
		}

		[Fact]
		public void Test2()
		{
			// Arrange
			IPlayerService  PS = new PlayerService();  // List of Valid Players and passwords.
			IAppsettingsService appsettings = new AppsettingsServiceTest();  // Service Returning Test Data for 

			var bc = new BetwayController(null, PS, appsettings);

			var loginRequest = new LoginRequest()
			{
				Email = "Susan.Lee@gmail.com",
				Password = "Syntax100",
			};

			// Act
			var Response = bc.Post(loginRequest);

			// Assert
			Assert.Equal("Success", Response.ToString());
		}
	}
}