using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrudT2S.Pages.ContainerList
{

    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        //injecao de dependencias
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }


    public IEnumerable<Container> Containers { get; set; }
        public async Task OnGet()
        {
            Containers = await _db.Container.ToListAsync();
            
        }

        public class SampleContext : DbContext
        {
            public DbSet<Container> Containers { get; set; }
        }
          
    
        
        
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var container = await _db.Container.FindAsync(id);
            if (container == null)
            {
                return NotFound();
            }
            _db.Container.Remove(container);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}
