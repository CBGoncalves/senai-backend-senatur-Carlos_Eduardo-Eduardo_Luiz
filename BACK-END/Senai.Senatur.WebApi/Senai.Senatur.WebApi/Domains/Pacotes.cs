using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.Senatur.WebApi.Domains
{
    public partial class Pacotes
    {
        /// <summary>
        /// Classe que representa entidade Pacotes
        /// </summary>
        public int IdPacote { get; set; }

        // Define que a propriedade é obrigatória
        [Required(ErrorMessage = "O nome do pacote é obrigatório!")]
        public string NomePacote { get; set; }

        [Required(ErrorMessage = "A descrição do pacote é obrigatória!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A data de ida da viagem é obrigatória!")]
        public DateTime DataIda { get; set; }

        [Required(ErrorMessage = "A data de volta da viagem é obrigatória!")]
        public DateTime DataVolta { get; set; }

        [Required(ErrorMessage = "O valor do pacote é obrigatório!")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O estado do pacote é obrigatório!")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "O nome da cidade é obrigatório!")]
        public string NomeCidade { get; set; }
    }
}
