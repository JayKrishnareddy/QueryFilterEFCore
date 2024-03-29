﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QueryFilterEFCore;

#nullable disable

namespace QueryFilterEFCore.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QueryFilterEFCore.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<long>("ContactNo")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 27,
                            ContactNo = 99999999L,
                            IsActive = true,
                            Name = "Jay"
                        },
                        new
                        {
                            Id = 2,
                            Age = 26,
                            ContactNo = 88888888L,
                            IsActive = true,
                            Name = "Krishna"
                        },
                        new
                        {
                            Id = 3,
                            Age = 25,
                            ContactNo = 88888888L,
                            IsActive = false,
                            Name = "Reddy"
                        },
                        new
                        {
                            Id = 4,
                            Age = 26,
                            ContactNo = 77777777L,
                            IsActive = false,
                            Name = "Majji"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
