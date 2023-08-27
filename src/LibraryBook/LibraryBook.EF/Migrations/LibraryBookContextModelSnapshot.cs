﻿// <auto-generated />
using System;
using LibraryBook.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryBook.EF.Migrations
{
    [DbContext(typeof(LibraryBookContext))]
    partial class LibraryBookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryBook.Domain.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("auhor");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Editor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("editor");

                    b.Property<Guid>("IdGender")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_gender");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id_user");

                    b.Property<long?>("IsbnNumber")
                        .HasMaxLength(20)
                        .HasColumnType("bigint")
                        .HasColumnName("isbnNumber");

                    b.Property<string>("PictureBook")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("pictureBook");

                    b.Property<string>("Synopsis")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("synopsis");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("IdGender");

                    b.HasIndex("IdUser");

                    b.ToTable("tb_book", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Domain.Entities.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("tb_gender", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("active");

                    b.Property<int?>("Code")
                        .HasColumnType("int")
                        .HasColumnName("code");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("fullName");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("ProfilePic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profilePic");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("refreshToken");

                    b.Property<DateTime>("RefreshTokenExpireTime")
                        .HasColumnType("datetime2")
                        .HasColumnName("refreshTokenExpireTime");

                    b.HasKey("Id");

                    b.ToTable("tb_users", (string)null);
                });

            modelBuilder.Entity("LibraryBook.Domain.Entities.Book", b =>
                {
                    b.HasOne("LibraryBook.Domain.Entities.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("IdGender")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryBook.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
