using System;
using System.ComponentModel.DataAnnotations;

namespace CarMaintanceApp.Models
{
    public class CarMaintenance
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CarName { get; set; }  // Numele mașinii

        [Required]
        public string MaintenanceType { get; set; }  // Tipul intervenției (ex: schimb ulei, filtre etc.)

        public DateTime MaintenanceDate { get; set; }  // Data întreținerii

        public int MileageAtService { get; set; }  // Kilometrajul la momentul întreținerii

        public int NextServiceMileage { get; set; }  // Kilometraj estimat pentru următoarea întreținere
    }
}
