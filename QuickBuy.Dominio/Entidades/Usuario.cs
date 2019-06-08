using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario:Entidade
    {
        public int Id {get;set;}
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        /// <summary>
        /// um usuario pode ter nenhum ou muitos pedidos
        /// </summary>
        public virtual ICollection<Pedido>Pedidos { get; set; }

        public override void Validade()
        {
            if (string.IsNullOrWhiteSpace(Email))
                AdicionaCritica("Email não foi informado");

            if (string.IsNullOrWhiteSpace(Senha))
                AdicionaCritica("Senha não foi informado");

        }
    }
}
