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
    public class SpotlightCandidateRequest
    {
        SpotlightRequestConfig config = null;
        public SpotlightCandidateRequest(SpotlightRequestConfig cfg)
        {
            config = cfg;
        }
        public SpotlightCandidateResponse GetResponse()
        {
            SpotlightCandidateResponse CandidateResponse = null;
            byte[] body = UTF8Encoding.UTF8.GetBytes(string.Concat("text=" + HttpUtility.UrlEncode(config.text), SpotlightHelper.GetParameters(config)));
            HttpWebRequest req = HttpWebRequest.Create(
                string.Concat(config.EndPoint, "candidates")) as HttpWebRequest;
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
                CandidateResponse = JsonConvert.DeserializeObject<SpotlightCandidateResponse>(sr.ReadToEnd());
            }
            return CandidateResponse;
        }
    }
}
