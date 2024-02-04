using PetStore.Services.Models.Category;
using System.Collections.Generic;

namespace PetStore.Services
{
    public interface ICategoryService
    {
        void Create(CreateCategoryServiceModel model);

        void Edit(EditCategoryServiceModel model);

        bool Remove(int id);

        bool Exists(int categoryId);

        DetailsCategoryServiceModel GetById(int id);

        IEnumerable<AllCategoriesServiceModel> All(int page = 1);

        public int Total();
    }
}
