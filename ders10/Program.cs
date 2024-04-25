using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

//MVC ayarlamaları
builder.Services.AddMvc();
builder.Services.AddRazorPages();//

var app = builder.Build();
//controllerdaki Index IActionResult çalıştırara view deki Index.cshtml gösterdi
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}" 
    );



//app.MapControllerRoute(name: "default",
//    pattern: "{controller=Home}/{action=Sum}"
//    );



//app.MapGet("/", () =>
//{
//    var a = 4;
//    var b = 5;
//    var sum = a + b;
//    return sum.ToString();
//});

app.Run();
