﻿namespace GearErrorHelper;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("MaterialIcons-Regular.ttf", "GoogleMaterialFont");
			});

		builder.Services.AddSingleton<HomeViewModel>();
		builder.Services.AddSingleton<InternalErrorViewModel>();
		builder.Services.AddSingleton<BoschErrorViewModel>();

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<InternalErrorPage>();
		builder.Services.AddSingleton<BoschErrorPage>();

		return builder.Build();
	}
}
