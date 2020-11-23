using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudT2S.Controllers
{
    [Route("api/Movimentacao")]
    [ApiController]
    public class MovimentacaoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MovimentacaoController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Json(new { 

                data = await _db.Movimentacao.ToListAsync() 
            
            });
        }
    }
}
