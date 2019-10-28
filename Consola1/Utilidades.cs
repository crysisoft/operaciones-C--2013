using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Utilidades
    {

        private bool ordenar = false;

        public bool Ordenar
        {
            get { return ordenar; }
            set { ordenar = value; }
        }


        public void preguntarSiOrdernar()
        {
            Console.WriteLine("Desea ordenar los números Y/N");
            string respuesta = Console.ReadLine();

            switch (respuesta.ToUpper())
            {
                case "Y": this.ordenar = true;
                    break;
                case "N": this.ordenar = false;
                    break;
                default:
                    Console.WriteLine("ERROR solo se permite Y o N");
                    Console.ReadKey();
                    Console.Clear();
                    preguntarSiOrdernar();
                    break;
            }
        }

        public float buscarMayorMenor(float numeroUno, float numeroDos,bool mayor)
        {
            if (mayor){
                if (numeroUno > numeroDos)
                {
                    return numeroUno;
                }
            }
            else
            {
                if (numeroUno < numeroDos)
                {
                    return numeroUno;
                }
            }           

            return numeroDos;
        }
       

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
