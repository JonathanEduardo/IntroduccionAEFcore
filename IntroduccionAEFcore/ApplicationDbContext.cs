using IntroduccionAEFcore.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroduccionAEFcore
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           // modelBuilder.Entity<Genero>().HasKey(g => g.Id);
          //  modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

            //Actor
           // modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
           // modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
           // modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasPrecision(18, 2);
          //  modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);

            //Actor
           // modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasMaxLength(150);
            //modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");

           // Comentario
            //modelBuilder.Entity<Comentario>().Property(c => c.Contenido).HasMaxLength(500);


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);  // todos los string que no configure toman esto
        }

        public DbSet<Genero> Generos => Set<Genero>();  //Se genera la clase genero como una entidad
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Comentario> Comentarios => Set<Comentario>();
        public DbSet<PeliculaActor> PeliculaActors => Set<PeliculaActor>();
    }
}
