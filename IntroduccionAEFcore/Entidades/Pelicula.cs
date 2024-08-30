namespace IntroduccionAEFcore.Entidades
{
    public class Pelicula
    {
        public int id {  get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }
        public DateTime FechaEstreno { get; set; }
    }
}
