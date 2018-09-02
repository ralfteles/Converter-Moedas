using Service.Contrato;
using Service.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enum.TipoMoeda;

namespace Service.Conversao
{
    public class InputEuro : IConverter
    {
        public double ConverteMoedaSaida(Moeda entrada, Moeda saida, double valor)
        {
            double valorRetorno = 0;

            switch (saida)
            {
                case Moeda.Real:
                    valorRetorno = ConverterParaReal(valor);
                    break;

                case Moeda.Dolar:
                    valorRetorno = ConverterParaDolar(valor);
                    break;
            }

            return valorRetorno;
        }

        //Convertendo de Euro para Dolar
        //1 Euro é igual a 4,71 Reais
        private double ConverterParaReal(double valor)
        {
            double valorReal = 4.71;

            double calculo = valor * valorReal;
            return calculo;
        }

        //Convertendo de Euro para Real
        //1 Euro é igual a 1,16 Dolares
        private double ConverterParaDolar(double valor)
        {
            double valorDolar = 1.16;

            double calculo = valor * valorDolar;
            return calculo;
        }
    }
}
