using System.ComponentModel.DataAnnotations;

namespace IntroduccionAEFcore.Entidades
{
    public class Actor
    {
            public int Id {  get; set; }
            public string Nombre { get; set; }
            public decimal Fortuna { get; set;}
            public DateTime FechaNacimiento { get; set; }

        
    }
}
