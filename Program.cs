    using Inventory.Components;
    using Inventory.Service;
    using Inventory.Database;
    using Microsoft.EntityFrameworkCore;
    var builder = WebApplication.CreateBuilder(args);



    // Add services to the container.
    builder.Services.AddRazorComponents()
        .AddInteractiveServerComponents();
    //csdl
    Console.WriteLine("DB path: " + Path.GetFullPath("wims.db"));
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite("Data Source=wims.db"));
    //Dùng dịch vụ productService
    builder.Services.AddSingleton<HandleProduct>();

    var app = builder.Build();
    using (var scope = app.Services.CreateScope())
    {   
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
    }
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }
    app.UseStatusCodePagesWithReExecute("/not-found");
    app.UseHttpsRedirection();

    app.UseAntiforgery();

    app.MapStaticAssets();
    app.MapRazorComponents<App>()
        .AddInteractiveServerRenderMode();

    app.Run();

