using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudT2S.Pages.MovimentacaoList
{
  
        public class EditModel : PageModel
        {
            private readonly ApplicationDbContext _db;

            public EditModel(ApplicationDbContext db)
            {
                _db = db;
            }

            [BindProperty]
            public Movimentacao Movimentacao { get; set; }
            public async Task OnGet(int id)
            {
                Movimentacao = await _db.Movimentacao.FindAsync(id);
            }

            public async Task<IActionResult> OnPost()
            {
                if (ModelState.IsValid)
                {
                    var MovimentacaoFromDb = await _db.Movimentacao.FindAsync(Movimentacao.ID);
                    MovimentacaoFromDb.Navio = Movimentacao.Navio;
                    MovimentacaoFromDb.TipoMovimentacao = Movimentacao.TipoMovimentacao;
                    MovimentacaoFromDb.DataInicio = Movimentacao.DataInicio;
                    MovimentacaoFromDb.DataFim = Movimentacao.DataFim;
                    
                    await _db.SaveChangesAsync();
                    return RedirectToPage("Index");
                }

                return RedirectToPage();
            }
        }
    }

