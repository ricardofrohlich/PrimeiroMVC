using System;
using System.Collections.Generic;

namespace PrimeiroMVC.Models;

public partial class Email
{
    public int Id { get; set; }

    public string? Email1 { get; set; }

    public int? Pessoaid { get; set; }

    public virtual Pessoa? Pessoa { get; set; }
}
