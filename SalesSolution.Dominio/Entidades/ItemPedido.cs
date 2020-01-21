namespace SalesSolution.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
            {
                AdicionarCritica("Não foi indetificado qual a referencia desse produto");
            }
            if (Quantidade == 0)
            {
                AdicionarCritica("Quantidade não Informada");
            }
        }
    }
}
