using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Gato : animales
    {
        public override void sonidoAnimal()
        {
            Console.WriteLine("El gato hace miau miau");
        }
    }
}
