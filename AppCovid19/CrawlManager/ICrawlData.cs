using AppCovid19.DTO;

namespace AppCovid19.CrawlManager
{
    public interface ICrawlData
    {
        void InitHttpClient();

        ResponseDTO<CrawlDataDTO> CrawlDataFromUrl(string url);

        ResponseDTO<CrawlDataDTO> GetListHtml(string url, string regex);

        ResponseDTO<CrawlDataDTO> CrawlDataFromUrl2(string url);

        ResponseDTO<CrawlDataDTO> GetListHtml2(string url, string regex);
    }
}