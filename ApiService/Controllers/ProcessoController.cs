using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Services;
using ApiService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiService.DAO;


namespace ApiService.Controllers

{
    [Route("v1/")]
    [ApiController]
    public class ProcessoController : Controller
    {
        private readonly IProcessoServices _services;
 
        public ProcessoController(DataContext dataContext)
        {
            _services = new ProcessoServices(dataContext);
        }

        [HttpPost]
        [Route("AdicionarProcesso")]
        public JsonResult AdicionarProcesso(Processo processo)
        {

            

            if (_services.VerificarProcesso(processo.NumeroDoProcesso))
            {
                 var vaRetorno = new
                {
                    Mensagem = "Já existe um processo com esse número"
                };

                return Json(vaRetorno);
            }

            _services.AdicionarProcesso(processo);

              var retorno = new
            {
                Mensagem = "Adicionado com sucesso"
            };

            return Json(retorno); 
        }

        [HttpGet]
        [Route("ListarProcesso")]
        public JsonResult ListarProcesso()
        {
            var vaProcessos = _services.ListarProcesso();

            return Json(vaProcessos);
        }

        [HttpGet]
        [Route("Grafico")]
        public JsonResult Grafico()
        {
            var vaProcessos = _services.ListarProcesso();
            int[] numero = new int[1];
            var vaRetorno = vaProcessos.Select(a => new
                                                        {
                                                            data = _services.ListarProcesso().Where(x => x.Escritorio == a.Escritorio).Count(),
                                                            label = a.Escritorio
                                                        });
            return Json(new { retorno = vaRetorno.Distinct() });

        }
    }
}