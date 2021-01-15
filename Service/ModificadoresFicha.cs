using FunWithSolid.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithSolid.Service
{
    public abstract class ModificadoresFicha : IModificadoresFicha
    {
        IFakeViewModel _viewModel;
        public ModificadoresFicha(IFakeViewModel vm)
        {
            this._viewModel = vm;
        }

        public virtual void CalcularStats()
        {
            this.DefinirModificadores();
            throw new NotImplementedException();
        }

        public void DefinirModificadores()
        {
            var forca = _viewModel.GetForca();
            var destreza = _viewModel.GetDestreza();
            var constituicao = _viewModel.GetConstituicao();
            var inteligencia = _viewModel.GetInteligencia();
            var sabedoria = _viewModel.GetSabedoria();
            var carisma = _viewModel.GetCarisma();
            

            Console.WriteLine($"Nome:           {_viewModel.GetNome()}  | PV: --  |");
            Console.WriteLine("");
            Console.WriteLine($"Força:          {forca} | Mod: {this.GerarModificador(forca)}  |");
            Console.WriteLine($"Destreza:       {destreza}  | Mod: {this.GerarModificador(destreza)}  |");
            Console.WriteLine($"Constituição:   {constituicao}  | Mod: {this.GerarModificador(constituicao)}  |");
            Console.WriteLine($"Inteligência:   {inteligencia}  | Mod: {this.GerarModificador(inteligencia)}  |");
            Console.WriteLine($"Sabedoria:      {sabedoria} | Mod: {this.GerarModificador(sabedoria)}  |");
            Console.WriteLine($"Carisma:        {carisma}   | Mod: {this.GerarModificador(carisma)}  |");
        }

        private int GerarModificador(int status)
        {
            var modificador = -5;

            for (int i = 1; i <= status; i++)
            {
                if (i == status)
                {
                    break;
                }

                if ((i % 2) == 0)
                {
                    modificador++;
                }
            }

            return modificador;
        }
    }
}
