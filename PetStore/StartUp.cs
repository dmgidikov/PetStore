using PetStore.Data;
using PetStore.Data.Models;

namespace PetStore
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            using (var data = new PetStoreDbContext())
            {
                //data.Database.EnsureDeleted();
                //data.Database.EnsureCreated();

                //for (int i = 1; i <= 10; i++)
                //{
                //    var breed = new Breed
                //    {
                //        Name = "Breed " + i,
                //    };

                //    data.Breeds.Add(breed);
                //}

                //data.SaveChanges();

                //for (int i = 1; i <= 30; i++)
                //{
                //    var category = new Category
                //    {
                //        Name = "Category " + i,
                //        Description = "Category description " + i,
                //    };

                //    data.Categories.Add(category);
                //}

                //data.SaveChanges();

                //for (int i = 1; i <= 100; i++)
                //{
                //    var breedId = new Random().Next(1, 10);
                //    var categoryId = new Random().Next(1, 30);


                //    var pet = new Pet
                //    {
                //        DateOfBirth = DateTime.UtcNow.AddDays(-60 + i),
                //        Price = 50 + i,
                //        Gender = (Gender)(i % 2),
                //        Description = "Some random description " + i,
                //        BreedId = breedId,
                //        CategoryId = categoryId
                //    };

                //    data.Pets.Add(pet);
                //}

                //data.SaveChanges();
            }
        }
    }
}

