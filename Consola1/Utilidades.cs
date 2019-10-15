using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Utilidades
    {

        public float leerNumeroYAsignar(string mensaje)
        {
            string valorInicial = "";

            Console.WriteLine(mensaje);
            valorInicial = Console.ReadLine();

            return validarNumero(valorInicial);
        }

        public float validarNumero(string valor)
        {
            float numero = 0;
            bool esNumero = float.TryParse(valor, out numero);

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
