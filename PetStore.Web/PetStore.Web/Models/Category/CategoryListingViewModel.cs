namespace PetStore.Web.Models.ViewModels
{
    public class CategoryListingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Total { get; set; }

        public int CurrentPage { get; set; }

        public int PreviousPage => this.CurrentPage - 1;

        public int NextPage => this.CurrentPage + 1;
    }
}
