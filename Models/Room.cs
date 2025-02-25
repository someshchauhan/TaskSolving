//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room()
        {
            this.RoomFacilities = new HashSet<RoomFacility>();
            this.RoomStays = new HashSet<RoomStay>();
        }
    
        public int RoomId { get; set; }
        public Nullable<int> HotelId { get; set; }
        public string RoomCode { get; set; }
        public string RoomType { get; set; }
        public string CharacteristicCode { get; set; }
        public Nullable<bool> IsParentRoom { get; set; }
        public Nullable<int> MinPax { get; set; }
        public Nullable<int> MaxPax { get; set; }
        public Nullable<int> MaxAdults { get; set; }
        public Nullable<int> MaxChildren { get; set; }
        public Nullable<int> MinAdults { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomFacility> RoomFacilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomStay> RoomStays { get; set; }
    }
}
