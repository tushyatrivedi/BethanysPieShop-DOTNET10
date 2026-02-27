namespace BethanysPieShop_DOTNET10.Models
{
    public static class DataSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            context.Database.EnsureCreated();

            if (!context.Pies.Any())
            {
                context.Pies.AddRange(StaticPieData.GetAll());
                context.SaveChanges();
            }
        }
    }
}
