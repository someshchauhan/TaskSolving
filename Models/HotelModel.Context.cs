﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskSolving.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities : DbContext
    {
        public Database1Entities()
            : base("name=Database1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<HotelImage> HotelImages { get; set; }
        public virtual DbSet<InterestPoint> InterestPoints { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomFacility> RoomFacilities { get; set; }
        public virtual DbSet<RoomStay> RoomStays { get; set; }
        public virtual DbSet<RoomStayFacility> RoomStayFacilities { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<WildcardRoomDescription> WildcardRoomDescriptions { get; set; }
    }
}
