using System;
using System.Collections.Generic;
using System.Text;

namespace Consola1
{
    class Dividir:Operaciones
    {
        public void Iniciar()
        {
            Init("Vamos Dividir dos números");
            Resultado = operacion(NumeroUno, NumeroDos);
            darSalida(Resultado);
        }

        static float operacion(float a, float b)
        {         

            return a / b;
        }
    }
}
