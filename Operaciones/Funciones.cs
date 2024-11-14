using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Funciones
    {
        public int Potencia(int numA, int numB)
        {
            int potencia = numA;
            for (int i = 0; i < numB; i++)
            {
                potencia = potencia * numA;
            }
            return potencia;
        }

        public float Dividir(int numA,int numB)
        {
            if (numB != 0)
            {
                return numA / numB;
            }
            else{
                Console.WriteLine("No se puede dividir entre 0");
            }
        }

        public void Menu()
        {
            Console.WriteLine("Ingrese un número");
            int numA = Console.ReadLine();
            Console.WriteLine("Ingrese otro número");
            int numB = Console.ReadLine();

            Console.WriteLine("Eija una opcion:");
            Console.WriteLine("\n   (1) Potencia \n   (2) Dividir");
            int menu = Console.ReadLine();
            switch (menu)
            {
                case 1:
                    Potencia(numA, numB);
                case 2:
                    Dividir(numA, numB);
            }
        }
    }
}
