using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoCabecaVermelha : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato Cabeca Vermelha está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato Cabeca Vermelha está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato Cabeca Vermelha está "+nome);
        }

        public void Voar()
        {
            Console.WriteLine("Pato Cabeca Vermelha está grasnando");
        }
    }
}
