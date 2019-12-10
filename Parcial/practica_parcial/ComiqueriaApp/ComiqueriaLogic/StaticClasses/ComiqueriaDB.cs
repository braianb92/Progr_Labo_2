using ComiqueriaLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.StaticClasses
{
    public static class ComiqueriaDB
    {
        public delegate void DelegadoDB(AccionesDB accion);

        public static event DelegadoDB EventoDB;

        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ComiqueriaDB()
        {
            conexion = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Comiqueria;Integrated Security=true");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static List<Producto> LeerTabla()
        {
            List<Producto> lista = new List<Producto>();
            string record = string.Empty;
         
            try
            {
                comando.CommandText = String.Format("SELECT Codigo, descripcion, precio, stock FROM dbo.Productos");
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    String.Format($"{record[0]}, {record[1]}, {record[2]}, {record[3]}");
                    if(int.TryParse(record[0].ToString(), out int codigo) && int.TryParse(record[3].ToString(), out int stock) && double.TryParse(record[2].ToString(), out double precio))
                    {
                        lista.Add(new Producto(codigo,record[1].ToString(),stock,precio));
                    }
                    
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                throw new ComiqueriaException("Error en base de datos", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return lista;
        }

        public static bool Insertar(Producto producto)
        {
            bool retorno = false;
            if (producto is null) return retorno;

            try
            {
                comando.CommandText = String.Format($"{AccionesDB.Insert.ToString()} INTO dbo.Productos(descripcion,precio,stock) VALUES('{producto.Descripcion}', '{producto.Precio}', '{producto.Stock}')");
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Error en base de datos",ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ComiqueriaDB.EventoDB.Invoke(AccionesDB.Insert);
                    retorno = true;
                }
            }
            return retorno;

        }

        public static bool Modificar(Producto producto,double nuevoPrecio)
        {
            bool retorno = false;
            if (producto is null) return retorno;

            try
            {
                comando.CommandText = String.Format($"{AccionesDB.Update.ToString()} dbo.Productos SET precio = {nuevoPrecio} WHERE Codigo = {producto.Codigo}");
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ComiqueriaException("Error en base de datos", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ComiqueriaDB.EventoDB.Invoke(AccionesDB.Update);
                    retorno = true;
                }
            }
            return retorno;

        }

        public static bool Eliminar(Producto producto)
        {
            bool retorno = false;
            if (producto is null) return retorno;

            try
            {
                comando.CommandText = String.Format($"{AccionesDB.Delete.ToString()} FROM dbo.Productos WHERE Codigo = {producto.Codigo}");
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ComiqueriaException("Error en base de datos", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                    ComiqueriaDB.EventoDB.Invoke(AccionesDB.Delete);
                    retorno = true;
                }
            }
            return retorno;

        }
    }
}
