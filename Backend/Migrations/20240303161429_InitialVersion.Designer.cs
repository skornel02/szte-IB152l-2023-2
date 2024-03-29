﻿// <auto-generated />
using System;
using Backend.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240303161429_InitialVersion")]
    partial class InitialVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Backend.Persistance.Entities.CommentEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CommentedOnPoetryId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("CommentedOnPostId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CreatorUserEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.HasKey("Id");

                    b.HasIndex("CommentedOnPoetryId");

                    b.HasIndex("CreatorUserEmailAddress");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.EmailQueueEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("Priority")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("RecipientUserEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<DateTime?>("SentAt")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("Id");

                    b.HasIndex("RecipientUserEmailAddress");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.EngagementEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CreatorUserEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<int?>("EngagedWithPoetryId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("EngagedWithPostId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserEmailAddress");

                    b.HasIndex("EngagedWithPoetryId");

                    b.HasIndex("EngagedWithPostId");

                    b.ToTable("Engagements");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.FollowingEntity", b =>
                {
                    b.Property<string>("FollowedUserEmailAddress")
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("FollowerUserEmailAddress")
                        .HasColumnType("NVARCHAR2(255)");

                    b.HasKey("FollowedUserEmailAddress", "FollowerUserEmailAddress");

                    b.HasIndex("FollowerUserEmailAddress");

                    b.ToTable("Followings");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PoetryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CreatorUserEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserEmailAddress");

                    b.ToTable("Poetries");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PostEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("NVARCHAR2(1000)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("CreatorUserEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserEmailAddress");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.UserEntity", b =>
                {
                    b.Property<string>("EmailAddress")
                        .HasMaxLength(255)
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR2(50)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Pronouns")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("NVARCHAR2(21)");

                    b.Property<bool>("UserWatcher")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("EmailAddress");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.WatchListEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("From")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("StalkedEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<string>("StalkerEmailAddress")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(255)");

                    b.Property<DateTime>("Until")
                        .HasColumnType("TIMESTAMP(7)");

                    b.HasKey("Id");

                    b.HasIndex("StalkedEmailAddress");

                    b.HasIndex("StalkerEmailAddress");

                    b.ToTable("WatchList");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.CommentEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.PoetryEntity", "CommentedOnPoetry")
                        .WithMany("Comments")
                        .HasForeignKey("CommentedOnPoetryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Persistance.Entities.PostEntity", "CommentedOnPost")
                        .WithMany("Comments")
                        .HasForeignKey("CommentedOnPoetryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Persistance.Entities.UserEntity", "CreatorUser")
                        .WithMany("Comments")
                        .HasForeignKey("CreatorUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommentedOnPoetry");

                    b.Navigation("CommentedOnPost");

                    b.Navigation("CreatorUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.EmailQueueEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "RecipientUser")
                        .WithMany("Emails")
                        .HasForeignKey("RecipientUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecipientUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.EngagementEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "CreatorUser")
                        .WithMany("Engagements")
                        .HasForeignKey("CreatorUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Persistance.Entities.PoetryEntity", "EngagedWithPoetry")
                        .WithMany("Engagements")
                        .HasForeignKey("EngagedWithPoetryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Backend.Persistance.Entities.PostEntity", "EngagedWithPost")
                        .WithMany("Engagements")
                        .HasForeignKey("EngagedWithPostId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("CreatorUser");

                    b.Navigation("EngagedWithPoetry");

                    b.Navigation("EngagedWithPost");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.FollowingEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "FollowedUser")
                        .WithMany("Followers")
                        .HasForeignKey("FollowedUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Persistance.Entities.UserEntity", "FollowerUser")
                        .WithMany("Followings")
                        .HasForeignKey("FollowerUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FollowedUser");

                    b.Navigation("FollowerUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PoetryEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "CreatorUser")
                        .WithMany("Poetries")
                        .HasForeignKey("CreatorUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatorUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PostEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "CreatorUser")
                        .WithMany("Posts")
                        .HasForeignKey("CreatorUserEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatorUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.WatchListEntity", b =>
                {
                    b.HasOne("Backend.Persistance.Entities.UserEntity", "StalkedUser")
                        .WithMany("StalkedBy")
                        .HasForeignKey("StalkedEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Persistance.Entities.UserEntity", "StalkerUser")
                        .WithMany("StalkedUsers")
                        .HasForeignKey("StalkerEmailAddress")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StalkedUser");

                    b.Navigation("StalkerUser");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PoetryEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Engagements");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.PostEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Engagements");
                });

            modelBuilder.Entity("Backend.Persistance.Entities.UserEntity", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Emails");

                    b.Navigation("Engagements");

                    b.Navigation("Followers");

                    b.Navigation("Followings");

                    b.Navigation("Poetries");

                    b.Navigation("Posts");

                    b.Navigation("StalkedBy");

                    b.Navigation("StalkedUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
