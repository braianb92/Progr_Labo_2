using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    class SobreSobreescrito : Sobreescrito
    {
        public SobreSobreescrito() : base() {}

        public override string MiPropiedad => base.miAtributo;

        public override string MiMetodo() => MiPropiedad;
      
    }
}
