﻿// <auto-generated />
using System;
using BankingProject.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingProject.DataAccess.Migrations
{
    [DbContext(typeof(BankingDbContext))]
    [Migration("20210503103823_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.BankAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IBAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastTransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BankAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.CardTransaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TransactionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TransactionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("TransactionId");

                    b.ToTable("CardTransactions");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.ContactDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlternatePhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactDetails");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ContactDetailsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ContactDetailsId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Loan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CostumerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("LunarFee")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CostumerId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CostumerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CostumerId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Transaction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("BankAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalIBAN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.BankAccount", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.Customer", null)
                        .WithMany("BankAccounts")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Card", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.BankAccount", "BankAccount")
                        .WithMany("Cards")
                        .HasForeignKey("BankAccountId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.CardTransaction", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.Card", null)
                        .WithMany("CardTransactions")
                        .HasForeignKey("CardId");

                    b.HasOne("BankingProject.ApplicationLogic.Model.Transaction", "Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Customer", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.ContactDetails", "ContactDetails")
                        .WithMany()
                        .HasForeignKey("ContactDetailsId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Loan", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.Customer", "Costumer")
                        .WithMany("Loans")
                        .HasForeignKey("CostumerId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Request", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.Customer", "Costumer")
                        .WithMany("Requests")
                        .HasForeignKey("CostumerId");
                });

            modelBuilder.Entity("BankingProject.ApplicationLogic.Model.Transaction", b =>
                {
                    b.HasOne("BankingProject.ApplicationLogic.Model.BankAccount", null)
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
