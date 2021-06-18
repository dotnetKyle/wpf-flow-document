using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Markup;

namespace FlowDocs
{
    /// <summary>
    /// This class is for translating flow documents from XAML to strings and the reverse
    /// </summary>
    public class FlowDocumentTranslator
    {
        public string Serialize(FlowDocument doc)
        {
            var xml = XamlWriter.Save(doc);
            return xml;
        }

        public FlowDocument DeSerialize(string xml)
        {
            using (var sr = new StringReader(xml))
            using (var xr = new XmlTextReader(sr))
            {
                var xamlObject = XamlReader.Load(xr);

                var flowDoc = xamlObject as FlowDocument;

                return flowDoc;
            }
        }
    }
}
