using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class PersonType:BaseEntity
{
    public string Name { get; set; } = null!;

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
