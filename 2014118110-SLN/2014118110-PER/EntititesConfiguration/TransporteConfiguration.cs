using _2014118110_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.EntititesConfiguration
{
    public class TransporteConfiguration : EntityTypeConfiguration<Transporte>
    {
        public TransporteConfiguration()
        {
            //Table configurations
            ToTable("Transportes");
            HasKey(c => c.TranporteId);

            //Relationships Configurations
            HasMany(c => c.Cliente)
                .WithRequired(c => c.Transporte)
                .HasForeignKey(c => c.TransporteId);

            HasMany(c => c.TipoViaje)
                .WithRequired(c => c.Transporte)
                .HasForeignKey(c => c.TransporteId);

            HasMany(c => c.Bus)
                .WithRequired(c => c.Transporte)
                .HasForeignKey(c => c.TransporteId);

            HasMany(c => c.LugarViaje)
                .WithRequired(c => c.Transporte)
                .HasForeignKey(c => c.TransporteId);
        }
    }
}
