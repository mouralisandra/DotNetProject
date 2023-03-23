using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppointmentRepository: Repository<Appointment>, IAppointmentRepository
    {
        private readonly ClinicContext _applicationDbContext;
        public AppointmentRepository(ClinicContext _applicationDbContext) : base(_applicationDbContext)
        {
            this._applicationDbContext = _applicationDbContext;
        }
        
    }
}