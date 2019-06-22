using System;
using System.Collections.Generic;
using System.Linq;
namespace QuickBuy.Dominio.Entidades
{
    public class Produto:Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public Decimal Preco { get; set; }

        public override void Validade()
        {
            LimparMenssagensValidacao();
            if (string.IsNullOrEmpty(Nome))
                AdicionaCritica("Nome do produto não foi informado");

            if (string.IsNullOrEmpty(Descricao))
                AdicionaCritica("Descrição não foi informado");

        }
        
    }
}
