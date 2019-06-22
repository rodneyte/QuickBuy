using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido:Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevistaEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento formaPagamento { get; set; }
        /// <summary>
        /// Pedido deve ter um pedido 
        /// ou muitos pedidos
        /// </summary>
        public virtual ICollection<ItemPedido> ItemsPedido { get; set; }

        public override void Validade()
        {
            LimparMenssagensValidacao();
            if (!ItemsPedido.Any())
                AdicionaCritica("Crítica - Pedido não pode ficar sem item de pedido");

            if (string.IsNullOrEmpty(CEP))
                AdicionaCritica("Crítica - CEP deve estar Prenchida");

            if (FormaPagamentoId == 0)
                AdicionaCritica("Crítica - Não foi informado forma de pagamento");
        }
    }
}
