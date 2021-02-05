﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blog.entity;

namespace blog.data.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("blog.entity.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("AddedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("BloggerId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReadTime")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BloggerId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("blog.entity.BlogCategory", b =>
                {
                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BlogId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("blog.entity.Blogger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Bloggers");
                });

            modelBuilder.Entity("blog.entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("IconClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("blog.entity.Blog", b =>
                {
                    b.HasOne("blog.entity.Blogger", "Blogger")
                        .WithMany("Blog")
                        .HasForeignKey("BloggerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blogger");
                });

            modelBuilder.Entity("blog.entity.BlogCategory", b =>
                {
                    b.HasOne("blog.entity.Blog", "Blog")
                        .WithMany("BlogCategories")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blog.entity.Category", "Category")
                        .WithMany("BlogCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("blog.entity.Blog", b =>
                {
                    b.Navigation("BlogCategories");
                });

            modelBuilder.Entity("blog.entity.Blogger", b =>
                {
                    b.Navigation("Blog");
                });

            modelBuilder.Entity("blog.entity.Category", b =>
                {
                    b.Navigation("BlogCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
