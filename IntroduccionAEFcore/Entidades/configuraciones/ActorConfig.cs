using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IntroduccionAEFcore.Entidades.configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        void IEntityTypeConfiguration<Actor>.Configure(EntityTypeBuilder<Actor> builder)
        {
            throw new NotImplementedException();
        }
    }
}
