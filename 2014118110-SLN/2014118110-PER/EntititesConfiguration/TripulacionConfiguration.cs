using _2014118110_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.EntititesConfiguration
{
    public class TripulacionConfiguration : EntityTypeConfiguration<Tripulacion>
    {
        public TripulacionConfiguration()
        {
            //Table configurations
            ToTable("Tripulaciones");
            HasKey(c => c.TripulacionId);
            Property(c => c.Nombre).IsRequired().HasMaxLength(300);

            //Relationships Configurations
            HasMany(c => c.TipoTripulacion)
                .WithRequired(c => c.Tripulacion)
                .HasForeignKey(c => c.TripulacionId);
        }
    }
}
