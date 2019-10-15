using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Consola1
{
    class Operaciones:Utilidades
    {
        float numeroUno;
        float numeroDos;       
        float resultado;
        
        public float NumeroUno
        {
          get { return numeroUno; }
          set { numeroUno = value; }
        }

        public float NumeroDos
        {
            get { return numeroDos; }
            set { numeroDos = value; }
        }

        public float Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }


        public void Init(string mensaje)
        {
            Console.WriteLine(mensaje);
            NumeroUno = leerNumeroYAsignar("Entre el primer número");
            NumeroDos = leerNumeroYAsignar("Entre el segundo número");           
        }


        public void darSalida(float suma)
        {
            Console.WriteLine("El resultado es: "+String.Format(CultureInfo.InvariantCulture,"{0:0.00}",suma));
            Console.ReadKey();
        }


        public int operacion(float a, float b)
        {
            return 0;
        }

    }
}
