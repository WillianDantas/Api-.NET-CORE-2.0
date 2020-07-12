using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiService.Models
{
    public class Processo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Codigo { get; set; }
        public string NumeroDoProcesso { get; set; }
        public DateTime DataDeCriacaoDoProcesso { get; set; }
        public decimal Valor { get; set; }
        public string Escritorio { get; set; }
    }
}
