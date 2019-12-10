using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAstro
    {
        #region Properties
        Thread HiloOrbita { get; set; }
        Thread HiloRotacion { get; set; }
        #endregion

        #region Methods
        string Orbitar();
        string Rotar();
        void RunEvntOrb();
        void RunEvntRotar();
        #endregion
    }
}
