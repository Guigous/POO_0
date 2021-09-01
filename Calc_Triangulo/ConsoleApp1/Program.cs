using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Declaracao de variavel da classe triangulo
            Triangulo x;
            Triangulo y;
            
            // Instanciar o Objeto
            x = new Triangulo();
            y = new Triangulo();

            //Input de Info do Usuario
            Console.WriteLine("Entre Com as Medidas do Triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.WriteLine("Entre Com as Medidas do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Formula de Herao
            double p=(x.A+x.B+x.C) / 2.0;
            double i=(y.A+y.B+y.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            double areaY = Math.Sqrt(i * (i - y.A) * (i - y.B) * (i - y.C));
            Console.WriteLine("O valor de Y e :" + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("O valor de X e :" + areaY.ToString("F4",CultureInfo.InvariantCulture));

            //Infos Usuario
            if (areaY > areaX) 
            {
                Console.WriteLine("O triangulo Y e o maior");
            }
            else
            {
                Console.WriteLine("O triangulo X e o maior");
            }
        }
    }
}
