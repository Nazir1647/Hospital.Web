﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class HospitalInfo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string City { get; set; }
        public string PinCode { get; set; }
        public string Country { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
