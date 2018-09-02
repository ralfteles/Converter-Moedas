using System;
using System.Collections.Generic;
using System.Text;
using static Service.Enum.TipoMoeda;

namespace Service.Contrato
{
    public interface IConverter
    {
        double ConverteMoedaSaida(Moeda entrada, Moeda saida, double valor);
    }
}
