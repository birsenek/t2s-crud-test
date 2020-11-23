using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudT2S.Model
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public ApplicationDbContext()
        {
        }

        public DbSet<Container> Container { get; set; }


        public DbSet<Movimentacao> Movimentacao { get; set; }


        internal static object FromSqlRaw(string v)
        {
            
            throw new NotImplementedException();
        }

       
    }
}
