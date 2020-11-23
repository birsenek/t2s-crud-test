using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudT2S.Pages.ContainerList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Container Container { get; set; }
        public async Task OnGet(int id)
        {
            Container = await _db.Container.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ContainerFromDb = await _db.Container.FindAsync(Container.Id);
                ContainerFromDb.Cliente = Container.Cliente;
                ContainerFromDb.NumeroContainer = Container.NumeroContainer;
                ContainerFromDb.Tipo = Container.Tipo;
                ContainerFromDb.Status = Container.Status;
                ContainerFromDb.Categoria = Container.Categoria;

                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }

            return RedirectToPage();
        }
    }
}
