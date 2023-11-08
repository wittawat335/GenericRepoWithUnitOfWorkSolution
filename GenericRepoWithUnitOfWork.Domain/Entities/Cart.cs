using System;
using System.Collections.Generic;

namespace GenericRepoWithUnitOfWork.Domain.Entities;

public partial class Cart
{
    public int CartId { get; set; }

    public int UserId { get; set; }

    public string Ordered { get; set; } = null!;

    public string OrderedOn { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
