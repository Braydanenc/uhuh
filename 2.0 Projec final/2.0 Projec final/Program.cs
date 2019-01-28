using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_Projec_final
{
    class Program
    {
        static void Main()
        {
                do
                {
                    string option;

                    Console.WriteLine("seleccione la opcion deseada");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                    Console.WriteLine(SALIR);
                    Console.WriteLine("");

                    option = (Console.ReadLine());

                    switch (option)
                    {
                        case A:
                            agenda();
                            break;
                        case C:
                            string opction;
                            int n1, n2;
                            Console.WriteLine("elija una opcion");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine(S);
                            Console.WriteLine(R);
                            Console.WriteLine(M);
                            Console.WriteLine(D);
                            Console.WriteLine(MENU);
                            opction = Console.ReadLine();


                            switch (opction)
                            {
                                case S:
                                    Console.WriteLine("dijite un numero");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("dijite un segundo numero");
                                    n2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(n1 + n2);
                                    break;
                                case R:
                                    Console.WriteLine("dijite un numero");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("dijite un segundo numero");
                                    n2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(n1 - n2);
                                    break;
                                case M:
                                    Console.WriteLine("dijite un numero");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("dijite un segundo numero");
                                    n2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(n1 * n2);
                                    break;

                                case D:
                                    Console.WriteLine("dijite un numero");
                                    n1 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("dijite un segundo numero");
                                    n2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine(n1 / n2);
                                    break;

                                case MENU:
                                    Console.Clear();
                                    string reset =
                                   "selecciones una opcion";

                                    Console.WriteLine("seleccione la opcion deseada");
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine(A);
                                    Console.WriteLine(C);
                                    Console.WriteLine("");


                                    if (reset == "SI")
                                    {
                                        //CODIGO

                                    }
                                    Console.ReadLine();
                                    break;
                            }
                            break;
                        case SALIR:
                            Environment.Exit(0);
                            break;

                    }
                }
                while (opction != SALIR);

            }
            catch (Exception error)
            {

                Console.WriteLine("haz echo algo mal ");
                Console.WriteLine("revisa bien");
                Console.WriteLine("hay mijo que tengo que hacer con tigo");

            }

        }
        static void agenda()
        {
            string opciones;
            Console.Clear();
            Console.WriteLine("elija la opcion  deseada");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(CALENDARIO);
            Console.WriteLine(EVENTOS);
            Console.WriteLine(MENU);
            Console.WriteLine();
            opciones = (Console.ReadLine());

            switch (opciones)
            {
                case CALENDARIO:
                    contacto();
                    break;
                case EVENTOS:

                    try
                    {
                        DateTime agenda1;
                        string informacion;
                        Console.WriteLine("elija una opcion");
                        Console.WriteLine("");
                        Console.WriteLine(VER_EVENTOS);
                        Console.WriteLine(A);
                        Console.WriteLine(MENU);

                        switch ((Console.ReadLine()))
                        {

                            case VER_EVENTOS:
                                Console.WriteLine(informacion + agenda1);

                                break;
                            case A:
                                Console.WriteLine("");
                                Console.WriteLine("hola desea agregar un nuevo evento");
                                Console.WriteLine("solo escriba la fecha del evento");
                                agenda1 = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("escriba la informacion del evento ");
                                Console.WriteLine("");
                                informacion = Console.ReadLine();
                                Console.WriteLine(informacion + agenda1);
                                break;

                            case MENU:
                                Console.Clear();

                                Console.WriteLine("seleccione la opcion deseada");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine(A);
                                Console.WriteLine(C);
                                Console.WriteLine("");

                            
                                if ("selecciones una opcion" == "SI")
                                {
                                    //CODIGO

                                }
                                Console.ReadLine();
                                break;

                            

                        }
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("hay un error verifica que todo esta debidamente escrcito");
                        Console.WriteLine("creo que el problema es de espacio no tienes espaciosuficiente para almacenar si los" +
                        "si los problemas persisten entonces mejora el programa");
                    }

                    break;
                case MENU:
                    Console.Clear();
                    string reset =
                   "selecciones una opcion";

                    Console.WriteLine("seleccione la opcion deseada");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine(A);
                    Console.WriteLine(C);
                    Console.WriteLine("");

                case "S.MENU"
                    main(args);
                    break;

                    if (reset == "SI")
                    {
                        //CODIGO

                    }
                    Console.ReadLine();
                    break;

            }

        }

        static void agregar()
        {
            try
            {
                DateTime agenda1, agenda2, agenda3, agenda4, agenda5, agenda6;
                string informacion;
                Console.WriteLine("");
                Console.WriteLine("hola desea agregar un nuevo evento");
                Console.WriteLine("solo escriba la fecha del evento");
                agenda1 = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("escraba la informacion del evento ");
                Console.WriteLine("");
                informacion = Console.ReadLine();
                Console.WriteLine(informacion + agenda1);
            }
            catch (Exception error)
            {
                Console.WriteLine("hay un error verifica que todo esta debidamente escrcito");
                Console.WriteLine("creo que el problema es de espacio no tienes espaciosuficiente para almacenar si los" +
                "si los problemas persisten entonces mejora el programa");
            }
        }
        static void contacto()
        {
            do
            {
                string Menu;
                string nombre;
                int contacto1;
                Console.WriteLine("desea agregar o ver algun contacto");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(AGREGAR_CONTACTO);
                Console.WriteLine(ver_contacto);
                Console.WriteLine(volver);
                Menu = (Console.ReadLine());

                switch (Menu)
                    
                {
                    case GREGAR_CONTACTO:
                        Console.WriteLine("desea usted agregar un nuevo contacto");
                        Console.WriteLine("escriba el nombre del contacto");
                        nombre = Console.ReadLine();
                        Console.WriteLine("escriba el numero");
                        contacto1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;

                    case ver_contacto:
                        Console.WriteLine();
                        Console.WriteLine(nombre + contacto1);
                        break;

                    case volver:
                        Console.Clear();
                        string reset =
                       "selecciones una opcion";

                        Console.WriteLine("seleccione la opcion deseada");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine(A);
                        Console.WriteLine(C);
                        Console.WriteLine("");

                        if (reset == "SI")
                        {
                            
                        
                        }
                        Console.ReadLine();
                        break;

                }
                while (Menu = !volver) ;