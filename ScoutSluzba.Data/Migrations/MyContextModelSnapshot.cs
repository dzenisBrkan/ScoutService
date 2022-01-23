﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoutSluzba.Data;

namespace ScoutSluzba.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostanskiBr")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Greska", b =>
                {
                    b.Property<int>("GreskaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("VrijemeGreske")
                        .HasColumnType("datetime2");

                    b.Property<string>("greska")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GreskaID");

                    b.ToTable("Greska");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Igrac", b =>
                {
                    b.Property<int>("IgracID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Datum_rodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategorijaID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecifikacijaID")
                        .HasColumnType("int");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<string>("Tezina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IgracID");

                    b.HasIndex("GradID");

                    b.HasIndex("KategorijaID");

                    b.HasIndex("SpecifikacijaID");

                    b.HasIndex("TeamID");

                    b.ToTable("Igrac");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Kategorija", b =>
                {
                    b.Property<int>("KategorijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dob")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozicija")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaID");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("KorisnickiNalogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipKorisnickogNaloga")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnickiNalogID");

                    b.ToTable("korisnickiNalog");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Liga", b =>
                {
                    b.Property<int>("LigaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrTimova")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sampion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LigaID");

                    b.ToTable("Liga");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Lokacija", b =>
                {
                    b.Property<int>("LokacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ulica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LokacijaID");

                    b.HasIndex("GradID");

                    b.ToTable("Lokacija");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.OcjenaKomentar", b =>
                {
                    b.Property<int>("OcjenaKomentarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IgracID")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenikID")
                        .HasColumnType("int");

                    b.HasKey("OcjenaKomentarID");

                    b.HasIndex("IgracID");

                    b.HasIndex("ZaposlenikID");

                    b.ToTable("OcjenaKomentar");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Specifikacija", b =>
                {
                    b.Property<int>("SpecifikacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrOffside")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojKornera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojPogodaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojSlobodnih")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrveniKarton")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZutiKarton")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecifikacijaID");

                    b.ToTable("Specifikacija");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LigaID")
                        .HasColumnType("int");

                    b.Property<string>("Lokacija")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("President")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trener")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamID");

                    b.HasIndex("LigaID");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.TipZaposlenika", b =>
                {
                    b.Property<int>("TipZaposlenikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipZaposlenikaID");

                    b.ToTable("TipZaposlenika");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Datum_rodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt_br")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipZaposlenikaID")
                        .HasColumnType("int");

                    b.HasKey("ZaposlenikID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnickiNalogID");

                    b.HasIndex("TipZaposlenikaID");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Grad", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Igrac", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoutSluzba.Data.EntityModels.Kategorija", "Kategorija")
                        .WithMany()
                        .HasForeignKey("KategorijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoutSluzba.Data.EntityModels.Specifikacija", "Specifikacija")
                        .WithMany()
                        .HasForeignKey("SpecifikacijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoutSluzba.Data.EntityModels.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("Kategorija");

                    b.Navigation("Specifikacija");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Lokacija", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Grad", "Drzava")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.OcjenaKomentar", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Igrac", "Igrac")
                        .WithMany()
                        .HasForeignKey("IgracID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoutSluzba.Data.EntityModels.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Igrac");

                    b.Navigation("Zaposlenik");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Team", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Liga", "Liga")
                        .WithMany()
                        .HasForeignKey("LigaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Liga");
                });

            modelBuilder.Entity("ScoutSluzba.Data.EntityModels.Zaposlenik", b =>
                {
                    b.HasOne("ScoutSluzba.Data.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ScoutSluzba.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID");

                    b.HasOne("ScoutSluzba.Data.EntityModels.TipZaposlenika", "TipZaposlenika")
                        .WithMany()
                        .HasForeignKey("TipZaposlenikaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grad");

                    b.Navigation("KorisnickiNalog");

                    b.Navigation("TipZaposlenika");
                });
#pragma warning restore 612, 618
        }
    }
}
