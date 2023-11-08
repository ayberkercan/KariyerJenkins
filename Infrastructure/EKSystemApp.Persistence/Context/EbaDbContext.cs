﻿using EKSystemApp.Domain.Entities.eBA;
using EKSystemApp.Domain.Entities.eBA.EntitiesOfSystemTables;
using EKSystemApp.Domain.Entities.eBA.ForeignLanguages;
using EKSystemApp.Domain.Entities.eBA.GeneralSkills;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKSystemApp.Persistence.Context
{
    public class EbaDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public EbaDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conStr = _configuration.GetConnectionString("eBA");
            optionsBuilder
                .UseSqlServer(_configuration.GetConnectionString("eBA"))
                .ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));


            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TmpZhrCalisanPersWs>().ToTable("TMP_ZHRCALISANPERSWS");
            modelBuilder.Entity<TmpOrganizationTree>().ToTable("TMP_ZHRORGANIZATIONTREE");
            modelBuilder.Entity<TmpOrganizationTreeDr>().ToTable("TMP_ZHRORGANIZATIONTREEDR");
            modelBuilder.Entity<GorevlerFullSap>().ToTable("GOREVLER_FULL_SAP");
            modelBuilder.Entity<Titles>().ToTable("TITLES");
            modelBuilder.Entity<Locations>().ToTable("Lokasyonlar");
            modelBuilder.Entity<StaffType>().ToTable("IseAlim_KadroDurumu");
            modelBuilder.Entity<WorkingType>().ToTable("IseAlim_CalismaTuru");
            modelBuilder.Entity<Genders>().ToTable("IseAlim_Cinsiyet");
            modelBuilder.Entity<EducationStatus>().ToTable("IseAlim_EgitimDuzeyi");
            modelBuilder.Entity<MilitaryStatus>().ToTable("IseAlim_AskerlikDurumu");
            modelBuilder.Entity<ShiftStatus>().ToTable("IseAlim_VardiyaDurumu");

            modelBuilder.Entity<M_Languages>().ToTable("E_mrs_IseAlimTurkuvaz_M_YabanciDilTanimlama");
            modelBuilder.Entity<P_Languages>().ToTable("E_mrs_IseAlimTurkuvaz_P_YabanciDilTanimlama");
            modelBuilder.Entity<P_LanguagesDataGrid>().ToTable("E_mrs_IseAlimTurkuvaz_P_YabanciDilTanimlama_dtyYabanciDil");
            modelBuilder.Entity<LanguageLevels>().ToTable("IseAlim_YabanciDilDuzeyi");

            modelBuilder.Entity<M_Skills>().ToTable("E_mrs_IseAlimTurkuvaz_M_ProfesyonelBeceriTanimlama");
            modelBuilder.Entity<P_Skills>().ToTable("E_mrs_IseAlimTurkuvaz_P_ProfesyonelBeceriTanimlama");
            modelBuilder.Entity<P_SkillsDataGrid>().ToTable("E_mrs_IseAlimTurkuvaz_P_ProfesyonelBeceriTanimlama_dtyProfesyonelBeceri");
            modelBuilder.Entity<SkillLevels>().ToTable("IseAlim_YetkinlikDuzeyi");


            modelBuilder.Entity<LiveFlows>().ToTable("LIVEFLOWS");
            modelBuilder.Entity<FlowDocuments>().ToTable("FLOWDOCUMENTS");
            modelBuilder.Entity<Documents>().ToTable("DOCUMENTS");
            modelBuilder.Entity<FlowRequests>().ToTable("FLOWREQUESTS");


            modelBuilder.Entity<IseAlimForm>().ToTable("E_mrs_IseAlimTurkuvaz_Form");
            modelBuilder.Entity<IseAlimGeneralSkillsDataGrid>().ToTable("E_mrs_IseAlimTurkuvaz_Form_dtyGenelYetkinlik");
            modelBuilder.Entity<IseAlimForeignLanguagesDataGrid>().ToTable("E_mrs_IseAlimTurkuvaz_Form_dtyYabanciDil");

            base.OnModelCreating(modelBuilder);
        }

        #region DbSet
        public DbSet<TmpZhrCalisanPersWs> TmpZhrCalisanPersWs { get; set; }
        public DbSet<TmpOrganizationTree> TmpOrganizationTree { get; set; }
        public DbSet<TmpOrganizationTreeDr> TmpOrganizationTreeDr { get; set; }
        public DbSet<GorevlerFullSap> GorevlerFullSap { get; set; }
        public DbSet<Titles> Titles { get; set; }
        public DbSet<Locations> Locations { get; set; }
        public DbSet<StaffType> StaffType { get; set; }
        public DbSet<WorkingType> WorkingType { get; set; }
        public DbSet<Genders> Gender { get; set; }
        public DbSet<EducationStatus> EducationStatus { get; set; }
        public DbSet<MilitaryStatus> MilitaryStatus { get; set; }
        public DbSet<ShiftStatus> ShiftStatus { get; set; }

        public DbSet<M_Languages> M_Languages { get; set; }
        public DbSet<P_Languages> P_Languages { get; set; }
        public DbSet<P_LanguagesDataGrid> P_LanguagesDataGrid { get; set; }
        public DbSet<LanguageLevels> LanguageLevels { get; set; }

        public DbSet<M_Skills> M_Skills { get; set; }
        public DbSet<P_Skills> P_Skills { get; set; }
        public DbSet<P_SkillsDataGrid> P_SkillsDataGrid { get; set; }
        public DbSet<SkillLevels> SkillLevels { get; set; }


        public DbSet<LiveFlows> LiveFlows { get; set; }
        public DbSet<FlowDocuments> FlowDocuments { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<FlowRequests> FlowRequests { get; set; }


        public DbSet<IseAlimForm> IseAlimForm { get; set; }
        public DbSet<IseAlimGeneralSkillsDataGrid> IseAlimGeneralSkillsDataGrid { get; set; }
        public DbSet<IseAlimForeignLanguagesDataGrid> IseAlimForeignLanguagesDataGrid { get; set; }
        #endregion
    }
}