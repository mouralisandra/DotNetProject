using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string DateAndTime { get; set; }
        public bool Status { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }

        public Appointment()
        {

        }
        
       
    }
}