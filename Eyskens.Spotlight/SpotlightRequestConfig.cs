using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyskens.Spotlight
{
    public enum DBPediaTypes
    {
        Activity,
        AnatomicalStructure,
        Award,
        ChemicalSubstance,
        Colour,
        Country,
        Currency,
        Database,
        Device,
        Disease,
        Drug,
        EthnicGroup,
        Event,
        Food,
        Holiday,
        Language,
        LegalCase,
        MeanOfTransportation,
        MusicGenre,
        Name,
        OlympicResult,
        Organisation,
        Person,
        Place,
        Planet,
        ProgrammingLanguage,
        Project,
        Protein,
        Single,
        Species,
        Work
    }
    public class SpotlightRequestConfig
    {
        public SpotlightRequestConfig(string t, string endpoint = "http://spotlight.dbpedia.org/rest/")
        {
            text = t;
            EndPoint = endpoint;
        }
        public string EndPoint
        {
            get;
            set;
        }
        public string text
        {
            get;
            set;
        }
        public string SparqlFilter
        {
            get;
            set;
        }
        double _confidence = 0;
        public double confidence
        {
            get
            {
                return _confidence;
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Probability must be between 0 and 1!");
                }
                else
                    _confidence = value;
            }
        }
        int _support = 0;
        public int support
        {
            get
            {
                return _support;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("support must be greater or equal to 0");
                }
                else
                    _support = value;
            }
        }

        List<string> _types = null;
        List<string> types
        {
            get
            {
                if (_types == null)
                {
                    _types = new List<string>();
                }
                return _types;
            }

        }
        public void AddFilterOnType(DBPediaTypes type)
        {
            types.Add(string.Concat("DBpedia:", type.ToString()));
        }
        public string TypeFilters
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (string type in types)
                {
                    sb.AppendFormat("{0},", type);
                }
                return (sb.ToString().Length > 0) ? sb.ToString().Substring(0, sb.ToString().Length - 1) : string.Empty;
            }
        }
    }
}
