﻿// <auto-generated />
using System;
using HomeHealth.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HomeHealth.Web.Migrations
{
    [DbContext(typeof(HomeHealthDbContext))]
    partial class HomeHealthDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Appointments", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("appointment_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressString")
                        .IsRequired()
                        .HasColumnName("Prof_Address1")
                        .HasColumnType("character(80)")
                        .IsFixedLength(true)
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<DateTime?>("AppDate")
                        .IsRequired()
                        .HasColumnName("app_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("AppReason")
                        .IsRequired()
                        .HasColumnName("app_reason")
                        .HasColumnType("text")
                        .IsUnicode(false);

                    b.Property<DateTime?>("AppTime")
                        .IsRequired()
                        .HasColumnName("app_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnName("patient_id")
                        .HasColumnType("text");

                    b.Property<string>("ProfessionalId")
                        .IsRequired()
                        .HasColumnName("doctor_id")
                        .HasColumnType("text");

                    b.Property<int>("ishomevisit")
                        .HasColumnName("isHomeVisist")
                        .HasColumnType("integer");

                    b.Property<double>("lat")
                        .HasColumnName("lat")
                        .HasColumnType("double precision");

                    b.Property<double>("lng")
                        .HasColumnName("lng")
                        .HasColumnType("double precision");

                    b.Property<float>("totalcost")
                        .HasColumnName("Total_cost")
                        .HasColumnType("real");

                    b.HasKey("AppointmentId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ProfessionalId");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Charges", b =>
                {
                    b.Property<int>("ChargeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AppointmentId")
                        .IsRequired()
                        .HasColumnName("appointment_id")
                        .HasColumnType("integer");

                    b.Property<int?>("Prof_serviceId")
                        .IsRequired()
                        .HasColumnName("service_id")
                        .HasColumnType("integer");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<float?>("serviceCost")
                        .IsRequired()
                        .HasColumnName("Service_Cost")
                        .HasColumnType("real");

                    b.HasKey("ChargeId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("Prof_serviceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("bill");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Comments", b =>
                {
                    b.Property<int>("CommentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProfessionalId")
                        .HasColumnType("integer");

                    b.Property<string>("SenderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("CommentsId");

                    b.HasIndex("ProfessionalId");

                    b.HasIndex("SenderId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Messages", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("message_id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Content")
                        .HasColumnName("Content")
                        .HasColumnType("text");

                    b.Property<int?>("ProfessionalsId")
                        .HasColumnType("integer");

                    b.Property<string>("ReceiverId")
                        .HasColumnName("ReceiverId")
                        .HasColumnType("text");

                    b.Property<string>("SenderId")
                        .HasColumnName("SenderId")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("MessageId")
                        .HasName("message_id");

                    b.HasIndex("ProfessionalsId");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("message");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Professional_Service", b =>
                {
                    b.Property<int>("Professional_ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ProfessionalId")
                        .HasColumnName("ProfessionalId")
                        .HasColumnType("integer");

                    b.Property<float?>("ServiceCost")
                        .HasColumnName("Service_cost")
                        .HasColumnType("real");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("Professional_ServiceId")
                        .HasName("Prof_service_id");

                    b.HasIndex("ProfessionalId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Professional_Service");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Professionals", b =>
                {
                    b.Property<int>("ProfessionalsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressString")
                        .IsRequired()
                        .HasColumnName("Prof_Address1")
                        .HasColumnType("character(80)")
                        .IsFixedLength(true)
                        .HasMaxLength(80)
                        .IsUnicode(false);

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnName("Biography")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<double>("lat")
                        .HasColumnName("lat")
                        .HasColumnType("double precision");

                    b.Property<double>("lng")
                        .HasColumnName("lng")
                        .HasColumnType("double precision");

                    b.Property<string>("userId")
                        .IsRequired()
                        .HasColumnName("user_id")
                        .HasColumnType("text");

                    b.HasKey("ProfessionalsId")
                        .HasName("pk_Duser_id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("ProfessionalsId");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnName("Service_name")
                        .HasColumnType("text");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("HomeHealth.Web.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Appointments", b =>
                {
                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "Patient")
                        .WithMany("AppointmentsPati")
                        .HasForeignKey("PatientId")
                        .HasConstraintName("fk_User_patient_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "Professional")
                        .WithMany("Appointmentsprof")
                        .HasForeignKey("ProfessionalId")
                        .HasConstraintName("fk_User_Profesional_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Charges", b =>
                {
                    b.HasOne("HomeHealth.Web.Data.Tables.Appointments", "Appointment")
                        .WithMany("Charges")
                        .HasForeignKey("AppointmentId")
                        .HasConstraintName("fk_appointment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.Web.Data.Tables.Professional_Service", "Professional_Service")
                        .WithMany("Charges")
                        .HasForeignKey("Prof_serviceId")
                        .HasConstraintName("fk_Charges_prof_service_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.Web.Data.Tables.Service", null)
                        .WithMany("Charges")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Comments", b =>
                {
                    b.HasOne("HomeHealth.Web.Data.Tables.Professionals", "Professional")
                        .WithMany("ProfComments")
                        .HasForeignKey("ProfessionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "Sender")
                        .WithMany("UsersComments")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Messages", b =>
                {
                    b.HasOne("HomeHealth.Web.Data.Tables.Professionals", null)
                        .WithMany("Messages")
                        .HasForeignKey("ProfessionalsId");

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "Reciever")
                        .WithMany("MessagesRec")
                        .HasForeignKey("ReceiverId")
                        .HasConstraintName("fk_messages_recieverUser");

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "Sender")
                        .WithMany("MessagesSent")
                        .HasForeignKey("SenderId")
                        .HasConstraintName("fk_Messages_SenderUser");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Professional_Service", b =>
                {
                    b.HasOne("HomeHealth.Web.Data.Tables.Professionals", "Professional")
                        .WithMany("Prof_services")
                        .HasForeignKey("ProfessionalId")
                        .HasConstraintName("k_prof_service_Professional");

                    b.HasOne("HomeHealth.Web.Data.Tables.Service", "Service")
                        .WithMany("prof_services")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("fk_prof_service__service");
                });

            modelBuilder.Entity("HomeHealth.Web.Data.Tables.Professionals", b =>
                {
                    b.HasOne("HomeHealth.Web.Data.Tables.Service", null)
                        .WithMany("Professionals")
                        .HasForeignKey("ServiceId");

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", "user")
                        .WithOne("Professional")
                        .HasForeignKey("HomeHealth.Web.Data.Tables.Professionals", "userId")
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
                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", null)
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

                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HomeHealth.Web.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
