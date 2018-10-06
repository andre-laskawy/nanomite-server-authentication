﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nanomite.Server.Authenticaton.Data.Database;

namespace Nanomite.Server.Authenticaton.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20181006125049_1.0.0")]
    partial class _100
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Nanomite.Core.Network.Common.NetworkUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AuthenticationToken");

                    b.Property<string>("CreatedDT");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LoginName");

                    b.Property<string>("ModifiedDT");

                    b.Property<string>("Name");

                    b.Property<string>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("NetworkUser");
                });
#pragma warning restore 612, 618
        }
    }
}