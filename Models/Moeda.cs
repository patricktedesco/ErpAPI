﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ErpAPI.Models;

public partial class Moeda
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public int IdPais { get; set; }

    public virtual Pais IdPaisNavigation { get; set; }
}