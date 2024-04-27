﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configurations
{
    public class MovieShowTimeConfiguration : IEntityTypeConfiguration<MovieShowTime>
    {
        public void Configure(EntityTypeBuilder<MovieShowTime> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
