﻿using EFCore.Dominio;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Repo
{
    public class HeroiContexto : DbContext
    {

        public HeroiContexto(DbContextOptions<HeroiContexto> options) : base(options)
        {

        }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadeSecretas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => { entity.HasKey(e => new { e.BatalhaId, e.HeroiID }); });
        }
    }
}
