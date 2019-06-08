using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.ObjetoDeValor;
using QuickBuy.Repositorio.Config;

namespace QuickBuy.Repositorio.Contexto
{
   public class QuickBuyContexto:DbContext
   {
        
        public DbSet<Usuario>Usuarios { get; set; }
        public DbSet<Produto>Produtos { get; set; }
        public DbSet<Pedido>Pedidos { get; set; }
        public DbSet<ItemPedido>ItemPedidos { get; set; }
        public DbSet<FormaPagamento> MyProperty { get; set; }

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
