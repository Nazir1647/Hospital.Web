using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public int HospitalId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public HospitalInfo Hospital { get; set; }
    }
}