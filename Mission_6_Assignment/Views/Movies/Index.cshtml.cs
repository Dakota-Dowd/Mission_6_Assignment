using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Mission_6_Assignment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mission_6_Assignment.Views.Movies
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public List<Movie> Movies { get; set; }

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies
                .Include(m => m.Category)
                .ToListAsync();
        }
    }
}
