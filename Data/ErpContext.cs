﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ErpAPI.Models;

public partial class ErpContext : DbContext
{
    public ErpContext(DbContextOptions<ErpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteXempresa> ClienteXempresas { get; set; }

    public virtual DbSet<Conta> Contas { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<FuncionarioXprojeto> FuncionarioXprojetos { get; set; }

    public virtual DbSet<Moeda> Moedas { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Projeto> Projetos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bancos__3213E83F7FBD25AB");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83F54D18D87");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.Cpf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cpf");
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<ClienteXempresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ClienteX__3213E83F919B0479");

            entity.ToTable("ClienteXEmpresa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.ClienteXempresas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_ClienteXEmpresa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ClienteXempresas)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_ClienteXEmpresa");
        });

        modelBuilder.Entity<Conta>(entity =>
        {
            entity.HasKey(e => e.Numero).HasName("PK__Contas__FC77F2103DF1171F");

            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.IdBanco).HasColumnName("id_banco");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

            entity.HasOne(d => d.IdBancoNavigation).WithMany(p => p.Conta)
                .HasForeignKey(d => d.IdBanco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_banco_conta");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Conta)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_conta");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresas__3213E83F2391C9C7");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("endereco");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefone");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdPais)
                .HasConstraintName("FK_pais_empresa");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Funciona__3213E83F0B031B90");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cargo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cargo");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.IdEmpresa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_empresa_funcionario");
        });

        modelBuilder.Entity<FuncionarioXprojeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Funciona__3213E83F866FCB9B");

            entity.ToTable("FuncionarioXProjeto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFuncionario).HasColumnName("id_funcionario");
            entity.Property(e => e.IdProjeto).HasColumnName("id_projeto");

            entity.HasOne(d => d.IdFuncionarioNavigation).WithMany(p => p.FuncionarioXprojetos)
                .HasForeignKey(d => d.IdFuncionario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_funcionario_FuncionarioXProjeto");

            entity.HasOne(d => d.IdProjetoNavigation).WithMany(p => p.FuncionarioXprojetos)
                .HasForeignKey(d => d.IdProjeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_projeto_FuncionarioXProjeto");
        });

        modelBuilder.Entity<Moeda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Moedas__3213E83FEB8572A5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdPais).HasColumnName("id_pais");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");

            entity.HasOne(d => d.IdPaisNavigation).WithMany(p => p.Moeda)
                .HasForeignKey(d => d.IdPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_pais_moeda");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pais__3213E83F3CE2411A");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Projetos__3213E83FC832A6E6");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Fim).HasColumnName("fim");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Inicio).HasColumnName("inicio");
            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Projetos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cliente_projeto");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}