﻿// <auto-generated />
using System;
using FamilyTree.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyTree.Migrations
{
    [DbContext(typeof(PeopleService))]
    partial class PeopleServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FamilyTree.Models.LinkModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int?>("PeopleChildID")
                        .HasColumnType("int");

                    b.Property<int?>("PeopleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PeopleChildID");

                    b.HasIndex("PeopleId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("FamilyTree.Models.PeopleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronymic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("FamilyTree.Models.LinkModel", b =>
                {
                    b.HasOne("FamilyTree.Models.PeopleModel", "PeopleChildren")
                        .WithMany("LinksChildren")
                        .HasForeignKey("PeopleChildID");

                    b.HasOne("FamilyTree.Models.PeopleModel", "PeopleMain")
                        .WithMany("LinksMain")
                        .HasForeignKey("PeopleId");

                    b.Navigation("PeopleChildren");

                    b.Navigation("PeopleMain");
                });

            modelBuilder.Entity("FamilyTree.Models.PeopleModel", b =>
                {
                    b.Navigation("LinksChildren");

                    b.Navigation("LinksMain");
                });
#pragma warning restore 612, 618
        }
    }
}
