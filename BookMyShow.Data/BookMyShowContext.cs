using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookMyShow.Data;

public partial class BookMyShowContext : DbContext
{
    public BookMyShowContext()
    {
    }

    public BookMyShowContext(DbContextOptions<BookMyShowContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BookingDetail> BookingDetails { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieCertificateType> MovieCertificateTypes { get; set; }

    //public virtual DbSet<MovieLanguageDetail> MovieLanguageDetails { get; set; }

    public virtual DbSet<ReservedSeat> ReservedSeats { get; set; }

    public virtual DbSet<SeatCategories> SeatCategories { get; set; }

    public virtual DbSet<ShowType> ShowTypes { get; set; }

    public virtual DbSet<Theatre> Theatres { get; set; }

    public virtual DbSet<TheatreSeatLayOut> TheatreSeatLayOut { get; set; }

    public virtual DbSet<TheatreShow> TheatreShows { get; set; }

    public virtual DbSet<TheatreTicketPricing> TheatreTicketPricing { get; set; }

    public virtual DbSet<MovieLanguageDetails> MovieLanguageDetails { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //        => optionsBuilder.UseSqlServer("Data Source=TL362;Initial Catalog=BookMyShow;Trusted_Connection=True;TrustServerCertificate=True");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MovieLanguageDetails>()
        .HasNoKey();
    }

    
}
