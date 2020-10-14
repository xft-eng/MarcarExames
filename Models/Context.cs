using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DesafioASP.Models
{
    public class Context : DbContext
    {
       public Context(): base("Context")
        {

        }
        // public Context(DbContextOptions<Context> options) : base(options)
        public IDbSet<Paciente> Pacientes { get; set; }
        public IDbSet<TipoExame> TipoExames { get; set; }
        public IDbSet<CadastroExame> CadastroExames { get; set; }

    }
}