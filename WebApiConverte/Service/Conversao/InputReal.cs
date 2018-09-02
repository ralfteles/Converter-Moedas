using Service.Contrato;
using Service.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enum.TipoMoeda;

namespace Service.Conversao
{
    public class InputReal : IConverter
    {
        public double ConverteMoedaSaida(Moeda entrada, Moeda saida, double valor)
        {
            double valorRetorno = 0;

            switch (saida)
            {
                case Moeda.Dolar:
                    valorRetorno = ConverterParaDolar(valor);
                    break;

                case Moeda.Euro:
                    valorRetorno = ConverterParaEuro(valor);
                    break;
            }

            return valorRetorno;
        }


        //Convertendo de Real para Dolar
        //1 Real é igual a 0.25 Dolar
        private Double ConverterParaDolar(double value)
        {
            double valorDolar = 0.25;

            double calculo = value * valorDolar;
            return calculo;
        }

        //Convertendo de Real para Euro
        //1 Real é igual a 0.21 Dolar
        private Double ConverterParaEuro(double value)
        {
            double valorEuro = 0.21;

            double calculo = value * valorEuro;
            return calculo;
        }
    }
}
