using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql  : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {
            this.conexion = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog = patentes; Integrated Security = True;");
            this.comando = new SqlCommand();
            this.comando.Connection = this.conexion;
        }

        public void Guardar(string tabla,  Queue<Patente> datos)
        {
            try
            {
                this.conexion.Open();
                this.comando.
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            throw new NotImplementedException();
        }
    }
}
