using System;
using System.Collections.Generic;

namespace PrimeiroMVC.Models;

public partial class Pessoa
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
