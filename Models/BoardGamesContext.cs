﻿using BlackCoderCyberGamingManagement.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace BlackCoderCyberGamingManagement.Models
{
    public class BoardGamesContext : DbContext
    {
        public BoardGamesContext(DbContextOptions<BoardGamesContext> options) : base(options)
        {
        }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGame>().ToTable("BoardGame");
            modelBuilder.Entity<Rental>().ToTable("Rental");
        }
    }
}
