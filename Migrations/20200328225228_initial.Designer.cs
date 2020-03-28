﻿// <auto-generated />
using System;
using HomeHealth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomeHealth.Migrations
{
    [DbContext(typeof(HomeHealthDbContext))]
    [Migration("20200328225228_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HomeHealth.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Appointments", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("appointment_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AppDate")
                        .IsRequired()
                        .HasColumnName("app_date")
                        .HasColumnType("date");

                    b.Property<string>("AppReason")
                        .IsRequired()
                        .HasColumnName("app_reason")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime?>("AppTime")
                        .IsRequired()
                        .HasColumnName("app_time")
                        .HasColumnType("datetime");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnName("patient_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProfessionalId")
                        .IsRequired()
                        .HasColumnName("doctor_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("totalcost")
                        .HasColumnName("Total_cost")
                        .HasColumnType("real");

                    b.HasKey("AppointmentId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ProfessionalId");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Charges", b =>
                {
                    b.Property<int>("ChargeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AppointmentId")
                        .IsRequired()
                        .HasColumnName("appointment_id")
                        .HasColumnType("int");

                    b.Property<int?>("Prof_serviceId")
                        .IsRequired()
                        .HasColumnName("service_id")
                        .HasColumnType("int");

                    b.Property<int?>("ServicesServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("serviceCost")
                        .IsRequired()
                        .HasColumnName("Service_Cost")
                        .HasColumnType("int");

                    b.HasKey("ChargeId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("Prof_serviceId");

                    b.HasIndex("ServicesServiceId");

                    b.ToTable("bill");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Messages", b =>
                {
                    b.Property<int>("Message1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("message1_id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProfessionalsId")
                        .HasColumnType("int");

                    b.Property<string>("RecieverId")
                        .HasColumnName("patient_id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SenderId")
                        .HasColumnName("doctor_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Message1Id")
                        .HasName("message1_id");

                    b.HasIndex("ProfessionalsId");

                    b.HasIndex("RecieverId");

                    b.HasIndex("SenderId");

                    b.ToTable("message1");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Professional_Service", b =>
                {
                    b.Property<int>("Professional_ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProfessionalId")
                        .HasColumnName("ProfessionalId")
                        .HasColumnType("int");

                    b.Property<float?>("ServiceCost")
                        .HasColumnName("Service_cost")
                        .HasColumnType("real");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Professional_ServiceId")
                        .HasName("Prof_service_id");

                    b.HasIndex("ProfessionalId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Professional_Service");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Professionals", b =>
                {
                    b.Property<int>("ProfessionalsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorsAddress1")
                        .HasColumnName("doctors_Address1")
                        .HasColumnType("char(80)")
                        .IsFixedLength(true)
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("DoctorsAddress2")
                        .HasColumnName("doctors_Address2")
                        .HasColumnType("char(80)")
                        .IsFixedLength(true)
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<int?>("ServicesServiceId")
                        .HasColumnType("int");

                    b.Property<string>("state_parish")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProfessionalsId")
                        .HasName("pk_Duser_id");

                    b.HasIndex("ServicesServiceId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("ProfessionalsId");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Services", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnName("Service_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Appointments", b =>
                {
                    b.HasOne("HomeHealth.Identity.ApplicationUser", "Patient")
                        .WithMany("AppointmentsPati")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("fk_User_patient_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HomeHealth.Identity.ApplicationUser", "Professional")
                        .WithMany("Appointmentsprof")
                        .HasForeignKey("ProfessionalId")
                        .HasConstraintName("fk_User_Profesional_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeHealth.data.tables.Charges", b =>
                {
                    b.HasOne("HomeHealth.data.tables.Appointments", "Appointment")
                        .WithMany("Charges")
                        .HasForeignKey("AppointmentId")
                        .HasConstraintName("fk_appointment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.data.tables.Professional_Service", "Professional_Service")
                        .WithMany("Charges")
                        .HasForeignKey("Prof_serviceId")
                        .HasConstraintName("fk_Charges_prof_service_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.data.tables.Services", null)
                        .WithMany("Charges")
                        .HasForeignKey("ServicesServiceId");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Messages", b =>
                {
                    b.HasOne("HomeHealth.data.tables.Professionals", null)
                        .WithMany("Messages")
                        .HasForeignKey("ProfessionalsId");

                    b.HasOne("HomeHealth.Identity.ApplicationUser", "Reciever")
                        .WithMany("MessagesRec")
                        .HasForeignKey("RecieverId")
                        .HasConstraintName("fk_messages_recieverUser");

                    b.HasOne("HomeHealth.Identity.ApplicationUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .HasConstraintName("fk_Messages_SenderUser");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Professional_Service", b =>
                {
                    b.HasOne("HomeHealth.data.tables.Professionals", "Professional")
                        .WithMany("Prof_services")
                        .HasForeignKey("ProfessionalId")
                        .HasConstraintName("k_prof_service_Professional");

                    b.HasOne("HomeHealth.data.tables.Services", "Service")
                        .WithMany("prof_services")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("fk_prof_service__service");
                });

            modelBuilder.Entity("HomeHealth.data.tables.Professionals", b =>
                {
                    b.HasOne("HomeHealth.data.tables.Services", null)
                        .WithMany("Professionals")
                        .HasForeignKey("ServicesServiceId");

                    b.HasOne("HomeHealth.Identity.ApplicationUser", "user")
                        .WithOne("Professional")
                        .HasForeignKey("HomeHealth.data.tables.Professionals", "userId")
                        .HasConstraintName("fk_Prof_User")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HomeHealth.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HomeHealth.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HomeHealth.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
