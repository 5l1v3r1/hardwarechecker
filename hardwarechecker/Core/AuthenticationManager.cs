using System;
using System.IO;
using System.Net;

namespace hardwarechecker.Core
{
    public static class AuthenticationManager
    {
        private static CookieContainer Cookies;

        static AuthenticationManager()
        {
            Cookies = new CookieContainer();
        }

        public static bool Authenticate(string serverUri, string hwid)
        {
            string uri = string.Format("{0}?hwid={1}", serverUri, hwid);
            bool result = false;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = null;

            request.CookieContainer = Cookies;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException wex)
            {
                response = (HttpWebResponse)wex.Response;
            }
            catch (Exception ex)
            {
                return false; // probably no internet connection
            }

            if (response != null)
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream nwStream = response.GetResponseStream())
                    {
                        if (nwStream.ReadByte() > 0)
                        {
                            result = true;
                        }
                    }
                }

                response.Close();
            }
            
            return result;
        }
    }
}
