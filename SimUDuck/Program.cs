using System;
using System.Collections;
using System.Collections.Generic;
using SimUDuck.Interfaces;
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


            List<IPato> lista = new List<IPato>() { new PatoCabecaVermelha(), new PatoSelvagem()};

            foreach (var item in lista)
            {
                Console.WriteLine("Pato testando:\n");
                item.Grasnar();

            }

            Console.ReadLine();

        }
    }
}
