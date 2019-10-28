using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary
{
    public class Mensaje : IMensaje
    {
        string usuario;
        string texto;
        DateTime hora;

        public string Usuario
        {
            get { return this.usuario; }
            set { this.usuario = value; }
        }

        public string Texto
        {
            get { return this.texto; }
            set { this.texto = value; }
        }

        public DateTime Hora
        {
            get { return this.hora; }
            set { this.hora = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Usuario}: ");
            sb.AppendLine($"{Texto} ");
            sb.AppendLine($"[{Hora}]");
            return sb.ToString();
        }

        public void Serializar()
        {
            const string path = @"Y:/mensajes";
            XmlTextWriter xmlw = new XmlTextWriter(path,UTF8Encoding.ASCII);
            XmlSerializer serializer = new XmlSerializer(typeof(Mensaje));
            


            
        }

        public static List<Mensaje> Deserealizar()
        {

        }
    }
}
