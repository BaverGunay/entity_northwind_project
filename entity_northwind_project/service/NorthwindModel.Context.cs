﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entity_northwind_project.service
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NorthwindTR_DBEntities : DbContext
    {
        public NorthwindTR_DBEntities()
            : base("name=NorthwindTR_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MUSTERILER> MUSTERILER { get; set; }
        public virtual DbSet<PERSONELLER> PERSONELLER { get; set; }
        public virtual DbSet<SIPARIS> SIPARIS { get; set; }
        public virtual DbSet<SIPARIS_DETAY> SIPARIS_DETAY { get; set; }
        public virtual DbSet<TEDARIKCILER> TEDARIKCILER { get; set; }
        public virtual DbSet<URUNLER> URUNLER { get; set; }
        public virtual DbSet<Kategoriler> Kategoriler { get; set; }
        public virtual DbSet<View_Kategoriler> View_Kategoriler { get; set; }
        public virtual DbSet<View_Musteriler> View_Musteriler { get; set; }
        public virtual DbSet<View_PERSONEL_LIST> View_PERSONEL_LIST { get; set; }
        public virtual DbSet<View_SIPARIS_LIST> View_SIPARIS_LIST { get; set; }
        public virtual DbSet<View_SIPARISDETAY_LIST> View_SIPARISDETAY_LIST { get; set; }
        public virtual DbSet<View_Tedarikci_List> View_Tedarikci_List { get; set; }
        public virtual DbSet<View_Urunler_List> View_Urunler_List { get; set; }
        public virtual DbSet<View_personelAD_ID> View_personelAD_ID { get; set; }
        public virtual DbSet<View_musteriID_AD> View_musteriID_AD { get; set; }
    }
}
