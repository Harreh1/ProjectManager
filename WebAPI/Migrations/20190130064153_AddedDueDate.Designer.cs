﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(TaskDetailContext))]
    [Migration("20190130064153_AddedDueDate")]
    partial class AddedDueDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.TaskDetail", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("Date");

                    b.Property<string>("TaskDescription")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("TaskTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("TaskId");

                    b.ToTable("TaskDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
