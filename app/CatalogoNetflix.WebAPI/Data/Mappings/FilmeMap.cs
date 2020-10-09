using CatalogoNetflix.WebAPI.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Data.Mappings
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(x => x.Id);

            
        }
    }
}
