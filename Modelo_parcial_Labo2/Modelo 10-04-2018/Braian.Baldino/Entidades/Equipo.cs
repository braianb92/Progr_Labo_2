using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    directorTecnico = value;
                }

            }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string (Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Equipo: {e.Nombre}");
            sb.AppendLine("**Director Tecnico**");
            string director = (e.directorTecnico == null) ? "Sin DT Asignado" : e.directorTecnico.Mostrar();
            sb.AppendLine(director);
            sb.AppendLine("**Jugadores**");
            sb.AppendLine($"Cantidad Jugadores: {e.jugadores.Count}");
            foreach (Jugador jugador in e.jugadores)
            {
                sb.AppendLine(jugador.Mostrar());
            }
            return sb.ToString();
        }

        public static bool operator == (Equipo e, Jugador j)
        {
            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador == j)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator + (Equipo e, Jugador j)
        {
            if((e!=j)&&(e.jugadores.Count<6)&&(j.ValidarAptitud()))
            {
                 e.jugadores.Add(j);
                return e;
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            int arquero=0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador.Equals(Posicion.Arquero))
                    arquero++;
                else if (jugador.Equals(Posicion.Central))
                    central++;
                else if (jugador.Equals(Posicion.Delantero))
                    delantero++;
                else if (jugador.Equals(Posicion.Defensor))
                    defensor++;
            }

            return ((e.directorTecnico != null) &&
               (arquero == 1) &&
               (central >= 1 && delantero >= 1 && defensor >= 1) &&
               (e.jugadores.Count == 6)) ? true : false;
        }

    }
}
