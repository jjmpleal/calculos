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

        //Tipo de conversão de distâncias
        public enum ConversaoDistancia
        {
            Nulo =0,
            MetrosMilhas,
            MilhasMetros
        }

        //Conversão de temperaturas
        // parâmetro conversao é a conversão a efetuar
        // parâmetro temperatura é a temperatura a converter
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
            { 
                return -1; 
            }
        }

        //Conversão de distâncias
        // parâmetro conversao é a conversão a efetuar
        // parâmetro distância é a distânica a converter
        // return retorna o resultado da conversão da distância
        public static double ConverterDistancias(ConversaoDistancia conversao, double distancia)
        {
            if (conversao == ConversaoDistancia.MetrosMilhas)
            {
                return distancia * 0.0006213712;
            }
            else if (conversao == ConversaoDistancia.MilhasMetros)
            {
                return distancia * 1609.344;
            }
            else
            {
                return -1;
            }

        
        
        
        }

    }
}
