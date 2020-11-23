using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrudT2S.Pages.MovimentacaoList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        //injecao de dependencias
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
        public async Task OnGet()
        {
            Movimentacoes = await _db.Movimentacao.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var movimentacao = await _db.Movimentacao.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound();
            }
            _db.Movimentacao.Remove(movimentacao);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
