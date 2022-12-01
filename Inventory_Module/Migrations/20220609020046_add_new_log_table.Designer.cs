﻿// <auto-generated />
using System;
using Inventory_Module.Data_Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inventory_Module.Migrations
{
    [DbContext(typeof(Inventory_Entity))]
    [Migration("20220609020046_add_new_log_table")]
    partial class add_new_log_table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Inventory_Module.Models.Client_Info", b =>
                {
                    b.Property<int>("client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("client_id"), 1L, 1);

                    b.Property<DateTime>("Client_Enrollment_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IsDeleted")
                        .HasColumnType("int");

                    b.Property<string>("Pan_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subscription_period")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("city_id")
                        .HasColumnType("int");

                    b.Property<string>("client_GSTNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_business_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_business_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_reference_contact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("client_reference_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("country_id")
                        .HasColumnType("int");

                    b.Property<int>("global_id")
                        .HasColumnType("int");

                    b.Property<int>("pincode")
                        .HasColumnType("int");

                    b.Property<int>("state_id")
                        .HasColumnType("int");

                    b.HasKey("client_id");

                    b.ToTable("Client_tbl");
                });

            modelBuilder.Entity("Inventory_Module.Models.Log_maintain_class", b =>
                {
                    b.Property<int>("error_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("error_id"), 1L, 1);

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("error_data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("error_inner_exception")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("error_line_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("error_messege")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("error_trace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("error_id");

                    b.ToTable("Log_Maintain_tbl");
                });
#pragma warning restore 612, 618
        }
    }
}