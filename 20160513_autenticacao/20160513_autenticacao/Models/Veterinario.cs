using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _20160513_autenticacao.Models
{
    public class Veterinario
    {
        [Key]
        public int VeterinarioID { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30, MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Rua { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(3, MinimumLength = 1)]
        public string NumPorta { get; set; }

        [StringLength(4, MinimumLength = 1)]
        public string Andar { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string CodPostal { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(9, ErrorMessage = "O {0} tem de ter {2} caracteres.", MinimumLength = 9)]
        public string NIF { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataEntradaClinica { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(30)]
        public string NumCedulaProf { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataInscOrdem { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string Faculdade { get; set; }

    }
}