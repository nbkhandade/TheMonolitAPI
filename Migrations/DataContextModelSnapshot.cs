﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheMonolit.API.Data;

namespace TheMonolit.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("TheMonolit.API.Models.FundDataValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FundName")
                        .HasColumnType("TEXT");

                    b.Property<float>("InceptionToDate")
                        .HasColumnType("REAL");

                    b.Property<float>("Month1")
                        .HasColumnType("REAL");

                    b.Property<float>("Month3")
                        .HasColumnType("REAL");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ticker")
                        .HasColumnType("TEXT");

                    b.Property<float>("Year")
                        .HasColumnType("REAL");

                    b.Property<float>("Year3")
                        .HasColumnType("REAL");

                    b.Property<float>("Year5")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("FundDataValues");
                });

            modelBuilder.Entity("TheMonolit.API.Properties.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
