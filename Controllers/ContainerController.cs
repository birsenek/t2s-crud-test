using CrudT2S.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudT2S.Controllers
{
    [Route("api/Container")]
    [ApiController]
    public class ContainerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContainerController(ApplicationDbContext db)
        {
            _db = db;
        }

        //retornar a lista de containers

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Container.ToListAsync() });
        }

  

    }
}
