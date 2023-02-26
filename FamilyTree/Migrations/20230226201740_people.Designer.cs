﻿// <auto-generated />
using System;
using FamilyTree.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyTree.Migrations
{
    [DbContext(typeof(PeopleService))]
    [Migration("20230226201740_people")]
    partial class people
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = 1,
                            PeopleChildID = 9,
                            PeopleId = 1
                        },
                        new
                        {
                            Id = 2,
                            Level = 1,
                            PeopleChildID = 9,
                            PeopleId = 2
                        },
                        new
                        {
                            Id = 3,
                            Level = 1,
                            PeopleChildID = 10,
                            PeopleId = 3
                        },
                        new
                        {
                            Id = 4,
                            Level = 1,
                            PeopleChildID = 10,
                            PeopleId = 4
                        },
                        new
                        {
                            Id = 5,
                            Level = 1,
                            PeopleChildID = 11,
                            PeopleId = 5
                        },
                        new
                        {
                            Id = 6,
                            Level = 1,
                            PeopleChildID = 11,
                            PeopleId = 6
                        },
                        new
                        {
                            Id = 7,
                            Level = 1,
                            PeopleChildID = 12,
                            PeopleId = 7
                        },
                        new
                        {
                            Id = 8,
                            Level = 1,
                            PeopleChildID = 12,
                            PeopleId = 8
                        },
                        new
                        {
                            Id = 9,
                            Level = 2,
                            PeopleChildID = 13,
                            PeopleId = 9
                        },
                        new
                        {
                            Id = 10,
                            Level = 2,
                            PeopleChildID = 13,
                            PeopleId = 10
                        },
                        new
                        {
                            Id = 11,
                            Level = 2,
                            PeopleChildID = 14,
                            PeopleId = 11
                        },
                        new
                        {
                            Id = 12,
                            Level = 2,
                            PeopleChildID = 14,
                            PeopleId = 12
                        },
                        new
                        {
                            Id = 13,
                            Level = 3,
                            PeopleChildID = 15,
                            PeopleId = 13
                        },
                        new
                        {
                            Id = 14,
                            Level = 3,
                            PeopleChildID = 15,
                            PeopleId = 14
                        },
                        new
                        {
                            Id = 15,
                            Level = 3,
                            PeopleChildID = 16,
                            PeopleId = 13
                        },
                        new
                        {
                            Id = 16,
                            Level = 3,
                            PeopleChildID = 16,
                            PeopleId = 14
                        },
                        new
                        {
                            Id = 17,
                            Level = 3,
                            PeopleChildID = 17,
                            PeopleId = 13
                        },
                        new
                        {
                            Id = 18,
                            Level = 3,
                            PeopleChildID = 17,
                            PeopleId = 14
                        },
                        new
                        {
                            Id = 19,
                            Level = 4,
                            PeopleId = 15
                        },
                        new
                        {
                            Id = 20,
                            Level = 4,
                            PeopleId = 16
                        },
                        new
                        {
                            Id = 21,
                            Level = 4,
                            PeopleId = 17
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Святослав",
                            Patronymic = "Донатович",
                            Surname = "Калашников"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Фанни",
                            Patronymic = "Игнатьевна",
                            Surname = "Калашникова"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Кондрат",
                            Patronymic = "Натальевич",
                            Surname = "Мамонтов"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Раиса",
                            Patronymic = "Давидовна",
                            Surname = "Мамонтова"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Иван",
                            Patronymic = "Наумович",
                            Surname = "Суворов"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Магдалина",
                            Patronymic = "Романовна",
                            Surname = "Суворова"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Константин",
                            Patronymic = "Владимирович",
                            Surname = "Котов"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Женевьева",
                            Patronymic = "Степановна",
                            Surname = "Котова"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Донат",
                            Patronymic = "Святославич",
                            Surname = "Калашников"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Эллина",
                            Patronymic = "Кондратовна",
                            Surname = "Мамонтова"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Павел",
                            Patronymic = "Ивановна",
                            Surname = "Суворов"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Эллина",
                            Patronymic = "Константинович",
                            Surname = "Котова"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Михаил",
                            Patronymic = "Донатович",
                            Surname = "Калашников"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Гражина",
                            Patronymic = "Павловна",
                            Surname = "Суворова"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Гурий",
                            Patronymic = "Михайлович",
                            Surname = "Калашников"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Алексей",
                            Patronymic = "Михайлович",
                            Surname = "Калашников"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Римма",
                            Patronymic = "Михайловна",
                            Surname = "Калашников"
                        });
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
