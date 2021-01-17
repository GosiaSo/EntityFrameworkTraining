﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperQuick
{
    class SuperQuickContext : DbContext
    {
        //public SuperQuickContext(): base("Name=SuperQuickContext") 
        //{ 
        //} 
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
