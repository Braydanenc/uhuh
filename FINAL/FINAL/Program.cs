using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL
{
    class Program
    {
        static void Main()
        {
            int opcion;
            int num1 = 0;
            int num2 = 0;
            Console.Clear();
            Console.WriteLine("PROYECTO FINAL");
            Console.WriteLine();
            Console.WriteLine("1. CALCULADORA");
            Console.WriteLine("2. AGENDA");
            Console.WriteLine("3. SALIR");
            Console.WriteLine();
            Console.WriteLine("ELIJA LA OPCION DESEADA: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: AbrirCalculadora();
                    break;
                case 2: AbrirAgenda();
                    break;
                case 3: Salir();
                    break;
                default: Console.WriteLine("DIGITE UN VALOR ACEPTADO");
                    break;
            }
            Console.ReadKey();

        }

        static void AbrirCalculadora()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("CALCULADORA");
            Console.WriteLine();
            Console.WriteLine("1. SUMAR");
            Console.WriteLine("2. RESTAR");
            Console.WriteLine("3. MULTIPLICAR");
            Console.WriteLine("4. DIVIDIR");
            Console.WriteLine();
            Console.WriteLine("5. VOLVER");
            Console.WriteLine("6. SALIR");
            Console.WriteLine();
            Console.WriteLine("ELIJA LA OPCION DESEADA: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Sumar(); break;
                case 2: Restar(); break;
                case 3: Multiplicar(); break;
                case 4: Dividir(); break;
                case 5: VolverMenuPrincipal(); break;
                case 6: Salir(); break;

                default: Console.WriteLine("DIGITE UN VALOR ACEPTADO");
                    break;
            }

        }

        static void AbrirAgenda()
        {
            int opcion;
            Console.Clear();
            Console.WriteLine("AGENDA");
            Console.WriteLine();
            Console.WriteLine("1. CONTACTOS");
            Console.WriteLine("2. EVENTOS");
            Console.WriteLine("3. VOLVER");
            Console.WriteLine("4. SALIR");
            Console.WriteLine();
            Console.WriteLine("ELIJA LA OPCION DESEADA: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: ManejarContactos();
                    break;
                case 2: ManejarEventos();
                    break;
                case 3: VolverMenuPrincipal();
                    break;
                case 4: Salir();
                    break;
                default: Console.WriteLine("DIGITE UN VALOR ACEPTADO");
                    break;
            }
        }

        static void ManejarContactos()
        {
            Console.WriteLine("AQUI VAN LAS 3 OPCIONES DE CONTACTOS");
            Console.ReadKey();
            AbrirAgenda();
        }

        static void ManejarEventos()
        {
            Console.WriteLine("AQUI VAN LAS 3 OPCIONES DE EVENTOS");
            Console.ReadKey();
            AbrirAgenda();
        }

        static void Salir()
        {
            Console.Write("GoodBye...");
        }

        static int Sumar(int num1, int num2)
        {
            AbrirCalculadora();
            int resultado;
            Console.Clear();
            Console.WriteLine("SUMANDO");
            Console.Write("DIGITE EL PRIMER NUMERO: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("DIGITE EL SEGUNDO NUMERO: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;
            return resultado;




        }

        static int Restar()
        {
            Console.WriteLine("RESTANDO");
            Console.ReadKey();
            AbrirCalculadora();
            return 0;
        }
        static int Multiplicar()
        {
            Console.WriteLine("MULTIPLICANDO");
            Console.ReadKey();
            AbrirCalculadora();
            return 0;

        }
        static int Dividir()
        {
            Console.WriteLine("DIVIDIENDO");
            Console.ReadKey();
            AbrirCalculadora();
            return 0;
        }

        static void VolverMenuPrincipal()
        {
            Main();
        }


    }
}
