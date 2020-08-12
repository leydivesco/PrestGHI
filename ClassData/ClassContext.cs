using System;
using System.Collections.Generic;
using System.Text;
using ClassModel;
using Microsoft.EntityFrameworkCore;

namespace ClassData
{
   public class ClassContext : DbContext
    {

        public ClassContext(DbContextOptions<ClassContext>options) : base(options)
        {
            
        }
        public DbSet<ClassSolicitudes> solicitudes { get; set; }
        public DbSet<ClassCliente> clientes { get; set; }
    }
}
