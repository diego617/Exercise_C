using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            string messge = "No cuentas con la cantidad suficiente";
            int cuenta = 100;
            int cantidad;

            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine($"Monto a Retirar: {cantidad}");

            if (cantidad <= cuenta && cantidad >= 1) {
                if(cantidad % 20 == 0) {
                    int res = cantidad / 20;
                    Console.WriteLine($"resultado: {res}");
                    cuenta -= cantidad;
                    Console.WriteLine($"Tu saldo: {cuenta}");
                }
                else {
                    Console.WriteLine("Solo Puedes retirar billestes de 20");
                }
            }
            else {
                Console.WriteLine(messge);
            }

            Console.ReadKey();
        }
    }
}
