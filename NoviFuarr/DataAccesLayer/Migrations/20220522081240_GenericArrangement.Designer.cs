﻿// <auto-generated />
using System;
using DataAccesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220522081240_GenericArrangement")]
    partial class GenericArrangement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.PersonalManagement", b =>
                {
                    b.Property<int>("PersonalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalID"), 1L, 1);

                    b.Property<DateTime>("PersonalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PersonalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PersonalPassword")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("PersonalRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonalUserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonalID");

                    b.ToTable("UserManagements");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Visitors", b =>
                {
                    b.Property<int>("VisitorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VisitorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Address");

                    b.Property<string>("BarCode")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BarCode");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("City");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CompanyName");

                    b.Property<string>("Contry")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Contry");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Number1")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Number1");

                    b.Property<string>("Number2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Number2");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Surname");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("WebAddress");

                    b.HasKey("VisitorID");

                    b.ToTable("Visitors");
                });
#pragma warning restore 612, 618
        }
    }
}
