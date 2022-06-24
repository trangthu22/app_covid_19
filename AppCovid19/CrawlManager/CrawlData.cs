using AppCovid19.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppCovid19.CrawlManager
{
    public class CrawlData : ICrawlData
    {
        #region Constructor

        private HttpClient httpClient;
        private HttpClientHandler httpClientHandler;
        private CookieContainer cookieContainer;
        private const string BASE_URI = "https://covid19.vnanet.vn/";
        private HttpClient httpClient2;
        private HttpClientHandler httpClientHandler2;
        private CookieContainer cookieContainer2;
        private const string BASE_URI2 = "https://ncov.vnanet.vn/";

        public CrawlData()
        {
            InitHttpClient();
        }

        #endregion Constructor

        public void InitHttpClient()
        {
            // http client 1
            cookieContainer = new CookieContainer();
            httpClientHandler = new HttpClientHandler
            {
                CookieContainer = cookieContainer,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                UseDefaultCredentials = false
            };
            httpClient = new HttpClient(httpClientHandler);
            httpClient.BaseAddress = new Uri(BASE_URI);

            // http client 2
            cookieContainer2 = new CookieContainer();
            httpClientHandler2 = new HttpClientHandler
            {
                CookieContainer = cookieContainer2,
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                UseDefaultCredentials = false
            };
            httpClient2 = new HttpClient(httpClientHandler2);
            httpClient2.BaseAddress = new Uri(BASE_URI2);
            //httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "");
            /*
             * Header:
             * - Origin
             * - Host
             * - Referer
             * - : scheme
             * - accept
             * - Accept-Encoding
             * - Accept-Language
             * - User-Agent
             */
        }

        public ResponseDTO<CrawlDataDTO> CrawlDataFromUrl(string url)
        {
            string html = "";
            html = WebUtility.HtmlDecode(httpClient.GetStringAsync(url).Result);

            CrawlDataDTO crawlDataDTO = new CrawlDataDTO()
            {
                HtmlPage = html
            };

            if (html.Equals(""))
            {
                return ResponseDTO<CrawlDataDTO>.ResponseFailure("Crawl data failure!");
            }
            return ResponseDTO<CrawlDataDTO>.ResponseSuccess(crawlDataDTO, "Crawl data success!");
        }

        public ResponseDTO<CrawlDataDTO> GetListHtml(string url, string regex)
        {
            var crawlData = CrawlDataFromUrl(url);

            if (crawlData.IsSuccess)
            {
                var htmlList = Regex.Matches(crawlData.Data.HtmlPage, regex, RegexOptions.Singleline);

                CrawlDataDTO crawlDataDTO = new CrawlDataDTO()
                {
                    ListHtml = htmlList
                };

                return ResponseDTO<CrawlDataDTO>.ResponseSuccess(crawlDataDTO, "Get list html success!");
            }

            return ResponseDTO<CrawlDataDTO>.ResponseFailure("Crawl list html failure!");
        }

        public ResponseDTO<CrawlDataDTO> CrawlDataFromUrl2(string url)
        {
            string html = "";
            html = WebUtility.HtmlDecode(httpClient2.GetStringAsync(url).Result);

            CrawlDataDTO crawlDataDTO = new CrawlDataDTO()
            {
                HtmlPage = html
            };

            if (html.Equals(""))
            {
                return ResponseDTO<CrawlDataDTO>.ResponseFailure("Crawl data failure!");
            }
            return ResponseDTO<CrawlDataDTO>.ResponseSuccess(crawlDataDTO, "Crawl data success!");
        }

        public ResponseDTO<CrawlDataDTO> GetListHtml2(string url, string regex)
        {
            var crawlData = CrawlDataFromUrl2(url);

            if (crawlData.IsSuccess)
            {
                var htmlList = Regex.Matches(crawlData.Data.HtmlPage, regex, RegexOptions.Singleline);

                CrawlDataDTO crawlDataDTO = new CrawlDataDTO()
                {
                    ListHtml = htmlList
                };

                return ResponseDTO<CrawlDataDTO>.ResponseSuccess(crawlDataDTO, "Get list html success!");
            }

            return ResponseDTO<CrawlDataDTO>.ResponseFailure("Crawl list html failure!");
        }
    }
}