using AppCovid19.DAL;
using AppCovid19.DAL.Implement;
using AppCovid19.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCovid19.BLL.Implement
{
    public class NewsBLL : INewsBLL
    {
        private INewsDAL newsDAL;

        public NewsBLL()
        {
            newsDAL = new NewsDAL();
        }

        public int GetAllPage()
        {
            return newsDAL.GetAllPage();
        }

        public Task<ResponseDTO<List<NewsDTO.News>>> GetNews(int pageNumber)
        {
            return newsDAL.GetNews(pageNumber);
        }

        public Task<ResponseDTO<NewsDTO.NewsDetail>> GetNewsDetail(int pageNumber)
        {
            return newsDAL.GetNewsDetail(pageNumber);
        }
    }
}