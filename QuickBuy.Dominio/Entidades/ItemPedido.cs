using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validade()
        {
            if (ProdutoId == 0)
                AdicionaCritica("Não foi indentificado qual a refêrencia do produto.");

            if (ProdutoId == 0)
                AdicionaCritica("Quantidade não foi informado");

        }
    }
}
