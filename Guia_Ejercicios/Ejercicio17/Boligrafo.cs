using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoligrafoSpace
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        public ConsoleColor color;
        public short tinta;
        
        public Boligrafo ()
        {

        }

        public Boligrafo(short tinta,ConsoleColor color )
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta)
        {
            if(tinta>=0&&tinta<=cantidadTintaMaxima)
            {
                this.tinta = tinta;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto,out string dibujo)
        {
            dibujo = "";
            short estadoActual;
            if(gasto>0)
            {
                estadoActual = GetTinta();
                estadoActual -= gasto;
                if(estadoActual>0)
                {
                    SetTinta(estadoActual);
                    for(int i=0; i<gasto;i++)
                    {
                        dibujo = "*" + dibujo;
                    }
                    return true;
                }              
            }
            return false;
        }
    }
}
