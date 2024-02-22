using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class lampada
    {
        public int potencia;
        public string tipo;
        public double preco;
        public bool Aceso = false;


        public bool ligar()
        {
            Aceso = true;
            return Aceso;
        }

        public bool Desligar()
        {
            Aceso = false;
            return Aceso;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            lampada l1 = new lampada();
            l1.potencia = 100; l1.preco = 32.5;
            l1.ligar();l1.Desligar();
            if (l1.Aceso == true) 
            {
                Console.WriteLine("Aceso");
            }
            else
            {
                Console.WriteLine("Apagado");
            }
        }
    }
}
