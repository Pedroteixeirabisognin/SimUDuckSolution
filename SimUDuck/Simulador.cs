using SimUDuck.Interfaces;
using SimUDuck.Patos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    public class Simulador
    {
        public void Executar(IPato pato)
        {
            pato.Grasnar();
            pato.Nadar();
            pato.Voar();
       
        }

 
    }
}
