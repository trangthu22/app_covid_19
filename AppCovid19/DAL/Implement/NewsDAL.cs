using AppCovid19.CrawlManager;
using AppCovid19.DTO;
using AppCovid19.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace AppCovid19.DAL.Implement
{
    public class NewsDAL : INewsDAL
    {
        private ICrawlData crawlData;
        private IIntegrationAPI integrationAPI;

        public NewsDAL()
        {
            crawlData = new CrawlData();
            integrationAPI = new IntegrationAPI();
        }

        public int GetAllPage()
        {
            var response = crawlData.GetListHtml2("", @"(?=totalNews).*?(?=;)");
            if (response.IsSuccess)
            {
                var data = response.Data.ListHtml.FirstOrDefault().ToString().Replace("totalNews=", "");
                int allPage = Int32.Parse(data.ToString());
                return allPage;
            }
            return 0;
        }

        public async Task<ResponseDTO<List<NewsDTO.News>>> GetNews(int pageNumber)
        {
            var response = await integrationAPI.GetData("/vi/Home/getPageNews?page=" + pageNumber, @"(?=u0027).*?(?=u003c/span)");
            List<NewsDTO.News> listNews = new List<NewsDTO.News>();
            if (response.IsSuccess)
            {
                foreach (var data in response.Data.Data)
                {
                    var regexUrl = Regex.Matches(data.ToString(), "(?=u0027).*?(?=u003e)", RegexOptions.Singleline).FirstOrDefault();
                    string url = regexUrl.ToString().Replace("u0027", "").Replace(@"\", "");

                    var regexTitle = Regex.Matches(data.ToString(), "(?=u003e).*?(?=u003cspan)", RegexOptions.Singleline).FirstOrDefault();
                    string title = regexTitle.ToString().Replace("u003e", "").Replace(@"\", "");

                    var createTimeRegex = Regex.Matches(data.ToString(), @"(?=time-post-list).*?.(?=\z)", RegexOptions.Singleline).FirstOrDefault();
                    string createTime = createTimeRegex.ToString().Replace("u0027", "").Replace("u003e", "").Replace(@"time-post-list", "").Replace(@"\", "");
                    NewsDTO.News news = new NewsDTO.News()
                    {
                        Title = title,
                        Url = url,
                        CreateTime = createTime
                    };
                    listNews.Add(news);
                }
                return ResponseDTO<List<NewsDTO.News>>.ResponseSuccess(listNews, "Success!");
            }
            return ResponseDTO<List<NewsDTO.News>>.ResponseFailure("Get data from Api failure!");
        }

        public Task<ResponseDTO<NewsDTO.NewsDetail>> GetNewsDetail(int pageNumber)
        {
            throw new NotImplementedException();
        }
    }
}