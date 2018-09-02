using Service.Contrato;
using Service.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enum.TipoMoeda;

namespace Service.Conversao
{
    public class InputDolar : IConverter
    {
        public double ConverteMoedaSaida(Moeda entrada, Moeda saida, double valor)
        {
            double valorRetorno = 0;

            switch (saida)
            {
                case Moeda.Euro:
                    valorRetorno = ConverterParaEuro(valor);
                    break;

                case Moeda.Real:
                    valorRetorno = ConverterParaReal(valor);
                    break;
            }

            return valorRetorno;
        }


        //Convertendo de Dolar para Real
        //1 Dolar é igual a 4,06 Reais
        private double ConverterParaReal(double valor)
        {
            double valorReal = 4.06;

            double calculo = valor * valorReal;
            return calculo;
        }

        //Convertendo de Dolar para Euro
        //1 Dolar é igual a 0,86 Euros
        private double ConverterParaEuro(double valor)
        {
            double valorEuro = 0.86;

            double calculo = valor * valorEuro;
            return calculo;
        }
    }
}
