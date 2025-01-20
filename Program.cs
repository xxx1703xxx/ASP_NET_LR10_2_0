var builder = WebApplication.CreateBuilder(args);

// Додаємо необхідні сервіси
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Налаштування маршрутизації для сторінки реєстрації
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Consultation}/{action=Register}/{id?}");

app.Run();
