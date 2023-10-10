using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //Implementa operações aritméticas
    class static Aritmetica
    {
        //Tipo de conversão de temperatura a executar
        public enum ConversaoTemperatura
        {
            Nulo=0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        //Operação Soma
        //Retorna a soma de dois números
        public static int Somar(int x, int y) 
        {
            return x + y;
        }

        //Operação Subtração
        //Retorna o resultado da subtração de dois números
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            else
                return -1;
        }


    }
}
