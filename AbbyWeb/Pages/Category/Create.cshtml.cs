using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
                _db=db;
        }

        public RazorCategory category { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost() //It can be done like this but here two instance of RazorCategory are created which causes redundancy. So to prevent that we use [BindProperty]
            {
          
            if (ModelState.IsValid)
            {
                await _db.RazorCategory.AddAsync(category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Successfully Added";
                return RedirectToPage("Category");
            }
            return Page();
        }
    }
}
