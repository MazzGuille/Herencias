using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Coche1 : Vehiculo
    {
        public void Arrancar()
        {
            Console.WriteLine("El coche esta arrancando");
        }

        public void Arrancar(string str)
        {
            Console.WriteLine($"{str} ha arrancado este coche a las: {DateTime.Now.TimeOfDay}.");
        }
        public int ruedas { get; set; }
        public int Detener { get; set; }
        public void Detenerse()
        {
            Console.WriteLine("El coche esta deteniendo");
        }
        
        
    }
}