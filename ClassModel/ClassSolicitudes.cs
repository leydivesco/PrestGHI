using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Text;

namespace ClassModel
{
    public partial class ClassSolicitudes
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string CodigoCliente { get; set; }
        public string NombreCompleto { get; set; }
        public string MontoSolicitado { get; set; }
        public Periocidad periocidad { get; set; }
        public DateTime Tiempo { get; set; }
        public string TasaInteres { get; set; }
        public Estados estados { get; set; }
        public ClassCliente classCliente { get; set; }
        
    }
}
