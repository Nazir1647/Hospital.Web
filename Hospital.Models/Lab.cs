using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class Lab
    {
        [Key]
        public int Id { get; set; }
        public string LabNo { get; set; }
        public int TestType { get; set; }
        public int TestCode { get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public int BloodPressure { get; set; }
        public int Temperature { get; set; }
        public string TestResult { get; set; }
        public ApplicationUser Patient { get; set; }
    }
}
