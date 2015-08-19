using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json.Linq;


namespace MovieSrervice
{
    public class TmdbService : IMovieService
    {
        private static TmdbService service;

        private TmdbService() { }
        public const string BaseUrl = "http://api.themoviedb.org/3/";
        public const string Authentication = "authentication/token/";
        public const string newToken = "new?api_key=";
        private const string ApiKey = "d22f2c0044f4c4eb0a46c5539bf4fc89";
        private string token;
        private string sessionID;

        public string Token
        {
            get
            {
                return token;
            }
            set
            {
                token = value;
            }
        }

        public static TmdbService Service
        {
            get
            {
                if (service == null)
                {
                    service = new TmdbService();
                }
                return service;
            }
        }
        public string Authenticate()
        {
            string userName;
            string password;
            string url = BaseUrl + Authentication + newToken + ApiKey;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                JObject auth = JObject.Parse(json);
                token = (string)auth["request_token"];
                Console.Write("Please enter username: ");
                userName = Console.ReadLine();
                Console.Write("Please enter password: ");
                password = Console.ReadLine();
                url = BaseUrl + Authentication + "validate_with_login?api_key=" + ApiKey + "&request_token=" + token + "&username=" + userName + "&password=" + password;
                json = wc.DownloadString(url);
                auth = JObject.Parse(json);
                token = (string)auth["request_token"];
                url = BaseUrl + "/authentication/session/new?api_key=" + ApiKey + "&request_token=" + token;
                json = wc.DownloadString(url);
                auth = JObject.Parse(json);
                sessionID = (string)auth["session_id"];
            }
            return "FAIL";
        }

        public SearchResult SearchMovie(string title)
        {
            throw new NotImplementedException();
        }

        public SearchResult SearchMovie(string title, string year)
        {
            throw new NotImplementedException();
        }

        public MovieInfo GetMovieInfo(string title)
        {
            throw new NotImplementedException();
        }
    }
}
