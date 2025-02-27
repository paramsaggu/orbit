﻿using AirHockey.GameObjects;
using AirHockey.Scenes;
using Orbit.Engine;

namespace AirHockey;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
            .UseMauiApp<App>()
            .UseOrbitEngine()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .Services
                .AddTransient<MainPage>()
                .AddTransient<PlayerStateManager>()
                .AddSingleton(HapticFeedback.Default)
                .AddSingleton(Vibration.Default)
                .RegisterGameObjects()
                .RegisterScenes();

        return builder.Build();
	}
}
