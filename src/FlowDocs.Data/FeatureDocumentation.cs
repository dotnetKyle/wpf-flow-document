using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowDocs.Data
{
    public class FeatureDocumentation
    {
        public string Id { get; set; }

        /// <summary>
        /// Searchable
        /// </summary>
        public string FeatureName { get; set; }

        /// <summary>
        /// Tags for searching
        /// </summary>
        public List<string> Tags { get; set; }

        public string DocumentXML { get; set; }
    }
}
