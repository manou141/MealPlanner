﻿// <auto-generated />
using System;
using MealPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MealPlanner.Migrations
{
    [DbContext(typeof(MealPlannerContext))]
    [Migration("20230416024021_sixth")]
    partial class sixth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MealPlanner.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("MealPlanner.Models.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("MealPlanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealPlanId");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("MealPlanner.Models.MealPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MealPlan");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MealId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MealId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("MealPlanner.Models.RecipeReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecipeReview");
                });

            modelBuilder.Entity("MealPlanner.Models.Ingredient", b =>
                {
                    b.HasOne("MealPlanner.Models.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("MealPlanner.Models.Meal", b =>
                {
                    b.HasOne("MealPlanner.Models.MealPlan", null)
                        .WithMany("Meals")
                        .HasForeignKey("MealPlanId");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.HasOne("MealPlanner.Models.Meal", null)
                        .WithMany("Recipes")
                        .HasForeignKey("MealId");
                });

            modelBuilder.Entity("MealPlanner.Models.Meal", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("MealPlanner.Models.MealPlan", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("MealPlanner.Models.Recipe", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
