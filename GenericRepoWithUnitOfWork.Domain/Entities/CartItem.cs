using System;
using System.Collections.Generic;

namespace GenericRepoWithUnitOfWork.Domain.Entities;

public partial class CartItem
{
    public int CartItemId { get; set; }

    public int CartId { get; set; }

    public int ProductId { get; set; }
}
