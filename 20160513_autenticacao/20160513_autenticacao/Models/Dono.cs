using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20160513_autenticacao.Models
{
    public class Dono
    {
        [Key]
        public int DonoId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(9, ErrorMessage = "O {0} tem de ter {2} caracteres.", MinimumLength = 9)]
        public string NIF { get; set; }
    }
}