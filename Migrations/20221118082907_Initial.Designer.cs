// <auto-generated />
using System;
using FictitiousMobilePlan1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FictitiousMobilePlan1.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221118082907_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FictitiousMobilePlan1.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mei")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Payment")
                        .HasColumnType("int");

                    b.Property<string>("PlanName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sei")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Starttime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Phone");
                });
#pragma warning restore 612, 618
        }
    }
}
