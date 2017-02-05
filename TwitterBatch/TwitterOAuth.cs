using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Web;
using System.IO;
using System.Collections.Specialized;

namespace TwitterBatch
{
    public class TwitterOAuth
    {
        private OAuth.Manager AuthMan;
        public string EndpointBase = "https://api.twitter.com/1.1/";
        public string EndpointType = "json";

        public NameValueCollection ConnectionInfo
        {
            get;
            internal set;
        }

        public bool Ready
        {
            get;
            internal set;
        }

        public TwitterOAuth(string consumer_key, string consumer_secret)
        {
            AuthMan = new OAuth.Manager();
            AuthMan["consumer_key"] = consumer_key;
            AuthMan["consumer_secret"] = consumer_secret;
            Ready = false;
        }

        public string AcquireRequestToken()
        {
            var res = AuthMan.AcquireRequestToken("https://api.twitter.com/oauth/request_token", "POST");
            return res.AllText;
        }

        public string AcquireAccessToken(string PIN)
        {
            var res = AuthMan.AcquireAccessToken("https://api.twitter.com/oauth/access_token", "POST", PIN);
            ConnectionInfo = HttpUtility.ParseQueryString(res.AllText);
            Ready = true;
            return res.AllText;
        }

        public string GetAuthorizeUrl()
        {
            return "https://api.twitter.com/oauth/authorize?oauth_token=" + AuthMan["token"];
        }

        public string Get(string action, NameValueCollection data = null)
        {
            string paramStr = "";
            string url = EndpointBase + action + "." + EndpointType;
            if(!Ready)
            {
                throw new Exception("Twitter API Endpoint is not ready");
            }

            if (data != null)
            {
                List<string> parameters = new List<string>();
                foreach (string key in data)
                {
                    parameters.Add(key + "=" + HttpUtility.UrlEncode(data[key]));
                }
                paramStr = string.Join("&", parameters);
            }
            if(paramStr.Length > 0)
            {
                url += "?" + paramStr;
            }

            var authzHeader = AuthMan.GenerateAuthzHeader(url, "GET");
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.PreAuthenticate = true;
            request.AllowWriteStreamBuffering = true;
            request.Headers.Add("Authorization", authzHeader);
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            } catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }

            string responseText = "";
            Stream receiveStream = response.GetResponseStream();
            Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader readStream = new StreamReader(receiveStream, encode);
            char[] read = new char[1024];
            int count = readStream.Read(read, 0, 1024);
            while (count > 0)
            {
                responseText += new string(read, 0, count);
                count = readStream.Read(read, 0, 1024);
            }
            response.Close();
            readStream.Close();
            return responseText;
        }
    }
}
