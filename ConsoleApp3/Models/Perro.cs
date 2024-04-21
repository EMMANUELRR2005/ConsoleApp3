using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Perro : animales
    {
        public override void sonidoAnimal()
        {
            Console.WriteLine("El perro hace guau guau");
        }
        public override void piesAnimal()
        {
            Console.WriteLine("4 pies");
        }
    }
}
