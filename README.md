# Eyskens.Spotlight
Simple .NET Wrapper for DBPedia Spotlight
This .NET wrapper for DBPedia Spotlight helps performing NER operations against DBPedia Spotlight's web service. The below console progrma shows
how to use it. 

You can override the default endpoint (http://spotlight.dbpedia.org/) and simply make use of SpotlightCandidateRequest/SpotlightCandidateResponse and
SpotlightAnnotateRequest/SpotlightAnnotateResponse to start querying the web service. The wrapper converts the returned JSON
into .NET objects.

class Program
    {
        static void Main(string[] args)
        {
            SpotlightRequestConfig cfg = new SpotlightRequestConfig(
                "Somme text", "http://spotlight.sztaki.hu:2222/rest/");
            cfg.AddFilterOnType(DBPediaTypes.Person);
            cfg.AddFilterOnType(DBPediaTypes.Place);
            ShowCandidates(cfg);
            ShowAnnotation(cfg);            
        }
        static void ShowCandidates(SpotlightRequestConfig cfg)
        {
            SpotlightCandidateRequest req = new SpotlightCandidateRequest(cfg);
            SpotlightCandidateResponse resp = req.GetResponse();
            foreach (SurfaceForm resource in resp.annotation.surfaceForm)
            {
                if (resource.resource != null)
                {
                    foreach (SurfaceFormResource sr in resource.resource)
                    {
                        Console.WriteLine(sr.ContextualScore);
                    }
                }
            }
        }
        static void ShowAnnotation(SpotlightRequestConfig cfg)
        {
            SpotlightAnnotateRequest req = new SpotlightAnnotateRequest(cfg);
            SpotlightAnnotateResponse resp = req.GetResponse();
            if (resp.Resources != null)
            {
                foreach (SpotlightResource resource in resp.Resources)
                {
                    Console.WriteLine(resource.uri+" "+resource.types);
                }
            }
        }
    }
