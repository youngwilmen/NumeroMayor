using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostrar_numero_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Aqui el programa imprimira los nombres y matriculas de los integrantes del grupo "Los expositores"
            Console.WriteLine("Integrantes del grupo Los Expositores");
            Console.WriteLine("Wilmen Linares    15-EISN-1-121");
            Console.WriteLine("Jose Garcia       11-MISN-1-069");
            Console.WriteLine("Raúl Florentino   15-MISN-1-156");
            Console.WriteLine("Carlos Martí      13-MISM-1-090");
            Console.WriteLine("Joel Rodríguez    14-EIST-1-112");
            Console.ReadLine();

            //Aqui desclaramos las variables que vamos a utilizar 
            int n1, n2, n3;
            string linea;
            string s1 = null;

            do
            {
                Console.Write("Ingrese el primer valor:");
                linea = Console.ReadLine();
                n1 = int.Parse(linea);
                Console.Write("Ingrese el segundo valor:");
                linea = Console.ReadLine();
                n2 = int.Parse(linea);
                Console.Write("Ingrese el tercer valor:");
                linea = Console.ReadLine();
                n3 = int.Parse(linea);

                if (n1 > n2)
                {
                    if (n1 > n3)
                    {
                        Console.ReadLine();
                        Console.WriteLine("El numero Mayor es:" + n1);
                        if (n2 > n3)
                        {
                            Console.Write("El numero Menor es:" + n3);
                        }
                        else
                        {
                            Console.Write("El numero Menor es:" + n2);
                        }
                    }
                    else
                    {
                        Console.ReadLine();
                        Console.WriteLine("El numero Mayor es:" + n3);
                        if (n1 > n2)
                        {
                            Console.Write("El numero Menor es:" + n2);
                        }
                        else
                        {
                            Console.Write("El numero Menor es:" + n1);
                        }
                    }
                }
                else
                {
                    if (n2 > n3)
                    {
                        Console.ReadLine();
                        Console.WriteLine("El numero Mayor es:" + n2);
                        if (n1 > n3)
                        {
                            Console.Write("El numero Menor es:" + n3);
                        }
                        else
                        {
                            Console.Write("El numero Menor es:" + n1);
                        }
                    }
                    else
                    {
                        Console.WriteLine("El numero Mayor es:" + n3);
                        if (n1 > n2)
                        {
                            Console.Write("El numero Menor es:" + n2);
                        }
                        else
                        {
                            Console.Write("El numero Menor es:" + n1);
                        }
                    }
                }
                Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Deseas continuar ejecutando la aplicacion? (S/N)");
                s1 = Console.ReadLine();

            }
            while (s1 == "s" || s1 == "S"); // "s" o "S" <- son validas  
        }
    }
}

