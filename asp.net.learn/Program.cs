using System.Text;
//WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
//WebApplication app = builder.Build();

////app.MapGet("/", () => "Hello World!");
////app.Run();

////int x = 2;
////app.Run(async (context) =>
////{
////    x = x * 2;
////    await context.Response.WriteAsync(x.ToString());
////}
////);

//int x = 2;
//app.Run(HandleRequest);
//async Task HandleRequest(HttpContext context)
//{
//    x = x * 2;
//    await context.Response.WriteAsync(x.ToString());
//}

//app.Run();



WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();
//// получить “екст
//app.Run(async (context) =>
//{
//    var response = context.Response;
//    context.Response.StatusCode = 200;
//    response.ContentType = "text/plain; charset=utf-8";   
//    response.Headers.ContentLanguage = "ru-RU";   
//    response.Headers.Add("add" ,"222");
//    response.Headers.Append("secret-id", "256");
//    var temp = response.ContentType == response.Headers.ContentType;
//    await response.WriteAsync("noHtml -> Hello World!  ѕривет мир"); 
//});


//// получить HTML
//app.Run(async (context) =>
//{
//    var response = context.Response;
//    response.ContentType = "text/html; charset=utf-8";
//    await response.WriteAsync("<h2>Hello METANIT.COM</h2><h3>Welcome to ASP.NET Core</h3>");
//});

// получить HeadersRequest в html формате
//app.Run(async (context) =>
//{
//    context.Response.ContentType = "text/html; charset=utf-8";
//    context.Response.Headers.Append("secretPassword", "999000");
//    var stringBuilder = new StringBuilder("<table>");
//    foreach (var header in context.Request.Headers)
//    {
//        stringBuilder.Append($"<tr>" +
//                                  $"<td>" +
//                                     $"{header.Key}" +
//                                  $"</td>" +
//                                  $"<td>" +
//                                     $"{header.Value}" +
//                                  $"</td>" +
//                             $"</tr>");
//    }
//    stringBuilder.Append("</table>");
//    await context.Response.WriteAsync(stringBuilder.ToString());
//}
//);

// получить ACEPT HEADER и свой кастомный хедер
//app.Run(async (context) =>
//{
//    String acceptRequest = context.Request.Headers.Accept;
//    context.Response.Headers.Append("secret", "222");
//    context.Request.Headers.Append("secretRequst", "222"); // в реквест не добавл€ютс€ хедеры
//    String secretresponce = context.Response.Headers["secret"];

//    // ¬ызывать только после всех изменений иначе будет ошибка
//    await context.Response.WriteAsync(secretresponce);
//    await context.Response.WriteAsync(acceptRequest);
//});

// получить енд поинт запроса и создание ссылок
//app.Run(async (context) =>
//{
//    String path = context.Request.Path;
//    var now = DateTime.Now;
//    context.Response.Headers.ContentType = "text/html; charset=utf-8";

//    if (path == "/test")
//    {
//        await context.Response.WriteAsync($"TEST PAGE<br>Path: {context.Request.Path}");
//    }
//    else if (path == "/date")
//    {
//        await context.Response.WriteAsync($"Date: {now.ToShortDateString()}");

//    }
//    else if(path == "/time")
//    {       
//        await context.Response.WriteAsync($"Time: {now.ToShortTimeString()}");
//    }
//    else
//    {
//        await context.Response.WriteAsync($"Hello world<br>Path: {context.Request.Path}");
//    }
//}
//);

// получение параметров(аргументов) после ? в ендпоинта(передача аргументов другой странице)
// page3000?name=Tom&age=37
//app.Run(async (context) =>
//{
//    context.Response.Headers.ContentType = "text/html; charset=utf-8";
//    await context.Response.WriteAsync(
//        $"<p>{context.Request.Path}</p>" +
//        $"<p>QueryArguments: {context.Request.QueryString}</p>"
//        );

//});

// получение параметров(аргументов) после? в ендпоинта(передача аргументов другой странице)
// + HTML генераци€ странички
//app.Run(async (context)=>
//{
//    context.Response.ContentType = "text/html; charset=utf-8";

//    StringBuilder stringBuilder = new StringBuilder("<h3>ѕараметры строки запроса</h3><table>");
//    stringBuilder.Append("<tr><td>ѕараметр</td><td>«начение</td></tr>");
//    foreach(var arg in context.Request.Query)
//    {
//        stringBuilder.Append($"<tr><td>{arg.Key}</td><td>{arg.Value}</td></tr>");
//    }
//    stringBuilder.Append("</table>");
//    await context.Response.WriteAsync(stringBuilder.ToString());
//});

// поиск параметров по Heshcode
//app.Run(async context =>
//{
//    String name = context.Request.Query["name"];
//    String age = context.Request.Query["age"];
//    await context.Response.WriteAsync($"{name} - {age}");
//});


app.Run();