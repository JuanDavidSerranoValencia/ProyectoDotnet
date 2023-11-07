﻿using System;
using System.Collections.Generic;

namespace Persistencia.Entities;

public partial class PersonType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}