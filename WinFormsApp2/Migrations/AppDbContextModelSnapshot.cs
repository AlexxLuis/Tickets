﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tickets.Data;

#nullable disable

namespace Tickets.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Tickets.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataModificacao")
                        .HasMaxLength(1)
                        .HasColumnType("TEXT");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FuncionarioId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantidade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("FuncionarioId1");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Tickets.Models.Ticket", b =>
                {
                    b.HasOne("Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Funcionario", null)
                        .WithMany("Tickets")
                        .HasForeignKey("FuncionarioId1");

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("Funcionario", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
