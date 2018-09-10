using SimUDuck.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    class PatoSelvagem : IPato
    {
        public void Grasnar()
        {
            Console.WriteLine("PatoSelvagem está grasnando");
        }

        public void Nadar()
        {
            Console.WriteLine("PatoSelvagem está nadando");
        }

        public void Nadar(string nome)
        {
            Console.WriteLine("PatoSelvagem está "+ nome);
        }

        public void Voar()
        {
            Console.WriteLine("PatoSelvagem está voando");
        }
    }
}
