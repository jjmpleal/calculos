using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    //Implementa operações de Conversão
    internal static class Conversoes
    {
        //Tipo de conversão de temperatura a executar
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        //Conversão de temperaturas
        // parâmetro conversao é a conversão a efetuar
        // parâmetro temepratura é a temperatura a converter
        // return retorna o resultado da conversão
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
