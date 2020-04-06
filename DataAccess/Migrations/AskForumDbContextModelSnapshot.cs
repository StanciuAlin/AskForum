﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(AskForumDbContext))]
    partial class AskForumDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationLogic.DataModel.Ad", b =>
                {
                    b.Property<long>("AdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdUser")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("AdId");

                    b.HasIndex("UserId");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Article", b =>
                {
                    b.Property<long>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdUser")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AdId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ArticleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdUser")
                        .HasColumnType("bigint");

                    b.Property<long?>("QuestionId")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("AdId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.ContactMe", b =>
                {
                    b.Property<long>("ContactMeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactMeId");

                    b.HasIndex("AdminId");

                    b.ToTable("ContactMes");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Question", b =>
                {
                    b.Property<long>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdUser")
                        .HasColumnType("bigint");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("QuestionId");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("AdminId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Ad", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.User", null)
                        .WithMany("IdAds")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Article", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.User", null)
                        .WithMany("IdArticles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Comment", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.Ad", null)
                        .WithMany("IdComments")
                        .HasForeignKey("AdId");

                    b.HasOne("ApplicationLogic.DataModel.Article", null)
                        .WithMany("IdComments")
                        .HasForeignKey("ArticleId");

                    b.HasOne("ApplicationLogic.DataModel.Question", null)
                        .WithMany("IdComments")
                        .HasForeignKey("QuestionId");

                    b.HasOne("ApplicationLogic.DataModel.User", null)
                        .WithMany("IdComments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.ContactMe", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.Admin", null)
                        .WithMany("IdContactRequests")
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.Question", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.User", null)
                        .WithMany("IdQuestions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ApplicationLogic.DataModel.User", b =>
                {
                    b.HasOne("ApplicationLogic.DataModel.Admin", null)
                        .WithMany("IdUsers")
                        .HasForeignKey("AdminId");
                });
#pragma warning restore 612, 618
        }
    }
}
