using System.Text.RegularExpressions;

namespace AppCovid19.DTO
{
    public class CrawlDataDTO
    {
        public string HtmlPage { get; set; }

        public MatchCollection ListHtml { get; set; }
    }
}