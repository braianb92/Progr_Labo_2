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
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static ComiqueriaDB()
        {
            conexion = new SqlConnection("Data Source = .\\SQLEXPRESS;Initial Catalog=Comiqueria;Integrated Security=true");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static bool Insertar(Producto producto)
        {
            bool retorno = false;
            if (producto is null) return retorno;

            try
            {
                comando.CommandText = String.Format($"{AccionesDB.Insert.ToString()} INTO dbo.Productos(Descripcion,Precio,Stock) VALUES('{producto.Descripcion}','{producto.Precio}','{producto.Stock}')");
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
                    retorno = true;
                }
            }
            return retorno;

        }
    }
}
