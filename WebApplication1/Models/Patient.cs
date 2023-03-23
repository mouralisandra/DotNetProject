using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        //public ICollection<Appointment> Appointments { get; set; }
        public Patient(int id, string name, string sex, string birthDate, int age, string phone, string address, string height, string weight)
        {
            Id = id;
            Name = name;
            Sex = sex;
            BirthDate = birthDate;
            Age = age;
            Phone = phone;
            Address = address;
            Height = height;
            Weight = weight;
            //Appointments = new Collection<Appointment>();
        }
    }
}