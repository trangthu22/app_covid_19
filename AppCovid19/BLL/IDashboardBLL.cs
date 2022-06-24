using AppCovid19.DTO;
using System.Collections.Generic;

namespace AppCovid19.BLL
{
    public interface IDashboardBLL
    {
        ResponseDTO<DashboardDTO.Statistics> GetStatisticsForVn();

        ResponseDTO<DashboardDTO.Statistics> GetStatisticsForWorld();

        ResponseDTO<List<DashboardDTO.InfoChartForWorld>> GetInfoChartForWorld();

        ResponseDTO<List<DashboardDTO.InfoChartForVN>> GetInfoChartForVN();
    }
}