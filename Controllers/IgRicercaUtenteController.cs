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
    public class IgRicercaUtenteController : ControllerBase
    {
        [HttpGet]
        // GET api/Ig
        public RicercaUtenteIg.Risultati Get(string utente = null)
        {
            string api = $"https://i.instagram.com/api/v1/web/search/topsearch/?query={utente}";
            var request = (HttpWebRequest)WebRequest.Create(api);

            request.ContentType = "application/json";
            request.Headers.Add("accept-encoding", " gzip, deflate, br");
            request.Headers.Add("accept-language", " it-IT,it;q=0.6");
            request.Headers.Add("sec-ch-ua", " \"Brave\";v=\"111\", \"Not(A:Brand\";v=\"8\", \"Chromium\";v=\"111\"");
            request.Headers.Add("sec-ch-ua-mobile", " ?0");
            request.Headers.Add("sec-ch-ua-platform", " \"Windows\"");
            request.Headers.Add("sec-fetch-dest", " empty");
            request.Headers.Add("sec-fetch-mode", " cors");
            request.Headers.Add("sec-fetch-site", " same-origin");
            request.Headers.Add("sec-gpc", " 1");
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36";
            request.Headers.Add("x-reque", "");

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

            var listaUtenti = JsonConvert.DeserializeObject<RicercaUtenteIg.Risultati>(streamJson2);

            return listaUtenti;
        }
    }
}
