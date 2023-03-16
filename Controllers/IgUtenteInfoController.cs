using Instagram_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Portfolio.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IgUtenteInfoController : ControllerBase
    {
        [HttpGet]
        // GET api/Ig
        public ChiamataUserIg.RootUtenteIG Get(string username)
        {
            string api = $"https://www.instagram.com/api/v1/users/web_profile_info/?username={username}";

            var request = (HttpWebRequest)WebRequest.Create(api);

            request.Headers.Add("accept", " */*");
            request.Headers.Add("accept-encoding", " gzip, deflate, br");
            request.Headers.Add("accept-language", " it");
            request.Headers.Add("cache-control", " no-cache");
            request.Headers.Add("pragma", " no-cache");
            request.Headers.Add("sec-ch-prefers-color-scheme", " dark");
            request.Headers.Add("sec-ch-ua", " \"Microsoft Edge\";v=\"111\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"111\"");
            request.Headers.Add("sec-ch-ua-mobile", " ?0");
            request.Headers.Add("sec-ch-ua-platform", " \"Windows\"");
            request.Headers.Add("sec-fetch-dest", " empty");
            request.Headers.Add("sec-fetch-mode", " cors");
            request.Headers.Add("sec-fetch-site", " same-origin");
            request.Headers.Add("user-agent", " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36 Edg/111.0.1661.41");
            request.Headers.Add("x-requested-with", " XMLHttpRequest");
            request.Headers.Add("Cookie",
               "csrftoken=A3hV4U1XCiDsgaKWiY6fAU2chwlA6heS; " +
               "ds_user_id=4728937288; " +
               "ig_did=FH3G4AND-GC9F-38J1-N29S-7892H2178I27; " +
               "mid=SDAutAALAAF4HuY28pFsoGA2_yrD"
           );


            request.Method = "GET";
            //request.CookieContainer = cookieContainer;

            WebResponse response = request.GetResponse() as HttpWebResponse;
            var stream = response.GetResponseStream();

            // Controllo se la risposta è codificata con GZIP
            if (response.Headers["Content-Encoding"]?.ToLower().Contains("gzip") == true)
            {
                // Creo uno stream per la decompressione GZIP
                stream = new GZipStream(stream, CompressionMode.Decompress);
            }

            StreamReader reader2 = new StreamReader(stream);
            // Leggo la risposta.
            string streamJson2 = reader2.ReadToEnd();

            var utente = JsonConvert.DeserializeObject<ChiamataUserIg.RootUtenteIG>(streamJson2);

            return utente;
        }
    }
}
