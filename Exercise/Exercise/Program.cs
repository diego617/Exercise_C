using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            string messge = "No tienes suficiente cantiedad";
            int cuenta = 100;
            int cantidad = 0;
            Console.WriteLine($"Monto a Retirar: {cantidad}");
            cantidad = int.Parse(Console.ReadLine());
            
            if(cantidad <= cuenta && cantidad >= 1) {
                cuenta -=  cantidad;
                Console.WriteLine($"Tu saldo: {cuenta}");
            }
            else {
                Console.WriteLine(messge);
            }
            
           
            Console.ReadKey();
        }
    }
}
