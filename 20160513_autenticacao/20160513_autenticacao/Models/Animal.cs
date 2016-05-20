using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20160513_autenticacao.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }

        

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Especie { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Raca { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(6, MinimumLength = 1)]
        public float Peso { get; set; }

        // ? => é de preenchimento facultativo
        [DataType(DataType.Text)]
        [StringLength(6)]
        public float? Altura { get; set; }


    }
}