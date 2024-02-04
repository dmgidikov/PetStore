namespace PetStore.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using Services;
    using Models.Category;
    using Models.ViewModels;
    using PetStore.Services.Models.Category;
    using PetStore.Web.Models.Pet;

    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryServices)
        {
            _categoryService = categoryServices;
        }

        public IActionResult All(int page = 1)
        {
            var allCategories = this._categoryService.All(page);
            var totalCategories = this._categoryService.Total();

            var categories = _categoryService
               .All()
               .Select(x => new CategoryListingViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   CurrentPage = page
               })
               .ToArray();

            return this.View(categories);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.RedirectToAction("Error", "Home");
            }

            var categoryServiceModel = new CreateCategoryServiceModel()
            {
                Name = model.Name,
                Description = model.Description,
            };

            this._categoryService.Create(categoryServiceModel);

            return this.RedirectToAction("All", "Categoris");
        }
    }
}
