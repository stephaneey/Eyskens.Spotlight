using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    internal class SpotlightHelper
    {
        internal static string GetParameters(SpotlightRequestConfig config)
        {
            StringBuilder parameters = new StringBuilder();
            if (!String.IsNullOrEmpty(config.TypeFilters))
            {
                parameters.AppendFormat("&types={0}", config.TypeFilters);
            }
            if (!String.IsNullOrEmpty(config.SparqlFilter))
            {
                parameters.AppendFormat("&sparql={0}", config.SparqlFilter);
            }
            if (config.confidence != 0)
            {
                parameters.AppendFormat("&confidence={0}", config.confidence.ToString().Replace(",","."));
            }
            parameters.AppendFormat("&support={0}", config.support);
            return parameters.ToString();
        }
    }
}
