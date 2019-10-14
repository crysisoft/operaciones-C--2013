using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Menus
    {
        int operacion;

        public void Iniciar()
        {
            Console.Clear();
            mostrarMenu();
            Console.WriteLine();
            leerOperacion();
            hacerMiOperacion();
        }

        static void mostrarMenu()
        {
            Console.WriteLine("############################");
            Console.WriteLine("### Sumar            1   ###");
            Console.WriteLine("### Restar           2   ###");
            Console.WriteLine("### Multiplicar      3   ###");
            Console.WriteLine("### Dividir          4   ###");
            Console.WriteLine("### Salir            5   ###");
            Console.WriteLine("############################");
        }

        private void leerOperacion()
        {
            Utilidades utilidad = new Utilidades();
            string ingreso_teclado;
            Console.WriteLine("Seleccione una opción");
            ingreso_teclado = Console.ReadLine();
            this.operacion = utilidad.validarNumero(ingreso_teclado);

        }

        public void hacerMiOperacion()
        {
            switch (operacion)
            {
                case 1:
                    Sumar suma = new Sumar();
                    suma.Iniciar();
                    break; 
                case 2:
                    Restar resta = new Restar();
                    resta.Iniciar();
                    break; 
                case 3:
                    Multiplicar multiplica = new Multiplicar();
                    multiplica.Iniciar();
                    break;
                case 5:
                    Environment.Exit(1);
                    break;
                
                default:
                    Console.WriteLine("Opción no valida");
                    Console.ReadKey();
                    break;
            }

            Iniciar();
        }
    }
}
