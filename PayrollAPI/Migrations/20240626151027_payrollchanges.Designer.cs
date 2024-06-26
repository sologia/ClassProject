﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayrollAPI.Data;

#nullable disable

namespace PayrolAPI.Migrations
{
    [DbContext(typeof(PayrollContext))]
    [Migration("20240626151027_payrollchanges")]
    partial class payrollchanges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedModels.Deduction", b =>
                {
                    b.Property<int>("DeductionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeductionID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("INSS")
                        .HasColumnType("float");

                    b.Property<double>("IR")
                        .HasColumnType("float");

                    b.HasKey("DeductionID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Deductions");
                });

            modelBuilder.Entity("SharedModels.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Celular")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Contratacion")
                        .HasColumnType("date");

                    b.Property<int>("DeductionID")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("FinContratacion")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("INSS")
                        .HasColumnType("int");

                    b.Property<int>("IncomeId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("Nacimiento")
                        .HasColumnType("date");

                    b.Property<int>("PayrollId")
                        .HasColumnType("int");

                    b.Property<int>("RUC")
                        .HasColumnType("int");

                    b.Property<int>("Salario")
                        .HasColumnType("int");

                    b.Property<double>("SalarioNeto")
                        .HasColumnType("float");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("PayrollId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SharedModels.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomeId"));

                    b.Property<double>("Antiguedad")
                        .HasColumnType("float");

                    b.Property<int>("CntdHorasExtras")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<double>("Nocturnidad")
                        .HasColumnType("float");

                    b.Property<double>("RiesgoLaboral")
                        .HasColumnType("float");

                    b.Property<double>("SalarioExtraOrdinario")
                        .HasColumnType("float");

                    b.Property<double>("SalarioOrdinario")
                        .HasColumnType("float");

                    b.HasKey("IncomeId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("SharedModels.Payroll", b =>
                {
                    b.Property<int>("PayrollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PayrollId"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaPeriodo")
                        .HasColumnType("date");

                    b.Property<string>("Periodo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PayrollId");

                    b.ToTable("Payrolls");
                });

            modelBuilder.Entity("SharedModels.Deduction", b =>
                {
                    b.HasOne("SharedModels.Employee", "Employees")
                        .WithMany("Deductions")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SharedModels.Employee", b =>
                {
                    b.HasOne("SharedModels.Payroll", "Payroll")
                        .WithMany("Employees")
                        .HasForeignKey("PayrollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payroll");
                });

            modelBuilder.Entity("SharedModels.Income", b =>
                {
                    b.HasOne("SharedModels.Employee", "Employees")
                        .WithMany("Incomes")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SharedModels.Employee", b =>
                {
                    b.Navigation("Deductions");

                    b.Navigation("Incomes");
                });

            modelBuilder.Entity("SharedModels.Payroll", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
