﻿using _2014118110_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118110_PER.EntititesConfiguration
{
    public class TipoViajeConfiguration : EntityTypeConfiguration<TipoViaje>
    {
        public TipoViajeConfiguration()
        {
            //Table configurations
            ToTable("TipoViajes");
            HasKey(c => c.TipoViajeId);
            Property(c => c.TipoViajeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Nombre).IsRequired().HasMaxLength(300);
        }
    }
}
