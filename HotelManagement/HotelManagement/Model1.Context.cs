//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HoteldbEntities : DbContext
    {
        public HoteldbEntities()
            : base("name=HoteldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client_tbl> Client_tbl { get; set; }
        public virtual DbSet<Room_tbl> Room_tbl { get; set; }
        public virtual DbSet<Reservation_tbl> Reservation_tbl { get; set; }
        public virtual DbSet<Staff_tbl> Staff_tbl { get; set; }
    }
}
