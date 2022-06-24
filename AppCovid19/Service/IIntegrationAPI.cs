using AppCovid19.DTO;
using System.Threading.Tasks;

namespace AppCovid19.Service
{
    public interface IIntegrationAPI
    {
        Task<ResponseDTO<ApiResponse>> GetData(string url, string regex);
    }
}