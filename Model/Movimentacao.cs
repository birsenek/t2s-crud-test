using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudT2S.Model
{
    public class Movimentacao
    {
        [Key]

        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Navio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"(\bEmbarque\b)|(\bDescarga\b)|(\bGate In\b)|(\bGate Out\b)|(\bPosicionamento Pilha\b)|(\bPesagem\b)|(\bScanner\b)", 
            ErrorMessage = "Embarque, Descarga, Gate In, Gate out, Posicionamento Pilha, Pesagem, Scanner")]

        public string TipoMovimentacao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A data deve ser dd/mm/aaaa")]
        [Column(TypeName = "date")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Date, ErrorMessage = "A data deve ser dd/mm/aaaa")]
        [Column(TypeName = "date")]
        public DateTime DataFim { get; set; }
    }

   
}
