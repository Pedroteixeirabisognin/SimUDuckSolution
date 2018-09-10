using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoReal : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("Pato real está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato real está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("Pato real está nadando" + nome);
        }

        public void Voar()
        {
            Console.WriteLine("Pato real está voando");
        }
    }
}
