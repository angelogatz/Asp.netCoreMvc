using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoCadastroCrudPIM8.Models
{
    public class PessoaContext: DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
