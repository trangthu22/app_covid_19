namespace AppCovid19.DTO
{
    public class DashboardDTO
    {
        public class Statistics
        {
            public string Infection { get; set; }
            public string Cured { get; set; }
            public string Death { get; set; }
            public string Vacxin { get; set; }
            public string Infecting { get; set; }
        }

        public class InfoChartForWorld
        {
            public int ActiveCases { get; set; }
            public string Area { get; set; }
            public string Country { get; set; }
            public int DailyConfirmed { get; set; }
            public int DailyDeaths { get; set; }
            public int TotalConfirmed { get; set; }
            public int TotalCritical { get; set; }
            public int TotalDeaths { get; set; }
            public int TotalRecovered { get; set; }
        }

        public class InfoChartForVN
        {
            public string City { get; set; }
            public int HomNay { get; set; }
            public int DangDieuTri { get; set; }
            public int Khoi { get; set; }
            public int SoCaNhiem { get; set; }
            public int TuVong { get; set; }
            public int Tiem { get; set; }
        }
    }
}