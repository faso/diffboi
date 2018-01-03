﻿// <auto-generated />
using MegaDiffBoi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MegaDiffBoi.Migrations
{
    [DbContext(typeof(DiffBoiContext))]
    partial class DiffBoiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDiffBoi.Models.Entry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ParagraphID");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Value");

                    b.HasKey("ID");

                    b.HasIndex("ParagraphID");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("MegaDiffBoi.Models.Paragraph", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Page");

                    b.Property<string>("Query");

                    b.HasKey("ID");

                    b.ToTable("Paragraphs");
                });

            modelBuilder.Entity("MegaDiffBoi.Models.Entry", b =>
                {
                    b.HasOne("MegaDiffBoi.Models.Paragraph", "Paragraph")
                        .WithMany()
                        .HasForeignKey("ParagraphID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
