using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo,  Queue<Patente> datos)
        {
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    StreamWriter sw = new StreamWriter(Path.Combine(desktop, archivo));
                    foreach (Patente patente in datos)
                    {
                        sw.WriteLine(patente.ToString());
                    }                   
                    sw.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {

            datos = new Queue<Patente>();
            if (!string.IsNullOrEmpty(archivo))
            {
                try
                {
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    StreamReader sw = new StreamReader(Path.Combine(desktop, archivo));
                    while(!sw.EndOfStream)
                    {
                        Patente auxPatente = sw.ReadLine().ValidarPatente();
                        if (auxPatente != null)
                            datos.Enqueue(auxPatente);
                    }                    
                    sw.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
