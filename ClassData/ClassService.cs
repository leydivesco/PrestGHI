using ClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassData
{
    public class ClassService : ISolicitudes
    {
        private ClassContext db;
        public ClassService(ClassContext db)
        {
            this.db = db;
        }

        public ClassSolicitudes ActualizarSolicitudes(ClassSolicitudes ActualizarSolicitud)
        {
            throw new NotImplementedException();
        }

        public IList<ClassSolicitudes> GetPorCodigo(string Texto)
        {
            if (!string.IsNullOrEmpty(Texto))
            {
                Texto = Texto.ToLower();
            }
            return db.solicitudes.Where(m => string.IsNullOrEmpty(Texto) || m.Codigo.ToLower().Contains(Texto)).OrderBy(m => m.ID).ToList();
        }

        public ClassSolicitudes GetSolicitudId(int ID)
        {
            throw new NotImplementedException();
        }

        public int GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public ClassSolicitudes NuevaSolicitud(ClassSolicitudes NuevaSolitc)
        {
            throw new NotImplementedException();
        }
    }
}
