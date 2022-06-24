using AppCovid19.CrawlManager;
using AppCovid19.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppCovid19.DAL.Implement
{
    public class DashboardDAL : IDashboardDAL
    {
        private ICrawlData crawlData;

        public DashboardDAL()
        {
            crawlData = new CrawlData();
        }

        public ResponseDTO<List<DashboardDTO.InfoChartForVN>> GetInfoChartForVN()
        {
            var response = crawlData.GetListHtml("home/indexwiget", @"(?={""city"").*?(?=})");
            List<DashboardDTO.InfoChartForVN> listVNs = new List<DashboardDTO.InfoChartForVN>();
            if (response.IsSuccess)
            {
                foreach (var data in response.Data.ListHtml)
                {
                    var dataChart = data.ToString() + "}";
                    var dataJson = (DashboardDTO.InfoChartForVN)JsonConvert.DeserializeObject(dataChart, typeof(DashboardDTO.InfoChartForVN));
                    listVNs.Add(dataJson);
                }

                return ResponseDTO<List<DashboardDTO.InfoChartForVN>>.ResponseSuccess(listVNs, "Success!");
            }
            return ResponseDTO<List<DashboardDTO.InfoChartForVN>>.ResponseFailure("Get data for VN failure!");
        }

        public ResponseDTO<List<DashboardDTO.InfoChartForWorld>> GetInfoChartForWorld()
        {
            var response = crawlData.GetListHtml("home/indexwiget", @"(?={""activeCases"").*?(?=})");
            List<DashboardDTO.InfoChartForWorld> listWorlds = new List<DashboardDTO.InfoChartForWorld>();
            if (response.IsSuccess)
            {
                foreach (var data in response.Data.ListHtml)
                {
                    var dataChart = data.ToString() + "}";
                    var dataJson = (DashboardDTO.InfoChartForWorld)JsonConvert.DeserializeObject(dataChart, typeof(DashboardDTO.InfoChartForWorld));
                    listWorlds.Add(dataJson);
                }

                return ResponseDTO<List<DashboardDTO.InfoChartForWorld>>.ResponseSuccess(listWorlds, "Success!");
            }
            return ResponseDTO<List<DashboardDTO.InfoChartForWorld>>.ResponseFailure("Get data for World failure!");
        }

        public ResponseDTO<DashboardDTO.Statistics> GetStatisticsForVn()
        {
            var response = crawlData.GetListHtml("home/indexwigetsummary", @"(?=\sclass=""font-weight-bold fontsize22"">).*?(?=<)");

            if (response.IsSuccess)
            {
                DashboardDTO.Statistics statistics = new DashboardDTO.Statistics()
                {
                    Infection = response.Data.ListHtml.ElementAt(0).ToString().Replace(@"class=""font-weight-bold fontsize22"">", ""),
                    Cured = response.Data.ListHtml.ElementAt(1).ToString().Replace(@"class=""font-weight-bold fontsize22"">", ""),
                    Death = response.Data.ListHtml.ElementAt(2).ToString().Replace(@"class=""font-weight-bold fontsize22"">", ""),
                    Vacxin = response.Data.ListHtml.ElementAt(3).ToString().Replace(@"class=""font-weight-bold fontsize22"">", "")
                };

                return ResponseDTO<DashboardDTO.Statistics>.ResponseSuccess(statistics, "Success!");
            }
            return ResponseDTO<DashboardDTO.Statistics>.ResponseFailure("Get data statistics for Viet Nam failure!");
        }

        public ResponseDTO<DashboardDTO.Statistics> GetStatisticsForWorld()
        {
            var response = crawlData.GetListHtml("home/indexwigetsummary", @"(?=\sformatNumber).*?(?=\)\s)");
            if (response.IsSuccess)
            {
                DashboardDTO.Statistics statistics = new DashboardDTO.Statistics()
                {
                    Infection = response.Data.ListHtml.ElementAt(1).ToString().Replace(@"formatNumber(", ""),
                    Cured = response.Data.ListHtml.ElementAt(2).ToString().Replace(@"formatNumber(", ""),
                    Death = response.Data.ListHtml.ElementAt(3).ToString().Replace(@"formatNumber(", ""),
                    Infecting = response.Data.ListHtml.ElementAt(4).ToString().Replace(@"formatNumber(", "")
                };

                return ResponseDTO<DashboardDTO.Statistics>.ResponseSuccess(statistics, "Success!");
            }
            return ResponseDTO<DashboardDTO.Statistics>.ResponseFailure("Get data statistics for World failure!");
        }
    }
}