using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
    public class QuickBuyContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public QuickBuyContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiruration());
            modelBuilder.ApplyConfiguration(new PedidoConfiruration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiruration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
      
            new FormaPagamento()
            {
                Id = 1,
                Nome = "Boleto",
                Descricao = "Forma de Pagamento Boleto"
            }
            ,
            new FormaPagamento()
            {
                Id = 2,
                Nome = "Cartão de Credito",
                Descricao = "Forma de Pagamento Cartão de Credito"
            },
            new FormaPagamento()
            {
                Id = 3,
                Nome = "Depósito",
                Descricao = "Forma de Pagamento Deposito"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
