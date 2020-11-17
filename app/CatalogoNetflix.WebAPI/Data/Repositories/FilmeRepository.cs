using CatalogoNetflix.WebAPI.Data.Entities;
using CatalogoNetflix.WebAPI.Data.Repositories.Abstractions;
using Microsoft.Extensions.Logging;

namespace CatalogoNetflix.WebAPI.Data.Repositories
{
    public class FilmeRepository : Repository<Filme>
    {
        public FilmeRepository(CatalogoContext context, ILogger<Repository<Filme>> logger) : base(context, logger) { }
    }
}
