using SalesSolution.Dominio.ObjetoValor;
using System;
using System.Collections.Generic;

namespace SalesSolution.Dominio.Entidades
{
    public class Pedido
    {
        public int ID { get; set; }

        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// Pedido pode ter pelo menos um ou varios itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
