using ConsoleApp3.Models;
using System;

namespace Poo
{
    class Program
    {
        static void Main()
        {
            animales miperro = new Perro();
            animales migato = new Gato();


            miperro.sonidoAnimal();
            migato.sonidoAnimal();
        }
    }
}