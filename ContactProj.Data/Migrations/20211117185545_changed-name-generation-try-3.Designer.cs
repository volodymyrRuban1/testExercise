﻿// <auto-generated />

using ContactProj.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactProj.Data.Migrations
{
    [DbContext(typeof(ContactProjContext))]
    [Migration("20211117185545_changed-name-generation-try-3")]
    partial class changednamegenerationtry3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactProj.Data.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IncidentName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("IncidentName");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Incident", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Incident");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Account", b =>
                {
                    b.HasOne("ContactProj.Data.Entities.Incident", "Incident")
                        .WithMany("Account")
                        .HasForeignKey("IncidentName");

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Contact", b =>
                {
                    b.HasOne("ContactProj.Data.Entities.Account", "Accounts")
                        .WithMany("Contacts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Account", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("ContactProj.Data.Entities.Incident", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
