using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission_6_Assignment.Models;
using System.Threading.Tasks;

namespace Mission_6_Assignment.Views.Movies
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movie = await _context.Movies.FindAsync(id);
            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(Movie);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Movies/Index");
        }
    }
}
