using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (Preco == 0)
            {
                AdicionarCritica("Produto não esta com valor");
            }
        }
    }
}
