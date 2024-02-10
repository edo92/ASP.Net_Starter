using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var seed = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (seed == null)
                {
                    throw new Exception("Seed is null");
                }
                SeedData(seed);
            }
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Platforms.AddRange(
                    new Platform() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new Platform() { Name = "Kubernetes", Publisher = "Cloud Native", Cost = "Free" }
                );

                context.SaveChanges();
            }
            Console.WriteLine("Already have data - not seeding.");
        }
    }
}