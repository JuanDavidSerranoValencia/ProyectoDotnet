using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistencia.Data;

namespace Aplication.Repositories
{
    public class StateRepository : GenericRepository<State>, IState
    {
        public readonly ProyectoDotnetContext _context;
        public StateRepository(ProyectoDotnetContext context) : base(context)
        {
            _context=context;
        }
    }
}