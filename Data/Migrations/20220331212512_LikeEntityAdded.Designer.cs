﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using neurek.Data;

namespace neurek.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220331212512_LikeEntityAdded")]
    partial class LikeEntityAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("neurek.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Deleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastActive")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("neurek.Entities.CandidateEducation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationDescription")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EducationEndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EducationStartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("LevelOfDegree")
                        .HasColumnType("TEXT");

                    b.Property<string>("MajoredIn")
                        .HasColumnType("TEXT");

                    b.Property<string>("SchoolName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("CandidateEducation");
                });

            modelBuilder.Entity("neurek.Entities.CandidateExperience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CurrentJob")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("CandidateExperience");
                });

            modelBuilder.Entity("neurek.Entities.CandidateLanguages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LanguageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("LanguageId");

                    b.ToTable("CandidateLanguages");
                });

            modelBuilder.Entity("neurek.Entities.CandidatePreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NoticeOfPeriod")
                        .HasColumnType("TEXT");

                    b.Property<int>("SalaryPerMonth")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("CandidatePreference");
                });

            modelBuilder.Entity("neurek.Entities.CandidateSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SkillsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("SkillsId");

                    b.ToTable("CandidateSkill");
                });

            modelBuilder.Entity("neurek.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("YearFoundedIn")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("neurek.Entities.CompanyBenefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyBenefit");
                });

            modelBuilder.Entity("neurek.Entities.JobAd", b =>
                {
                    b.Property<int>("JobAdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("JobAdId");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobAd");
                });

            modelBuilder.Entity("neurek.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("JobAdId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LanguageIcon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JobAdId");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("neurek.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("neurek.Entities.PortfolioFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppUserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PublicId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("PortfolioFile");
                });

            modelBuilder.Entity("neurek.Entities.Skills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DevIconName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("neurek.Entities.UserLike", b =>
                {
                    b.Property<int>("SourceUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JobAdId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SourceUserId", "JobAdId");

                    b.HasIndex("JobAdId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("neurek.Entities.AppUser", b =>
                {
                    b.HasOne("neurek.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("neurek.Entities.CandidateEducation", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Educations")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("neurek.Entities.CandidateExperience", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Experiences")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("neurek.Entities.CandidateLanguages", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Languages")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neurek.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId");

                    b.Navigation("AppUser");

                    b.Navigation("Language");
                });

            modelBuilder.Entity("neurek.Entities.CandidatePreference", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Preferences")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("neurek.Entities.CandidateSkill", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Skills")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neurek.Entities.Skills", "Skills")
                        .WithMany()
                        .HasForeignKey("SkillsId");

                    b.Navigation("AppUser");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("neurek.Entities.CompanyBenefit", b =>
                {
                    b.HasOne("neurek.Entities.Company", "Company")
                        .WithMany("Benefits")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("neurek.Entities.JobAd", b =>
                {
                    b.HasOne("neurek.Entities.Company", "Company")
                        .WithMany("JobAds")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("neurek.Entities.Language", b =>
                {
                    b.HasOne("neurek.Entities.JobAd", null)
                        .WithMany("ProgrammingLanguages")
                        .HasForeignKey("JobAdId");
                });

            modelBuilder.Entity("neurek.Entities.Photo", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("Photos")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neurek.Entities.Company", null)
                        .WithMany("Photos")
                        .HasForeignKey("CompanyId");

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("neurek.Entities.PortfolioFile", b =>
                {
                    b.HasOne("neurek.Entities.AppUser", "AppUser")
                        .WithMany("CandidateFiles")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("neurek.Entities.UserLike", b =>
                {
                    b.HasOne("neurek.Entities.JobAd", "JobAd")
                        .WithMany("Likes")
                        .HasForeignKey("JobAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("neurek.Entities.AppUser", "SourceUser")
                        .WithMany("LikedJobAds")
                        .HasForeignKey("SourceUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobAd");

                    b.Navigation("SourceUser");
                });

            modelBuilder.Entity("neurek.Entities.AppUser", b =>
                {
                    b.Navigation("CandidateFiles");

                    b.Navigation("Educations");

                    b.Navigation("Experiences");

                    b.Navigation("Languages");

                    b.Navigation("LikedJobAds");

                    b.Navigation("Photos");

                    b.Navigation("Preferences");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("neurek.Entities.Company", b =>
                {
                    b.Navigation("Benefits");

                    b.Navigation("JobAds");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("neurek.Entities.JobAd", b =>
                {
                    b.Navigation("Likes");

                    b.Navigation("ProgrammingLanguages");
                });
#pragma warning restore 612, 618
        }
    }
}