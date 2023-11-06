using AbbyWeb.Data;
using AbbyWeb.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Category
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
                _db=db;
        }

        public RazorCategory category { get; set; }
        public void OnGet(int id )
        {
           category = _db.RazorCategory.Find(id);
        }
        public async Task<IActionResult> OnPost() //It can be done like this but here two instance of RazorCategory are created which causes redundancy. So to prevent that we use [BindProperty]
        {
            if (ModelState.IsValid)
            {
                _db.RazorCategory.Remove(category);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Data Successfully Deleted";
                return RedirectToPage("Category");
            }
            return Page();
        }
    }
}
