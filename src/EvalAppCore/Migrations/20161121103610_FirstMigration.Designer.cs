﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EvalAppCore.Models;

namespace EvalAppCore.Migrations
{
    [DbContext(typeof(CFTDbContext))]
    [Migration("20161121103610_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EvalAppCore.Models.Clients", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientName");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("EvalAppCore.Models.Contracts", b =>
                {
                    b.Property<int>("ContractID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientID");

                    b.Property<string>("Contract");

                    b.HasKey("ContractID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("EvalAppCore.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("SecondName");

                    b.Property<string>("Surname");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EvalAppCore.Models.TimeEntry", b =>
                {
                    b.Property<int>("EntryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Client");

                    b.Property<string>("Comment");

                    b.Property<string>("Contract");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Employee");

                    b.Property<bool>("MakeUp");

                    b.Property<string>("Project");

                    b.Property<string>("Service");

                    b.Property<string>("Time");

                    b.HasKey("EntryID");

                    b.ToTable("TimeEntries");
                });
        }
    }
}
