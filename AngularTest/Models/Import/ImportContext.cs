using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTest.Models.Import
{
    public class ImportContext : DbContext
    {
        public ImportContext(DbContextOptions<ImportContext> options)
            : base(options)
        { }

        public virtual DbSet<ExteriorServicesSchedule> Schedules { get; set; }
    }
}
