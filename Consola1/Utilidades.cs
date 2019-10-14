using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Utilidades
    {

        public int leerNumeroYAsignar(string mensaje)
        {
            string valorInicial = "";

            Console.WriteLine(mensaje);
            valorInicial = Console.ReadLine();

            return validarNumero(valorInicial);
        }

        public int validarNumero(string valor)
        {
            int numero = 0;
            bool esNumero = int.TryParse(valor, out numero);

            if (esNumero)
            {
                return numero;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("ERROR:Solo se permiten números enteros ");
                Console.WriteLine("Presione enter para continuar ");
                Console.ReadKey();
                return leerNumeroYAsignar("");
            }
        }
    }
}
