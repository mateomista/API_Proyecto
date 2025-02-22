﻿// <auto-generated />
using API_Proyecto.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Proyecto.Migrations
{
    [DbContext(typeof(StockContext))]
    [Migration("20241219201111_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("API_Proyecto.Models.Cliente", b =>
                {
                    b.Property<int>("CUIT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apynom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CUIT");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("API_Proyecto.Models.Posicion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<ushort?>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ClienteCUIT")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Estanteria")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Nivel")
                        .HasColumnType("INTEGER");

                    b.Property<char>("Pasillo")
                        .HasColumnType("TEXT");

                    b.Property<uint?>("ProductoIdProducto")
                        .HasColumnType("INTEGER");

                    b.Property<ushort>("Seccion")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClienteCUIT");

                    b.HasIndex("ProductoIdProducto");

                    b.ToTable("Posiciones");
                });

            modelBuilder.Entity("API_Proyecto.Models.Producto", b =>
                {
                    b.Property<uint>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdProducto");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("API_Proyecto.Models.Posicion", b =>
                {
                    b.HasOne("API_Proyecto.Models.Cliente", null)
                        .WithMany("Posiciones")
                        .HasForeignKey("ClienteCUIT");

                    b.HasOne("API_Proyecto.Models.Producto", null)
                        .WithMany("Posiciones")
                        .HasForeignKey("ProductoIdProducto");
                });

            modelBuilder.Entity("API_Proyecto.Models.Cliente", b =>
                {
                    b.Navigation("Posiciones");
                });

            modelBuilder.Entity("API_Proyecto.Models.Producto", b =>
                {
                    b.Navigation("Posiciones");
                });
#pragma warning restore 612, 618
        }
    }
}
