using Firebase.Database;
using Microsoft.Extensions.Logging;
using SisEdu.Pages;

namespace SisEdu
{
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(new FirebaseClient("https://sisedu-22807-default-rtdb.firebaseio.com/"));

            builder.Services.AddSingleton<LoginStudentView>();
            builder.Services.AddSingleton<LoginStudentViewModel>();

            builder.Services.AddSingleton<LoginTeacherView>();
            builder.Services.AddSingleton<LoginTeacherViewModel>();

            builder.Services.AddSingleton<MainStudentView>();
            builder.Services.AddSingleton<MainStudentViewModel>();

            builder.Services.AddSingleton<MainTeacherView>();
            builder.Services.AddSingleton<MainTeacherViewModel>();

            builder.Services.AddSingleton<CreateTeacherView>();
            builder.Services.AddSingleton<CreateTeacherViewModel>();

            return builder.Build();
        }
    }
}
