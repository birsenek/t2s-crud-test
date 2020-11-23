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
    public class RelatorioModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        //injecao de dependencias
        public RelatorioModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Container> Containers { get; set; }
        public async Task OnGet()
        {
            Containers = await _db.Container.ToListAsync();
        }

    }
}
