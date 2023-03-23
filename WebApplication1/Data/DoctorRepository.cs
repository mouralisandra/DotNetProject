using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DoctorRepository : Repository<Doctor>, IDoctorRepository
    {
        private readonly ClinicContext _applicationDbContext;
        public DoctorRepository(ClinicContext _applicationDbContext) : base(_applicationDbContext)
        {
            this._applicationDbContext = _applicationDbContext;
        }
        public IEnumerable<Doctor> GetAvailableDoctors()
        {
            return _applicationDbContext.Doctors
                .Where(a => a.IsAvailable == true)
                .ToList();
        }
    }
}