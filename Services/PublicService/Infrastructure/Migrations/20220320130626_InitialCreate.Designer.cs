﻿// <auto-generated />
using System;
using Infrastructure.EfDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(EfDbContext))]
    [Migration("20220320130626_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infrastructure.PersistenceObject.EventHandleErrorInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ErrMessage")
                        .HasColumnType("longtext");

                    b.Property<string>("ErrStackTrace")
                        .HasColumnType("longtext");

                    b.Property<string>("EventData")
                        .HasColumnType("longtext");

                    b.Property<string>("HandlerName")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsSystemErr")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EventHandleErrorInfo");
                });

            modelBuilder.Entity("Infrastructure.PersistenceObject.MallSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DeliverAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("DeliverName")
                        .HasColumnType("longtext");

                    b.Property<string>("Notice")
                        .HasColumnType("longtext");

                    b.Property<string>("ShopDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("ShopIconUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("ShopName")
                        .HasColumnType("longtext");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MallSetting");
                });
#pragma warning restore 612, 618
        }
    }
}
