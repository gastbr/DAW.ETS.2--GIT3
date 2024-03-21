using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAW.ETS._2__GIT3
{
    internal class Mono : Animal
    {
        int edad;
        public Mono()
        {
            AsignaEdad();
            AsignaSexo();
        }

        public void AsignaEdad()
        {
            Random rng = new Random();
            rng.Next(30); // se descartan los 30 primeros números
            edad = rng.Next(21);
        }
        public void Imprime()
        {
            Console.WriteLine($"Un mono {sexo} de {edad} años.");

        }
    }
}
