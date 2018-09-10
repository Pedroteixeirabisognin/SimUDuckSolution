using System;
using SimUDuck.Interfaces;
using SimUDuck.Patos;
namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
 

            Console.WriteLine("Pato Selvagem");
            IPato patoSelvagem = new PatoSelvagem();
            patoSelvagem.Grasnar();
            patoSelvagem.Voar();
            patoSelvagem.Nadar();
            patoSelvagem.Nadar("Rapido");

            Console.WriteLine("Pato Cabeca Vermelha");
            IPato patoCabecaVermelha = new PatoCabecaVermelha();
            patoCabecaVermelha.Grasnar();
            patoCabecaVermelha.Nadar();
            patoCabecaVermelha.Voar();

            Console.ReadLine();

        }
    }
}
