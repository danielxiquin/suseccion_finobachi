using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_sucesión_Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int A = 0;
            int B = 1;
            int C = 0;
            int i = 2;
            bool repetir =true;

            

            while (repetir == true)
            {
                try
                {
                    Console.WriteLine("Ingrese un numero");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num > 0)
                    {
                        
                        Console.WriteLine("Resultado=" + A);

                        if (num > 1)
                        {
                            
                            Console.WriteLine("Resultado+=" + B);
                            if (i < num)
                            {
                                C = A + B;
                                
                                Console.WriteLine("Resultado +=" + C);
                                A = B;
                                B = C;
                                i = i++;

                            }

                        }
                    }

                }
                catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                
                }

                
            }
            Console.WriteLine("Ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

        }
    }
}
