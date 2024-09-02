namespace IntroduccionAEFcore.Entidades
{
    public class Pelicula
    {
        public int id {  get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();  // con hashSet no te promete regresar el listado de forma ordenada
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
        public List<PeliculaActor> PeliculasActores { get; set; } = new List<PeliculaActor>();  // con list por que queremos sacra la info en ordenm 

    }
}
                                 