using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroduccionAEFcore.Entidades.configuraciones
{
    public class peliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
    {
        public void Configure(EntityTypeBuilder<PeliculaActor> builder) { 
        
            builder.HasKey(pa => new {pa.ActorId, pa.PeliculaId});  // queremos usar llave compuesta
        }
    }
}
