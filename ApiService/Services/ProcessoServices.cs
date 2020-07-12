using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiService.DAO;
using ApiService.Models;

namespace ApiService.Services
{
    public class ProcessoServices : IProcessoServices
    {
        private readonly DataContext _context;

        public ProcessoServices(DataContext context)
        {
            _context = context;
        }
        public void AdicionarProcesso(Processo processo)
        {
            _context.Add(processo);
            _context.SaveChanges();
            
        }

        public List<Processo> ListarProcesso()
        {
            return _context.Processos.ToList();

        }

        public Boolean VerificarProcesso(string numeroProcesso)
        {
           return  _context.Processos.Where(x => x.NumeroDoProcesso == numeroProcesso).Any() ? true : false;
        }
    }
}
