using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWindow.Models
{
    public class Cadastro
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="O campo Nome é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage ="Nome deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Caracter inválido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sobrenome é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Sobrenome deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage ="Caracter inválido.")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "O campo Data é necessário.")]
        [DataType(DataType.DateTime, ErrorMessage ="Data em formato inválido.")]
        [Display(Name ="Data de Cadastro")]
        public DateTime DataAtual { get; set; }
        
        [Required(ErrorMessage = "O campo País é necessário.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "País deve conter de 3 à 20 caracteres.")]
        [RegularExpression(@"^[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Caracter inválido.")]
        public string  Pais { get; set; }
    }
}
