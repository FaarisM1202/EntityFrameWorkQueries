using System;
using System.Collections.Generic;

namespace EntityFrameWorkQueries.Models;

public partial class Glaccount
{
    public int AccountNo { get; set; }

    public string AccountDescription { get; set; } = null!;

    public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; } = new List<InvoiceLineItem>();

    public virtual ICollection<Vendor> Vendors { get; } = new List<Vendor>();
}
