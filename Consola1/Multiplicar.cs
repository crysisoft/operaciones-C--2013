using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Multiplicar : Operaciones
    {
        public void Iniciar()
        {
            Init("Vamos a multiplicar dos números");
            Resultado = operacion(NumeroUno, NumeroDos);
            darSalida(Resultado);
        }

        static int operacion(int a, int b)
        {

            return a * b;
        }
    }
}
