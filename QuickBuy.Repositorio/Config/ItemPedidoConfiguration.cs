﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(u => u.Id);

            builder
                .Property(u => u.ProdutoId)
                .IsRequired();

            builder
                .Property(u => u.Quantidade)
                .IsRequired();
        }
    }
}
