using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MockDataProject.Models
{
    public class MockDataContext : DbContext
    {
        public DbSet<MockData> MockDatas { get; set; }
    }
}