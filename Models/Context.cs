using Microsoft.EntityFrameworkCore;
using RtoNR.Models;

namespace RtoNR.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options){

        }
        public DbSet<Registro> Registros {get;set;}
        public DbSet<RegistroNR> RegistrosNR {get;set;}
    }
}