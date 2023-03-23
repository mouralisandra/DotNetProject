using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }
        public string Specialization { get; set; }
        //public ICollection<Appointment> Appointments { get; set; }
        public Doctor()
        {

        }
        public Doctor(int id, string name, string phone, bool isAvailable, string address, string specialization)
        {
            Id = id;
            Name = name;
            Phone = phone;
            IsAvailable = isAvailable;
            Address = address;
            Specialization = specialization;
            //Appointments = new Collection<Appointment>();
        }
    }
}