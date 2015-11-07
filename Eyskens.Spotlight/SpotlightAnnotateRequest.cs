using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Eyskens.Spotlight
{
    public class SpotlightAnnotateRequest
    {
        SpotlightRequestConfig config = null;
        public SpotlightAnnotateRequest(SpotlightRequestConfig cfg)
        {
            config = cfg;
        }
        public SpotlightAnnotateResponse GetResponse()
        {
            SpotlightAnnotateResponse AnnotateResponse = null;

            byte[] body = UTF8Encoding.UTF8.GetBytes(string.Concat("text=" + HttpUtility.UrlEncode(config.text), SpotlightHelper.GetParameters(config)));
            HttpWebRequest req = HttpWebRequest.Create(
                string.Concat(config.EndPoint, "annotate")) as HttpWebRequest;
            req.Method = "POST";
            req.ContentLength = body.Length;
            req.Accept = "application/json";
            using (Stream s = req.GetRequestStream())
            {
                s.Write(body, 0, body.Length);
            }
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
            using (StreamReader sr = new StreamReader(resp.GetResponseStream()))
            {
                AnnotateResponse = JsonConvert.DeserializeObject<SpotlightAnnotateResponse>(sr.ReadToEnd());
            }
            return AnnotateResponse;
        }
    }
}
