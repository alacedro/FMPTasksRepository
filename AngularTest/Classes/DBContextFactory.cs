using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using AngularTest.Models.AODB;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTest.Classes
{
    public static class DbContextFactory
    {
        public static Dictionary<string, string> ConnectionStrings { get; set; }

        public static void SetConnectionString(Dictionary<string, string> connStrs)
        {
            ConnectionStrings = connStrs;
        }

        public static AODBContext Create(string connid)
        {
            if (!string.IsNullOrEmpty(connid))
            {
                var connStr = ConnectionStrings[connid];
                var optionsBuilder = new DbContextOptionsBuilder<AODBContext>();
                optionsBuilder.UseSqlServer(connStr);
                return new AODBContext(optionsBuilder.Options);
            }
            else
            {
                throw new ArgumentNullException("ConnectionId");
            }
        }
    }
}
