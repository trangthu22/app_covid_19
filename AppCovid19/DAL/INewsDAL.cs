using AppCovid19.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppCovid19.DAL
{
    public interface INewsDAL
    {
        Task<ResponseDTO<List<NewsDTO.News>>> GetNews(int pageNumber);

        Task<ResponseDTO<NewsDTO.NewsDetail>> GetNewsDetail(int pageNumber);

        int GetAllPage();
    }
}