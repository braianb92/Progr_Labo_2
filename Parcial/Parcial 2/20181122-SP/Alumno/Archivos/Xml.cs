using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo,  T datos)
        {
            if (!string.IsNullOrEmpty(archivo) && datos != null)
            {
                try
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    XmlTextWriter xmlWriter = new XmlTextWriter(path + "/" + archivo, Encoding.ASCII);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(xmlWriter, datos);
                    xmlWriter.Close();
                }
                catch (Exception e)
                {
                    throw e ;
                }
            }
        }

        public void Leer(string archivo, out T datos)
        {
            datos = default(T);
            if (!string.IsNullOrEmpty(archivo) && datos != null)
            {
                try
                {
                    string file = string.Empty;
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    foreach (string item in Directory.GetFiles(desktop))
                    {
                        if (item == archivo)
                            file = item;
                    }

                    XmlTextReader xmlReader = new XmlTextReader(file);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(xmlReader);
                    xmlReader.Close();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
