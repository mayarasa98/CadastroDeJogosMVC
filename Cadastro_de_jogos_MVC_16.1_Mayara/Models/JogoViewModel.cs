using System;

namespace Cadastro_de_jogos_MVC_16._1_Mayara.Models
{
    public class JogoViewModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double? ValorLocacao { get; set; }

        public DateTime DataAquisicao { get; set; }

        public int CategoriaId { get; set; }
    }
}
