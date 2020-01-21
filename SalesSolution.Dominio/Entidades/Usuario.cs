﻿using System.Collections.Generic;

namespace SalesSolution.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuario pode ter um pedido ou muitos pedidos
        /// </summary>
        public  ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {

            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Email não informado");
            }
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não foi informada");
            }
        }
    }
}
