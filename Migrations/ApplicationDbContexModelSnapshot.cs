﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TranHoangChung110.Data;

#nullable disable

namespace TranHoangChung110.Migrations
{
    [DbContext(typeof(ApplicationDbContex))]
    partial class ApplicationDbContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("TranHoangChung110.Models.ComapyTHC110", b =>
                {
                    b.Property<string>("CompanyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyID");

                    b.ToTable("CompanyTHC110");
                });
#pragma warning restore 612, 618
        }
    }
}
