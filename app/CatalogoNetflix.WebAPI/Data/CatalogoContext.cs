using CatalogoNetflix.WebAPI.Data.Entities;
using CatalogoNetflix.WebAPI.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Data
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext(DbContextOptions<CatalogoContext> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new FilmeMap());
        }
    }
}
