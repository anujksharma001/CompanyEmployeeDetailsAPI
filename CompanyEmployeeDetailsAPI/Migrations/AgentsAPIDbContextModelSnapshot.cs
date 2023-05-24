﻿// <auto-generated />
using Demo_Company_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Demo_Company_API.Migrations
{
    [DbContext(typeof(AgentsAPIDbContext))]
    partial class AgentsAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.2.23128.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Demo_Company_API.Models.Agent", b =>
                {
                    b.Property<string>("AGENT_CODE")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AGENT_NAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("COMMISSION")
                        .HasColumnType("int");

                    b.Property<string>("COUNTRY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHONE_NO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WORKING_AREA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AGENT_CODE");

                    b.ToTable("Agents");
                });
#pragma warning restore 612, 618
        }
    }
}
