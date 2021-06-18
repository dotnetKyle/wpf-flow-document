using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using FlowDocs.Core;

namespace FlowDocs.Data
{
    public class FlowDocsDbContext : DbContext
    {
        Settings _settings;
        public FlowDocsDbContext(Settings settings)
        {
            _settings = settings;
        }

        DbSet<FeatureDocumentation> Features { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseCosmos(_settings.CosmosURI, _settings.CosmosKey, _settings.CosmosDbName);
        }
    }
}
