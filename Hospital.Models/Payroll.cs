using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Payroll
    {
        [Key]
        public int Id { get; set; }
        public decimal Salary { get; set; }
        public decimal NetSalary { get; set; }
        public decimal HourSalary { get; set; }
        public decimal BonusSalary { get; set; }
        public decimal Compensation { get; set; }
        public string AccountNumber { get; set; }
        public ApplicationUser EmployeeId { get; set; }
    }
}