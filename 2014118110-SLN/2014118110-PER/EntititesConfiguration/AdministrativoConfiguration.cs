using _2014118110_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.EntititesConfiguration
{
    public class AdministrativoConfiguration : EntityTypeConfiguration<Administrativo>
    {
        public AdministrativoConfiguration()
        {
            //Table configurations
            ToTable("Administrativos");
            HasKey(c => c.AdministrativoId);
            Property(c => c.Cargo).IsRequired();
        }
    }
}
