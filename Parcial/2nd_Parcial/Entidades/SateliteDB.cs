using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SateliteDB
    {
        #region Atributes
        private SqlCommand comando;
        private SqlConnection conexion;
        #endregion

        public SateliteDB()
        {
            this.conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=planetario;Integrated Security=True");
            this.comando = new SqlCommand();
            this.comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }

        public bool Guardar(Satelite satelite)
        {
            bool retorno = false;

            try
            {
                this.comando.CommandText = String.Format($"INSERT INTO dbo.Satelites(nombre, duracion_orbita, duracion_rotacion) VALUES('{satelite.Nombre}', '{satelite.DuraOrbita}', '{satelite.DuraRotacion}')");
                this.conexion.Open();
                this.comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception ex)
            {
                retorno = false;
                throw ex;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                    this.conexion.Close();               
            }
            return retorno;
        }

        public List<Satelite>Leer()
        {
            List<Satelite> datos = new List<Satelite>();
            try
            {
                this.comando.CommandText = "SELECT nombre,duracion_orbita,duracion_rotacion FROM " + "Satelites";
                this.conexion.Open();               
                SqlDataReader reader = this.comando.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(new Satelite((int)reader["duracion_orbita"], (int)reader["duracion_rotacion"], reader["nombre"].ToString()));                 
                }

                reader.Close();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                    this.conexion.Close();
            }
            return datos;
        }
    }
}
