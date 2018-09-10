using System;
using SimUDuck.Patos;
namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulador simulador = new Simulador();
            simulador.Executar(new PatoCabecaVermelha());
            simulador.Executar(new PatoSelvagem());
            simulador.Executar(new PatoReal());

            Console.ReadLine();

        }
    }
}
