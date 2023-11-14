using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistencia.Data;

namespace Aplication.Repositories
{
    public class CountryRepository : GenericRepository<Country>, ICountry
    {
         public readonly ProyectoDotnetContext _context;
        public CountryRepository(ProyectoDotnetContext context) : base(context)
        {
             _context=context;
        }
    }
}