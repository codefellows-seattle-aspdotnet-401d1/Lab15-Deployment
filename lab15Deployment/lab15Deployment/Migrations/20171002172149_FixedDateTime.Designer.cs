﻿// <auto-generated />
using lab15Deployment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab15Deployment.Migrations
{
    [DbContext(typeof(lab15DeploymentContext))]
    [Migration("20171002172149_FixedDateTime")]
    partial class FixedDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab15Deployment.Models.Students", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<string>("Course")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
