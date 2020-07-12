using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.Models;

namespace ApiService.Services
{
    interface IProcessoServices
    {
        void AdicionarProcesso(Processo processo);

        List<Processo> ListarProcesso();

        Boolean VerificarProcesso(string numeroProcesso);
    }
}
