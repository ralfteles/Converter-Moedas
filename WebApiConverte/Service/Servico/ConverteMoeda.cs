using Service.Contrato;
using Service.Conversao;
using Service.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enum.TipoMoeda;

namespace Service.Servico
{
    public class ConverteMoeda : IConverteMoeda
    {
        private  InputReal real;
        private  InputDolar dolar;
        private  InputEuro euro;

        public ConverteMoeda()
        {
            this.real = new InputReal();
            this.dolar = new InputDolar();
            this.euro = new InputEuro();
        }

        public double Converter(Moeda entrada, Moeda saida, double valor)
        {
            double valorConvertido = 0;
            switch (entrada)
            {
                case Moeda.Dolar:
                    valorConvertido = this.dolar.ConverteMoedaSaida(entrada, saida, valor);
                    break;

                case Moeda.Euro:
                    valorConvertido = this.euro.ConverteMoedaSaida(entrada, saida, valor);
                    break;

                case Moeda.Real:
                    valorConvertido = this.real.ConverteMoedaSaida(entrada, saida, valor);
                    break;
            }

            return valorConvertido;
        }

    }
}
