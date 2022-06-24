using AppCovid19.DTO;
using System.Collections.Generic;

namespace AppCovid19.DAL
{
    public interface IDashboardDAL
    {
        ResponseDTO<DashboardDTO.Statistics> GetStatisticsForVn();

        ResponseDTO<DashboardDTO.Statistics> GetStatisticsForWorld();

        ResponseDTO<List<DashboardDTO.InfoChartForWorld>> GetInfoChartForWorld();

        ResponseDTO<List<DashboardDTO.InfoChartForVN>> GetInfoChartForVN();
    }
}