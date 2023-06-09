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
    [Migration("20220320125827_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.ValueObject.OrderConsigneeInfo", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Tel")
                        .HasColumnType("longtext");

                    b.ToTable("OrderConsigneeInfo");
                });

            modelBuilder.Entity("Domain.ValueObject.OrderGoodsSnapshot", b =>
                {
                    b.Property<string>("CategoryName")
                        .HasColumnType("longtext");

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<string>("GoodsImage")
                        .HasColumnType("longtext");

                    b.Property<string>("GoodsName")
                        .HasColumnType("longtext");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.ToTable("OrderGoodsSnapshot");
                });

            modelBuilder.Entity("Infrastructure.PersistenceObject.Logistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DeliveTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DeliverAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("DeliverName")
                        .HasColumnType("longtext");

                    b.Property<int>("DeliverUserId")
                        .HasColumnType("int");

                    b.Property<string>("LogisticsNo")
                        .HasColumnType("longtext");

                    b.Property<int>("LogisticsState")
                        .HasColumnType("int");

                    b.Property<int>("LogisticsType")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReceiveTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ReceiverAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("longtext");

                    b.Property<int>("ReceiverUserId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Logistics");
                });

            modelBuilder.Entity("Infrastructure.PersistenceObject.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConsigneeInfo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderNo")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderState")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Infrastructure.PersistenceObject.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("GoodsId")
                        .HasColumnType("int");

                    b.Property<string>("GoodsSnapshot")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Infrastructure.PersistenceObject.TradeLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("LogisticsId")
                        .HasColumnType("int");

                    b.Property<string>("LogisticsNo")
                        .HasColumnType("longtext");

                    b.Property<int>("OperateUserId")
                        .HasColumnType("int");

                    b.Property<string>("OperateUserName")
                        .HasColumnType("longtext");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("OrderNo")
                        .HasColumnType("longtext");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<int>("TenantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TradeDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("TradeLogValue")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TradeLog");
                });
#pragma warning restore 612, 618
        }
    }
}
