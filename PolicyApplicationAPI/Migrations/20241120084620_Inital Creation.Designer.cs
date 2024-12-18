﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolicyApplicationAPI.Database;

#nullable disable

namespace PolicyApplicationAPI.Migrations
{
    [DbContext(typeof(PolicyManagementDbContext))]
    [Migration("20241120084620_Inital Creation")]
    partial class InitalCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PolicyApplicationAPI.Models.PolicyHolder", b =>
                {
                    b.Property<int>("PolicyHolderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolicyHolderId"));

                    b.Property<string>("ImageAltDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PolicyHolderCommenmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PolicyHolderDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("PolicyHolderEmail")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PolicyHolderGender")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("PolicyHolderIdNumber")
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("PolicyHolderInitial")
                        .HasColumnType("nvarchar(4)");

                    b.Property<double>("PolicyHolderInstallmentAmount")
                        .HasColumnType("float");

                    b.Property<string>("PolicyHolderPolicyNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PolicyHolderPolicyType")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PolicyHolderSurname")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PolicyHolderId");

                    b.ToTable("PolicyHolders");
                });
#pragma warning restore 612, 618
        }
    }
}
