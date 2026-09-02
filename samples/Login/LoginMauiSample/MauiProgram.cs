
using LoginMauiSample.Controls;
using Microsoft.Extensions.Logging;

namespace LoginMauiSample;

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
            handlers.AddHandler(typeof(LoginButton), typeof(LoginButtonHandler));
            handlers.AddHandler(typeof(LoginTooltipView), typeof(LoginTooltipViewHandler));
            handlers.AddHandler(typeof(ProfilePictureView), typeof(ProfilePictureViewHandler));
        });
	}
}
