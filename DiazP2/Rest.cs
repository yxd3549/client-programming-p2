using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiazP2
{
    public class REST
    {
        private string baseUri;
        public REST(string baseUri)
        {
            this.baseUri = baseUri;
        }
        public string getRESTDataJSON(string uri)
        {
            // Connect to the API
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(baseUri + uri);
            try
            {
                WebResponse response = request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {
                WebResponse err = ex.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
        }
    }
 }
