using CatalogoNetflix.WebAPI.Data.Entities;
using CatalogoNetflix.WebAPI.Data.Repositories.Abstractions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoNetflix.WebAPI.Data.Repositories
{
    public class FilmeRepository : Repository<Filme>
    {
        public FilmeRepository(CatalogoContext context, ILogger<Repository<Filme>> logger) : base(context, logger) { }
    }
}
