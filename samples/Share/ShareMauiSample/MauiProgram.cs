
using Microsoft.Extensions.Logging;
using ShareMauiSample.FacebookControls;

namespace ShareMauiSample;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.RegisterHandlers();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

	private static MauiAppBuilder RegisterHandlers(this MauiAppBuilder builder)
	{
		return builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler(typeof(ShareButton), typeof(ShareButtonHandler));
            handlers.AddHandler(typeof(SendButton), typeof(SendButtonHandler));
        });
	}
}
