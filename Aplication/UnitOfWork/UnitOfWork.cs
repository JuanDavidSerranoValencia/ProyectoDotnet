using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repositories;
using Domain.Interfaces;
using Persistencia.Data;

namespace Aplication.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ProyectoDotnetContext _context;

        private ICity _citys { get; set; }

        private ICountry _countrys { get; set; }

        private ICustomer _customers { get; set; }

        private IPersonType _personTypes { get; set; }

        private IState _states { get; set; }

        public ICity Citys
        {
            get
            {
                if (_citys == null)
                {
                    _citys = new CityRepository(_context);
                }
                return _citys;
            }

        }
        public ICountry Countrys
        {
            get
            {
                if (_countrys == null)
                {
                    _countrys = new CountryRepository(_context);
                }
                return _countrys;
            }

        }
        public ICustomer Customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = new CustomerRepository(_context);
                }
                return _customers;
            }

        }

        public IPersonType PersonTypes
        {
            get
            {
                if (_personTypes == null)
                {
                    _personTypes = new PersonRepository(_context);
                }
                return _personTypes;
            }

        }
        
        public IState States
        {
            get
            {
                if (_states == null)
                {
                    _states = new StateRepository(_context);
                }
                return _states;
            }

        }



        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}