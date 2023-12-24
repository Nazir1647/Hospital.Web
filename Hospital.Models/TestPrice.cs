using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class TestPrice
    {
        [Key]
        public int Id { get; set; }
        public string TestCode { get; set; }
        public decimal Price { get; set; }
        public Lab Lab { get; set; }
        public Bill Bill { get; set; }
    }
}
