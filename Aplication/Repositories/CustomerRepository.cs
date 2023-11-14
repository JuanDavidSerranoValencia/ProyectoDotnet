using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistencia.Data;

namespace Aplication.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomer
    {
         public readonly ProyectoDotnetContext _context;
        public CustomerRepository(ProyectoDotnetContext context) : base(context)
        {
             _context=context;
        }
    }
}