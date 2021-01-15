using FunWithSolid.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithSolid.Service
{
    public class ServiceFicha
    {
        private IModificadoresFicha _modificarFicha { get; set; }
        public ServiceFicha(IModificadoresFicha mf)
        {
            this._modificarFicha = mf;
        }

        public void ResolverFicha()
        {
            this._modificarFicha.CalcularStats();
        }
    }
}
