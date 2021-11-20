using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AplicaçãoCadastroCrudPIM8.Models
{
    public class Pessoa
    {
        [Key]
        public int CadastroId { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Nome { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string CPF { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Telefone { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Endereco { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string CEP { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("Bairro")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Bairro { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Cidade { get; set; }
        [Column(TypeName= "varchar(50)")]
        [DisplayName("Estado")]
        [Required(ErrorMessage = "Este Campo é Obrigatório")]
        public string Estado { get; set; }


    }
}
