﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ErpAPI.Models;

public partial class ClienteXempresa
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdEmpresa { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; }
}