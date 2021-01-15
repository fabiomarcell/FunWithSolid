using FunWithSolid.Interface;
using FunWithSolid.Service;
using System;
using System.Linq;

namespace FunWithSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ResolveOptions(args);
            }
            catch
            {
                Console.WriteLine("------");
                Console.WriteLine("");Console.WriteLine("");Console.WriteLine("");
                Console.WriteLine("Help: ");
                Console.WriteLine("");
                Console.WriteLine("-f: criar ficha de personagem");
            }
        }

        private static void ResolveOptions(string[] args)
        {
            //interface web, essa etapa seria desnecessária
            var needsHelp = true;
            args = args.Select(t => t.Trim().ToLower()).ToArray();
            if (args.Any(t => t == "-f"))
            {
                //simulando uma view model
                FakeModel fakeModel = MountFichaModel();
                needsHelp = false;

                var rf = DefineResolverFicha(fakeModel);

                new ServiceFicha(rf).ResolverFicha();

                Console.ReadLine();

            }

            if (needsHelp)
            {
                throw new ArgumentException();
            }
        }

        private static IModificadoresFicha DefineResolverFicha(FakeModel fakeModel)
        {
            switch (fakeModel.Raca)
            {
                case 1:
                    return new ModificadoresFichaHumano(fakeModel);
                default:
                    throw new ArgumentException();
            }
        }

        private static FakeModel MountFichaModel()
        {
            var model = new FakeModel();

            try
            {
                Console.WriteLine("Nome: ");
                model.Nome = Console.ReadLine();

                do
                {
                    Console.WriteLine("Raça: 1- Humano, 2 - Elfo");
                    model.Raca = Convert.ToInt32(Console.ReadLine());
                } while (!model.RacaPermitida());

                Console.WriteLine("Defina sua Força: ");
                model.Forca = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Defina sua Destreza: ");
                model.Destreza = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Defina sua Constituicao: ");
                model.Constituicao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Defina sua Inteligencia: ");
                model.Inteligencia = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Defina sua Sabedoria: ");
                model.Sabedoria = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Defina seu Carisma: ");
                model.Carisma = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (!model.IsValid())
                {
                    Console.WriteLine("Todos os dados precisam ser preenchidos.");
                    return MountFichaModel();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Falha na conversão de valores. Tente novamente...");
                return MountFichaModel();
            }
            

            return model;
        }
    }

    public class FakeModel : IFakeViewModel
    {
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Constituicao { get; set; }
        public int Inteligencia { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
        public string Nome { get; set; }
        public int Classe { get; set; }
        public int Raca { get; set; }

        public bool IsValid()
        {
            return Forca != 0 && Destreza != 0 && Constituicao != 0 && Inteligencia != 0
                    && Sabedoria != 0 && Carisma != 0 && Nome.Trim() != "" && Raca != 0;
        }

        public bool ClassePermitida()
        {
            return Classe > 0 && Classe < 3;
        }

        public bool RacaPermitida()
        {
            return Raca > 0 && Raca < 3;
        }


        void IFakeViewModel.SetBonusForca(int val)
        {
            Forca += val;
        }

        void IFakeViewModel.SetBonusDestreza(int val)
        {
            Destreza += val;
        }

        void IFakeViewModel.SetBonusConstituicao(int val)
        {
            Constituicao += val;
        }

        void IFakeViewModel.SetBonusInteligencia(int val)
        {
            Inteligencia += val;
        }

        void IFakeViewModel.SetBonusSabedoria(int val)
        {
            Sabedoria += val;
        }

        void IFakeViewModel.SetBonusCarisma(int val)
        {
            Carisma += val;
        }

        int IFakeViewModel.GetForca()
        {
            return Forca;
        }

        int IFakeViewModel.GetDestreza()
        {
            return Destreza;
        }

        int IFakeViewModel.GetConstituicao()
        {
            return Constituicao;
        }

        int IFakeViewModel.GetInteligencia()
        {
            return Inteligencia;
        }

        int IFakeViewModel.GetSabedoria()
        {
            return Sabedoria;
        }

        int IFakeViewModel.GetCarisma()
        {
            return this.Carisma;
        }

        string IFakeViewModel.GetNome()
        {
            return this.Nome;
        }
    }

    public interface IFakeViewModel {
        internal void SetBonusForca(int val);
        internal void SetBonusDestreza(int val);
        internal void SetBonusConstituicao(int val);
        internal void SetBonusInteligencia(int val);
        internal void SetBonusSabedoria(int val);
        internal void SetBonusCarisma(int val);

        internal int GetForca();
        internal int GetDestreza();
        internal int GetConstituicao();
        internal int GetInteligencia();
        internal int GetSabedoria();
        internal int GetCarisma();
        internal string GetNome();
    }
}
