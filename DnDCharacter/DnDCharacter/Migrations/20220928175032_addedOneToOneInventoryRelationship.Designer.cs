﻿// <auto-generated />
using DnDCharacter;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DnDCharacter.Migrations
{
    [DbContext(typeof(CharacterContext))]
    [Migration("20220928175032_addedOneToOneInventoryRelationship")]
    partial class addedOneToOneInventoryRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DnDCharacter.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArmorClass")
                        .HasColumnType("int");

                    b.Property<int>("Experiance")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArmorClass = 30,
                            Experiance = 0,
                            HitPoints = 30,
                            Name = "Bob",
                            Speed = 30
                        },
                        new
                        {
                            Id = 2,
                            ArmorClass = 30,
                            Experiance = 250,
                            HitPoints = 30,
                            Name = "Jedidia",
                            Speed = 30
                        },
                        new
                        {
                            Id = 3,
                            ArmorClass = 30,
                            Experiance = 150,
                            HitPoints = 30,
                            Name = "Keb",
                            Speed = 30
                        });
                });

            modelBuilder.Entity("DnDCharacter.Models.CharacterInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId")
                        .IsUnique();

                    b.ToTable("CharacterInventories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 150,
                            CharacterId = 1,
                            ItemName = "Gold"
                        },
                        new
                        {
                            Id = 2,
                            Amount = 250,
                            CharacterId = 2,
                            ItemName = "Gold"
                        },
                        new
                        {
                            Id = 3,
                            Amount = 350,
                            CharacterId = 3,
                            ItemName = "Gold"
                        });
                });

            modelBuilder.Entity("DnDCharacter.Models.CharacterInventory", b =>
                {
                    b.HasOne("DnDCharacter.Models.Character", "Character")
                        .WithOne("CharacterInventory")
                        .HasForeignKey("DnDCharacter.Models.CharacterInventory", "CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("DnDCharacter.Models.Character", b =>
                {
                    b.Navigation("CharacterInventory")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}