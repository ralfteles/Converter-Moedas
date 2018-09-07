using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contrato;
using Service.Enum;

namespace WebApiConverte.Controllers
{
    [Produces("application/json")]
    [Route("api/converter")]
    [EnableCors("CorsPublic")]
    public class ConverterController : Controller
    {
        private readonly IConverteMoeda _converter;

        public ConverterController(IConverteMoeda converter)
        {
            _converter = converter;
        }

        [HttpGet]
        public string Get()
        {
            return "API rodando com sucesso!";
        }

        [HttpGet]
        [Route("GetConverteMoeda/entrada/{entrada}/saida/{saida}/valor/{valor}")]
        public ActionResult GetCalcular(TipoMoeda.Moeda entrada, TipoMoeda.Moeda saida, double valor)
        {
            try
            {
                var valorMoeda = _converter.Converter(entrada, saida, valor);

                return new ObjectResult(valorMoeda.ToString("N2"));
            }
            catch (Exception)
            {
                return new ObjectResult("Ops! Ocorreu um erro ao tentar converter a moeda");
            }
        }
    }
}