using SalesSolution.Dominio.Enumerado;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesSolution.Dominio.ObjetoValor
{
   public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto 
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto;  }
        }
        public bool EhCartaoCretito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCretito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool EhNaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }
    }
}
