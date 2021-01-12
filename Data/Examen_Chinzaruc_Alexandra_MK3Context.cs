using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Examen_Chinzaruc_Alexandra_MK3.Models;

namespace Examen_Chinzaruc_Alexandra_MK3.Data
{
    public class Examen_Chinzaruc_Alexandra_MK3Context : DbContext
    {
        public Examen_Chinzaruc_Alexandra_MK3Context (DbContextOptions<Examen_Chinzaruc_Alexandra_MK3Context> options)
            : base(options)
        {
        }

        public DbSet<Examen_Chinzaruc_Alexandra_MK3.Models.Exhibit> Exhibit { get; set; }
    }
}
