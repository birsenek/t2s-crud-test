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
    public class RelatorioModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        //injecao de dependencias
        public RelatorioModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Movimentacao> Movimentacoes { get; set; }
        public async Task OnGet()
        {
            Movimentacoes = await _db.Movimentacao.ToListAsync();
        }
    }
}
