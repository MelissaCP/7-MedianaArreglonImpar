using System;
using System.Collections.Generic;
using System.Linq;
using C = System.Console;

namespace _7_MedianaArreglonImpar
{
    class Program
    {
        /// Practica 7
        /// 7.- Encontrar la mediana de un arreglo de n números, donde n es impar.

        /// Chávez Pérez Melissa
        /// #M21210035

        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            // Declaración del array
            int[] num;
            int cant = 0;
            // ushort cant = 0;


            do
            {
                try
                {

                    C.Write("\nFavor de Ingresar cuantos numeros desea ingresar al vector ");
                    cant = UInt16.Parse(C.ReadLine());

                }
                catch
                {
                    continue;
                }
            } while (cant == 0);

            // Instanciación del array
            num = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                C.Write("Escribe el numero {0}: ", i);

                num[i] = UInt16.Parse(C.ReadLine());


            }
            C.WriteLine("Introducidos los {0} valores", cant);

            C.WriteLine("Pulsa INTRO para listarlos");



            string a = C.ReadLine();




            for (int i = 0; i < cant; i++)

            {
                C.WriteLine("Elemento {0}: {1}", i, num[i]);
                //var items = new[] { i, num[i] };
                // C.WriteLine(items);
            }
            C.WriteLine("El tamaño del arreglo es : " + cant);

            C.WriteLine("Encontrar mediana de V vector de una sola dimension");
        }
        //C.WriteLine("Los valores del vector son: {0}", v[0], v[1], v[2], v[3], v[4], v[5], v[6]);


        /*for (int i =0; i<cant; i++)
            {
            int n = num[i];

          int[] v = new int[cant];
         // C.WriteLine("La mediana es "+(num*2)/2)
          C.WriteLine("La mediana es " + v[(n / 2) + 1]);
            a = C.ReadLine(); 
        }*/
        private float[] longitud; //cant
            private float[] num;//num
            private float media;
            int cant = 0;

        // int[] v = new int[cant];

        public void CalcularMedia()
            {
            float suma;
            suma = 0;
            for(int i = 0; i < cant; i++)
            {
                suma = suma + num[i];
            }
            media = suma / 2;
            C.WriteLine("La media es: " + media);
            C.ReadKey();
            //}
        }
    }
}


