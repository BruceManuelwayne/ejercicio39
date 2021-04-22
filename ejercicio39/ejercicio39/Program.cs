using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            string input; 
            int[] numerosArray = new int[5];
            // bool numeroValido = true; 

            for(int indice = 0; indice<numerosArray.Length; indice++)
            {
                Console.WriteLine($"Ingrese un numero para la psociion {indice}");
                bool ok = false;
                while(!ok)
                {
                    input = Console.ReadLine();
                    ok = int.TryParse(input, out numerosArray[indice]); 
                }
                
            }
            Array.Sort(numerosArray);
            foreach (int value in numerosArray)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

        }
    }
}
