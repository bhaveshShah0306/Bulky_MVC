using BulkyBookBookWebRazor_Temp.Data;
using BulkyBookBookWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyBookBookWebRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly RazorApplicationDbContext _db;
        [BindProperty]
        public Category Category { get; set; }
        public CreateModel(RazorApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("/Categories/Index");
        }
    }
}
