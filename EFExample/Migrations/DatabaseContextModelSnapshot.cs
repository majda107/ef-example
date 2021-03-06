﻿// <auto-generated />
using System;
using EFExample.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFExample.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("EFExample.Database.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("EFExample.Database.Models.ArticleComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ArticleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("ArticleComment");
                });

            modelBuilder.Entity("EFExample.Database.Models.ArticleComment", b =>
                {
                    b.HasOne("EFExample.Database.Models.Article", null)
                        .WithMany("Comment")
                        .HasForeignKey("ArticleId");
                });
#pragma warning restore 612, 618
        }
    }
}
