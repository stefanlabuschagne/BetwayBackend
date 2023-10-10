using BetwayBackend.Service.Appsettings;
using BetwayBackend.Service.AppSettings;
using BetwayBackend.Service.Players;

namespace BetwayBackend
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddSingleton<IPlayerService, PlayerService>(); // DI for Valid Player Credentials
			builder.Services.AddSingleton<IAppsettingsService, AppsettingsService>();

			// Add services to the container.
			builder.Services.AddControllers();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();

			app.MapControllers();

			app.Run();
		}
	}
}