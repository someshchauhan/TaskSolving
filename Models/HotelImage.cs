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
    
    public partial class HotelImage
    {
        public int ImageId { get; set; }
        public Nullable<int> HotelId { get; set; }
        public string ImageTypeCode { get; set; }
        public string Path { get; set; }
        public Nullable<int> ImageOrder { get; set; }
        public Nullable<int> VisualOrder { get; set; }
        public string RoomCode { get; set; }
        public string RoomType { get; set; }
        public string CharacteristicCode { get; set; }
    
        public virtual Hotel Hotel { get; set; }
    }
}
