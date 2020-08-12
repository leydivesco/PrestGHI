using System;
using System.Collections.Generic;
using System.Text;
using ClassModel;

namespace ClassData
{
   public interface ISolicitudes
    {
        IList<ClassSolicitudes> GetPorCodigo(string Texto);
        public ClassSolicitudes GetSolicitudId(int ID);
        ClassSolicitudes ActualizarSolicitudes(ClassSolicitudes ActualizarSolicitud);
        ClassSolicitudes NuevaSolicitud(ClassSolicitudes NuevaSolitc);
        int GuardarCambios();
    }
}
