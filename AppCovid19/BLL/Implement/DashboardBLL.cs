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
    public class DashboardBLL : IDashboardBLL
    {
        private IDashboardDAL dashboardDAL;

        public DashboardBLL()
        {
            dashboardDAL = new DashboardDAL();
        }

        public ResponseDTO<List<DashboardDTO.InfoChartForVN>> GetInfoChartForVN()
        {
            return dashboardDAL.GetInfoChartForVN();
        }

        public ResponseDTO<List<DashboardDTO.InfoChartForWorld>> GetInfoChartForWorld()
        {
            return dashboardDAL.GetInfoChartForWorld();
        }

        public ResponseDTO<DashboardDTO.Statistics> GetStatisticsForVn()
        {
            return dashboardDAL.GetStatisticsForVn();
        }

        public ResponseDTO<DashboardDTO.Statistics> GetStatisticsForWorld()
        {
            return dashboardDAL.GetStatisticsForWorld();
        }
    }
}