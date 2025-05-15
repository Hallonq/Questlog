using Questlog.Web.Services;

namespace Questlog.Web;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddSingleton<QuestlogService>();
        var app = builder.Build();
        app.MapControllers();
        app.Run();
    }
}
