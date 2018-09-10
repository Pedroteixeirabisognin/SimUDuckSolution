using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck.Patos
{
    public abstract class Pato
    {
        private String nome;
        public string Nome { get => nome; set => nome = value; }
        
        public void Grasnar()
        {
            Console.WriteLine("Grasnando");
        }

        public virtual void Voar()
        {
            Console.WriteLine("Voando");

        }

        public void Nadar()
        {
            Console.WriteLine("Nadando");

        }

        public void Nadar(String acao)
        {
            Console.WriteLine("Nadando "+acao);

        }

    }


}
