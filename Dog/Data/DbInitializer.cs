using Dog.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Dog.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            context.Database.EnsureCreated();

            // Seed the dog if none exists
            if (!await context.Dogs.AnyAsync())
            {
                var dog = new DogProfile
                {
                    Name = "Max",
                    Breed = "Golden Retriever",
                    Age = 3,
                    ImageUrl = "https://placedog.net/800/600?random=1",
                    MainDescription = "Hi! I'm Max, a friendly and energetic Golden Retriever. I love playing fetch and making new friends. My favorite thing in the world is belly rubs and swimming in the lake!",
                    DetailedDescription = "I was born on April 15, 2020 and joined my forever family when I was just 8 weeks old. I've been bringing joy and laughter to my household ever since. I'm trained in basic obedience and know commands like sit, stay, come, and shake. I'm also a certified therapy dog and visit the local children's hospital once a month to spread cheer.",
                    FavoriteFood = "Peanut butter stuffed Kongs",
                    FavoriteToy = "Bright orange tennis ball",
                    SpecialSkills = "I can catch treats mid-air, open doors with my nose, and I know how to 'speak' on command (but only when asked nicely!)."
                };

                context.Dogs.Add(dog);
                await context.SaveChangesAsync();
            }

            // Optional: Seed admin user
            if (await userManager.FindByEmailAsync("admin@dog.com") == null)
            {
                var user = new IdentityUser { UserName = "admin@dog.com", Email = "admin@dog.com" };
                await userManager.CreateAsync(user, "Dog123!");
            }
        }
    }
}