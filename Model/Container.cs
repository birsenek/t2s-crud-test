using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudT2S.Model
{
    public class Container
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"([A-Za-z]){4}\d{7}\b", ErrorMessage = "O código deve ser uma sequência de 4 letras e 7 númeoros")]
        [StringLength(11, ErrorMessage = "O código deve possuir 11 caracteres")]
        public string NumeroContainer { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"20|40", ErrorMessage = "O tipo deve ser 20 ou 40")]

        public int Tipo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"(\bCheio\b)|(\bVazio\b)", ErrorMessage = "O Status deve ser Cheio ou Vazio")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [RegularExpression(@"(\bImportacao\b)|(\bExportacao\b)", ErrorMessage = "A categoria deve ser Importacao ou Exportacao")]
        public string Categoria { get; set; }

        

    }


}
