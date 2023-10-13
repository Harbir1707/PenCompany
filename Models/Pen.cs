using System;
using System.ComponentModel.DataAnnotations;

namespace PenCompany.Models
{
    public class Pen
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string CompanyName {get; set; }
        public string Color { get; set; } 
        public string Material { get; set; }
        public string InkType { get; set; } 
        public bool IsRefillable { get; set; } 
        public decimal Price { get; set; }
    }
}