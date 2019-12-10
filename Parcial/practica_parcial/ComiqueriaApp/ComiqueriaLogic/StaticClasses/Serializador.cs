using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ComiqueriaLogic.StaticClasses
{
    public static class Serializador<T> where T: class, new()
    {
        public static bool GuardarXml(string path, T datos)
        {
            if (!string.IsNullOrEmpty(path) && datos != null)
            {
                try
                {
                    XmlTextWriter xmlWriter = new XmlTextWriter(path, Encoding.ASCII);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(xmlWriter, datos);
                    xmlWriter.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("Error en serializacion",e);
                }
            }
            return false;
        }

        public static bool LeerXml(string archivo, out T datos)
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
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("Error en serializacion", e);
                }
            }
            return false;
        }

        public static bool GuardarBinaryXml(string path, T datos)
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(path) && datos != null)
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    BinaryFormatter ser = new BinaryFormatter();

                    ser.Serialize(fs, datos);
                    fs.Close();
                    retorno = true;
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Serializacion binaria.",ex);
                }            
            }
            return retorno;
        }

        public static bool LeerBinaryXml(string path, out T datos)
        {
            datos = default(T);
            if (!string.IsNullOrEmpty(path) && datos != null)
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Open);
                    BinaryFormatter ser = new BinaryFormatter();

                    datos = (T)ser.Deserialize(fs);
                    fs.Close();
                    return true;
                }
                catch (Exception ex)
                {

                    throw new Exception("Error Deserealizacion binaria",ex);
                }
                
            }
            return false;
        }
    }

   
}
