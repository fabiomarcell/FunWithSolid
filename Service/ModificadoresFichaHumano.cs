using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithSolid.Service
{
    public class ModificadoresFichaHumano : ModificadoresFicha
    {
        private IFakeViewModel _viewModel;
        private int _bonusAplicado = +2;

        public ModificadoresFichaHumano(IFakeViewModel vm) : base(vm)
        {
            this._viewModel = vm;
        }
        public override void CalcularStats()
        {
            var primeiroStatus = 0;
            var segudoStatus = 0;
            try
            {
                do
                {
                    Console.WriteLine("Selecione 2 atributos para aplicar +2 de bônus:");
                    Console.WriteLine("1 - Forca | 2 - Destreza | 3 - Constituicao | 4 - Inteligencia | 5 - Sabedoria  | 6 - Carisma");
                    primeiroStatus = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("1 - Forca | 2 - Destreza | 3 - Constituicao | 4 - Inteligencia | 5 - Sabedoria  | 6 - Carisma");
                    segudoStatus = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                } while (!(primeiroStatus >= 1 && primeiroStatus <= 6) && !(segudoStatus >= 1 && segudoStatus <= 6));

                this.IdentificarStatusParaAplicarBonus(primeiroStatus);
                this.IdentificarStatusParaAplicarBonus(segudoStatus);
            }
            catch 
            {
                Console.WriteLine("Falha na conversão de valores. Tente novamente...");
                this.CalcularStats();
            }


            base.DefinirModificadores();
        }

        private void IdentificarStatusParaAplicarBonus(int status)
        {
            switch (status)
            {
                case 1:
                    _viewModel.SetBonusForca(_bonusAplicado);
                    break;
                case 2:
                    _viewModel.SetBonusDestreza(_bonusAplicado);
                    break;
                case 3:
                    _viewModel.SetBonusConstituicao(_bonusAplicado);
                    break;
                case 4:
                    _viewModel.SetBonusInteligencia(_bonusAplicado);
                    break;
                case 5:
                    _viewModel.SetBonusSabedoria(_bonusAplicado);
                    break;
                case 6:
                    _viewModel.SetBonusCarisma(_bonusAplicado);
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
