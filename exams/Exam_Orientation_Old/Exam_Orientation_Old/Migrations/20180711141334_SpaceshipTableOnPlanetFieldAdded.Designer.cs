﻿// <auto-generated />
using System;
using Exam_Orientation_Old.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exam_Orientation_Old.Migrations
{
    [DbContext(typeof(SpaceContext))]
    [Migration("20180711141334_SpaceshipTableOnPlanetFieldAdded")]
    partial class SpaceshipTableOnPlanetFieldAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam_Orientation_Old.Models.Planet", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("Population");

                    b.HasKey("Id");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("Exam_Orientation_Old.Models.SpaceShip", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int?>("Population");

                    b.HasKey("Id");

                    b.ToTable("SpaceShip");
                });
#pragma warning restore 612, 618
        }
    }
}
