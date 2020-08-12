using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassModel
{
   public class ClassCliente
    {
        public int ID { get; set; }
        public string CodigoCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        [Phone]
        public string Telefono { get; set; }
        [Phone]
        public string Celular { get; set; }
        public enum Sexo
        {
            Femenino,
            Masculino
        }
        public string Direccion { get; set; }
        [EmailAddress]
        public string CorreElectronico { get; set; }
        public string LugardeTrabajo { get; set; }
        public string DireccionTrabajo { get; set; }
        [Phone]
        public string TelefonoTrabajo { get; set; }
        public string Fax { get; set; }
        public string NombreSupervisor { get; set; }
        public string TiempoLaborando { get; set; }
        public string SueldoNeto { get; set; }


    }
}
