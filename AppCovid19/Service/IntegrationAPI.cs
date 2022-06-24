using AppCovid19.DTO;
using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace AppCovid19.Service
{
    public class IntegrationAPI : IIntegrationAPI
    {
        private HttpClient httpClient;

        private const string BASE_ADDRESS = "https://ncov.vnanet.vn";

        public IntegrationAPI()
        {
        }

        public async Task<ResponseDTO<ApiResponse>> GetData(string url, string regex)
        {
            httpClient = new HttpClient();
            ApiResponse apiResponse = new ApiResponse();
            httpClient.BaseAddress = new Uri(BASE_ADDRESS);
            HttpResponseMessage response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string body = await response.Content.ReadAsStringAsync();

                var listData = Regex.Matches(body, regex, RegexOptions.Singleline);

                apiResponse.Data = listData;
                return ResponseDTO<ApiResponse>.ResponseSuccess(apiResponse, "Success!");
            }
            return ResponseDTO<ApiResponse>.ResponseFailure("Failure!");
        }
    }
}