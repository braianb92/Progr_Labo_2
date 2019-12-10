using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class AstroExtension
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan)
        {
            bool aux = false;
            if (plan != null)
            {
                try
                {
                    string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    StreamWriter sw = new StreamWriter(Path.Combine(desktop, "planeta.txt"));
                    sw.WriteLine(plan.ToString());
                    sw.Close();
                    aux = true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

            return aux;
        }

        public static bool GuardarXML(this Satelite sat)
        {
            if (sat is null) return false;

            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                XmlTextWriter xmlWriter = new XmlTextWriter(path + "/" + "satelites.xml", Encoding.ASCII);
                XmlSerializer serializer = new XmlSerializer(typeof(Satelite));

                serializer.Serialize(xmlWriter, sat);
                xmlWriter.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
