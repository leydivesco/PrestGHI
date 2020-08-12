using ClassModel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassData
{
   public class ClassServiceAdoSolicitud :ISolicitudes
    {
        private readonly string connectionString;
        private int rowAffect;
        List<ClassSolicitudes> actualizarSolicitud;
        List<ClassSolicitudes> NuevaSolicitud;
        public ClassServiceAdoSolicitud(string conn)
        {
            this.connectionString = conn;
            actualizarSolicitud = new List<ClassSolicitudes>();
            NuevaSolicitud = new List<ClassSolicitudes>();
        } 
        public IList<ClassSolicitudes> GetPorCodigo(string Texto)
        {
            using(SqlConnection connection = new SqlConnection(this.connectionString))
            {
                var query = @"Select * From solicitudes 
                            where Codigo like '%' + @text + '%' or isnull(@text,'')=''";

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlParameter text = new SqlParameter("@text", Texto);
                if (Texto == null)
                {
                    text.Value = DBNull.Value;
                }
                text.SqlDbType = System.Data.SqlDbType.NVarChar;

                cmd.Parameters.Add(text);

                connection.Open();

                var reader = cmd.ExecuteReader();
                List<ClassSolicitudes> solicitudes = new List<ClassSolicitudes>();

                while (reader.Read())
                {
                    solicitudes.Add(new ClassSolicitudes
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Codigo = reader["Codigo"].ToString(),
                        CodigoCliente = reader["CodigoCliente"].ToString(),
                        NombreCompleto = reader["NombreCompleto"].ToString(),
                        MontoSolicitado = reader["MontoSolicitado"].ToString(),
                        periocidad = (Periocidad)reader["Periocidad"],
                        Tiempo = Convert.ToDateTime(reader["Tiempo"]),
                        TasaInteres =reader["interes"].ToString(),
                        estados = (Estados)reader["Estado"]
                    });
                }
                connection.Close();
                connection.Dispose();
                return solicitudes;
            }
        }

        public ClassSolicitudes GetSolicitudId(int ID)
        {
            throw new NotImplementedException();
        }

        public ClassSolicitudes ActualizarSolicitudes(ClassSolicitudes ActualizarSolicitud)
        {
            throw new NotImplementedException();
        }

        ClassSolicitudes ISolicitudes.NuevaSolicitud(ClassSolicitudes NuevaSolitc)
        {
            throw new NotImplementedException();
        }

        public int GuardarCambios()
        {
            throw new NotImplementedException();
        }
    }
}
