﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ErpAPI.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string Cpf { get; set; }

    public string Cnpj { get; set; }

    public string Nome { get; set; }

    public string Endereco { get; set; }

    public string Telefone { get; set; }

    public virtual ICollection<ClienteXempresa> ClienteXempresas { get; set; } = new List<ClienteXempresa>();

    public virtual ICollection<Projeto> Projetos { get; set; } = new List<Projeto>();
}