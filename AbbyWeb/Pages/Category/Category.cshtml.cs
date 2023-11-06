using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category
{
    public class CategoryModel : PageModel
    {
        public IEnumerable<RazorCategory> Category;

        private readonly ApplicationDbContext _db;
        public CategoryModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Category = _db.RazorCategory;
        }
    }
}
