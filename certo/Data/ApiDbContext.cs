using ApiDeOrcamento.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

namespace ApiDeOrcamento.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ComposicaoItem> ComposicaoItem { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<ImagemItem> ImagemItem { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<OrcamentoItem> OrcamentoItem { get; set; }

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
    }
}
