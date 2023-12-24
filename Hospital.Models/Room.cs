using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public int HospitalId { get; set; }
        public HospitalInfo Hospital { get; set; }

    }
}