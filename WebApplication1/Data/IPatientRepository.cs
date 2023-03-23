using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    internal interface IPatientRepository : IRepository<Patient>
    {
    }
}
