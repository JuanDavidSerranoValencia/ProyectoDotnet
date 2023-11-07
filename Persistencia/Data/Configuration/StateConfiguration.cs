using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iText.Html2pdf.Attach;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class StateConfiguration : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
           
        }
    }
}