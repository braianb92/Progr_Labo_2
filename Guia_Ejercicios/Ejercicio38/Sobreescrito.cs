using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    abstract class Sobreescrito
    {
        #region Atributos
        protected string miAtributo;
        #endregion

        #region Propiedades
        public abstract string MiPropiedad { get; }
        #endregion

        #region Constructores
        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        #endregion

        #region Override methods
        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType()==this.GetType())
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }
        #endregion

        #region Abstract Methods
        public abstract string MiMetodo();
        #endregion
    }
}
