namespace PetStore.Web
{
    using Data;
    using Services;
    using Services.Implementations;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<PetStoreDbContext>();
            
            builder.Services.AddTransient<IPetService, PetService>();
            builder.Services.AddTransient<IBreedService, BreedService>();
            builder.Services.AddTransient<IUserService, UserService>();
            builder.Services.AddTransient<ICategoryService, CategoryService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
