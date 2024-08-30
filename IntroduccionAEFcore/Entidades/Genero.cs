using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEFcore.Entidades
{
    public class Genero
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 150 )]
        public string Nombre { get; set; } = null!;
    }
}
