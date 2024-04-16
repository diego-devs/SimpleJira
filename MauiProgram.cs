using Microsoft.Extensions.Logging;

namespace SimpleJira;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddScoped<HttpClient>(s =>
		{
			var httpClient = new HttpClient();
			// configure httpclient options here if needed
			return httpClient;
		});
		builder.Services.AddScoped<JiraAuth>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();

#endif

		return builder.Build();
	}
}
