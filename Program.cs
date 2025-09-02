using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cáculo_de_promedio_ponderado
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Ingrese la nota1:");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota2:");
            int nota2=int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la nota3:"); 
            int nota3= int.Parse(Console.ReadLine());

            

            double promedioponderado;
            double promedio1;
            double promedio2;
            double promedio3;

            
           

            double peso1 = 27;
            double peso2 = 13;
            double peso3 = 60;
           
            // calculo

            promedio1 = nota1 * (peso1 / 100);
            promedio2 = nota2 * (peso2 / 100);
            promedio3 = nota3 * (peso3 / 100);

            promedioponderado = promedio1 + promedio2 + promedio3;

            Console.WriteLine("El promedio ponderado es:" + promedioponderado); 




        }
    }
}
