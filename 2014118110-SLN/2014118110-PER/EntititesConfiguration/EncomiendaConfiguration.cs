using _2014118110_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.EntititesConfiguration
{
    public class EncomiendaConfiguration : EntityTypeConfiguration<Encomienda>
    {
        public EncomiendaConfiguration()
        {
            //Table configurations
            ToTable("Encomiendas");
            HasKey(c => c.EncomiendaId);
            Property(c => c.NombreDestinatario).IsRequired().HasMaxLength(300);

            //Relationships Configurations
            HasMany(c => c.LugarViaje)
                .WithRequired(c => c.Encomienda)
                .HasForeignKey(c => c.EncomiendaId);
            
        }
    }
}
