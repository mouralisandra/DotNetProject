using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        private readonly ClinicContext _applicationDbContext;
        public PatientRepository(ClinicContext _applicationDbContext) : base(_applicationDbContext)
        {
            this._applicationDbContext = _applicationDbContext;
        }
    }
}