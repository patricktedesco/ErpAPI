﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ErpAPI.Models;

public partial class FuncionarioXprojeto
{
    public int Id { get; set; }

    public int IdFuncionario { get; set; }

    public int IdProjeto { get; set; }

    public virtual Funcionario IdFuncionarioNavigation { get; set; }

    public virtual Projeto IdProjetoNavigation { get; set; }
}