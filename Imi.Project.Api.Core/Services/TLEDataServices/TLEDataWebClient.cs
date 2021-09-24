using Imi.Project.Api.Core.Interfaces.Services.TLEDataServices;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.TLEDataServices
{
    public class TLEDataWebClient : WebClient, ITLEDataWebClient
    {
        #region Fields

        private readonly CookieContainer _cookieContainer = new CookieContainer();

        #endregion Fields

        #region Methods

        public Task<string> GetSpaceDataFromSpaceTrack(string[] noradPredicates, DateTime dtstart, DateTime dtend)
        {
            string uriBase = "https://www.space-track.org";
            string requestController = "/basicspacedata";
            string requestAction = "/query";
            string predicateValues =
                "/class/tle/EPOCH/" +
                dtstart.ToString("yyyy-MM-dd--") +
                dtend.ToString("yyyy-MM-dd") +
                "/NORAD_CAT_ID/" +
                string.Join(",", noradPredicates) +
                "/orderby/NORAD_CAT_ID%20ASC/format/json";

            string request = uriBase + requestController + requestAction + predicateValues;

            // Create new WebClient object to communicate with the service
            using (var client = new WebClient())
            {
                // Store the user authentication information
                var data = new NameValueCollection
                {
                    { "identity", "orbitalspacemapping@gmail.com" },
                    { "password", "VIR1ueel1!12345" }
                };

                // Generate the URL for the API Query and return the response
                client.UploadValues(uriBase + "/ajaxauth/login", data);
                client.Headers.Add(HttpRequestHeader.Cookie, client.ResponseHeaders.GetValues(6).GetValue(0).ToString()); //This gets the cookie from the response header
                var responseData = client.DownloadData(request);

                return Task.FromResult((System.Text.Encoding.Default.GetString(responseData)));
            }
        }

        public Task<string> GetSpaceDataFromSpaceTrack(string[] noradPredicates)
        {
            throw new NotImplementedException();
        }

        // Override the WebRequest method so we can store the cookie container as an attribute of
        // the Web Request object Gets called when the ctor of WebClient class uploads values to the
        // request source.
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            if (request is HttpWebRequest)
                (request as HttpWebRequest).CookieContainer = _cookieContainer;

            return request;
        }

        #endregion Methods
    }
}