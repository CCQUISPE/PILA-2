using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PILA_2
{
    class Program
    {


        static void Main(string[] args)
        {

            Stack miPila = new Stack();

            //Console.Clear();
            Console.WriteLine("\n El sigeuinte programa muestra el factorial del valor ingresado \n");

            Console.Write("\n Ingrese valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());
            if (valor  < 0)
            {
                 Console.WriteLine("Solo números positivos");
            }
            else
            {
                int total = 1;
                int cont;
                cont = valor;
                for (byte i = 0; i < valor; i++)
                {

                    miPila.Push(cont);
                    total = total * cont;
                    cont = cont - 1;
                }
                imprimir(miPila, valor);
                Console.WriteLine("\nEL TOTAL DEL FACTORIAL ES: {0}", total);
                Console.ReadKey();
            }
        }
        /** Imprime pila */
        static void imprimir(Stack pila, int val)
        {
            if (pila.Count != 0)
            {
                int valores=0;
 
                for (byte i = 0; i <= val; i++) // arma el bucle para recorrer la pila
                {
                    valores = (int)pila.Pop(); // desencola la pila con Pop
                    Console.WriteLine(valores);         // imprime por pantalla

                }

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("La Pila esta vacia");
            }
        }



    }
}
