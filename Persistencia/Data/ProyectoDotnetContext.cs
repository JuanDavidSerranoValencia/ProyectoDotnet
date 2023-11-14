using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System.Reflection;


namespace Persistencia.Data;

public partial class ProyectoDotnetContext : DbContext
{

    public DbSet<City> Cities { get; set; }

    public DbSet<Country> Countries { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<PersonType> PersonTypes { get; set; }

    public DbSet<State> States { get; set; }

    public ProyectoDotnetContext(DbContextOptions<ProyectoDotnetContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }


}
