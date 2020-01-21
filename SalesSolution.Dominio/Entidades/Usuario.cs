﻿using System.Collections.Generic;

namespace SalesSolution.Dominio.Entidades
{
    public class Usuario
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
    }
}
