using AppCovid19.BLL;
using AppCovid19.BLL.Implement;
using AppCovid19.DTO;
using AppCovid19.Service;
using FontAwesome.Sharp;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WinFormsApp2.Extensions;

namespace WinFormsApp2.Forms
{
    public partial class FormDashboard : Form
    {
        #region Constructor

        private IDashboardBLL dashboardBLL;
        private INewsBLL newsBLL;

        public FormDashboard()
        {
            InitializeComponent();
            dashboardBLL = new DashboardBLL();
            newsBLL = new NewsBLL();
        }

        #endregion Constructor

        #region Event Form

        private void FormHome_Load(object sender, EventArgs e)
        {
            LoadTheme();
            InitChart();
            LoadChart();
            LoadStatistics();
        }

        #endregion Event Form

        #region Method Event Form

        private void LoadTheme()
        {
            foreach (Control item in panel_dashboard.Controls)
            {
                if (item.GetType() == typeof(IconButton))
                {
                    IconButton iconBtn = (IconButton)item;
                    iconBtn.BackColor = ThemeColor.PrimaryColor;
                    iconBtn.ForeColor = System.Drawing.Color.White;
                    iconBtn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

                if (item.GetType() == typeof(Button))
                {
                    Button btn = (Button)item;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = System.Drawing.Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }

                if (item.GetType() == typeof(Label))
                {
                    Label label = (Label)item;
                    label.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }

        #endregion Method Event Form

        #region Methods

        private void LoadStatistics()
        {
            var responseStatisticsForVn = dashboardBLL.GetStatisticsForVn();

            if (responseStatisticsForVn.IsSuccess)
            {
                this.lbl_infectionVN.Text = responseStatisticsForVn.Data.Infection;
                this.lbl_curedVN.Text = responseStatisticsForVn.Data.Cured;
                this.lbl_deadVN.Text = responseStatisticsForVn.Data.Death;
                this.lbl_vacxinVN.Text = responseStatisticsForVn.Data.Vacxin;
            }
            else
            {
                MessageBox.Show(responseStatisticsForVn.Message, "Error");
            }

            var responseStatisticsForWorld = dashboardBLL.GetStatisticsForWorld();
            if (responseStatisticsForWorld.IsSuccess)
            {
                this.lbl_infectionW.Text = Int32.Parse(responseStatisticsForWorld.Data.Infection).ToString("0,0", CultureInfo.CreateSpecificCulture("is-IS"));
                this.lbl_curedW.Text = Int32.Parse(responseStatisticsForWorld.Data.Cured).ToString("0,0", CultureInfo.CreateSpecificCulture("is-IS"));
                this.lbl_infectingW.Text = Int32.Parse(responseStatisticsForWorld.Data.Infecting).ToString("0,0", CultureInfo.CreateSpecificCulture("is-IS"));
                this.lbl_deadW.Text = Int32.Parse(responseStatisticsForWorld.Data.Death).ToString("0,0", CultureInfo.CreateSpecificCulture("is-IS"));
            }
            else
            {
                MessageBox.Show(responseStatisticsForWorld.Message, "Error");
            }
        }

        private void LoadChart()
        {
            #region Init Color

            System.Windows.Media.Color color = System.Windows.Media.Color.FromRgb(0, 150, 136);
            SolidColorBrush colorPie1 = new SolidColorBrush(color);
            SolidColorBrush colorPie2 = new SolidColorBrush(ThemeColor.ChangeColorBrightnessMedia(color, -0.3));
            SolidColorBrush colorPie3 = new SolidColorBrush(ThemeColor.ChangeColorBrightnessMedia(color, -0.2));
            SolidColorBrush colorPie4 = new SolidColorBrush(ThemeColor.ChangeColorBrightnessMedia(color, 0.1));
            SolidColorBrush colorPie5 = new SolidColorBrush(ThemeColor.ChangeColorBrightnessMedia(color, 0.2));
            SolidColorBrush colorPie6 = new SolidColorBrush(ThemeColor.ChangeColorBrightnessMedia(color, 0.3));

            #endregion Init Color

            var response = dashboardBLL.GetInfoChartForWorld();
            if (response.IsSuccess)
            {
                var asia = response.Data.Where(x => x.Area == "Asia").FirstOrDefault();
                var europe = response.Data.Where(x => x.Area == "Europe").FirstOrDefault();
                var africa = response.Data.Where(x => x.Area == "Africa").FirstOrDefault();
                var oceania = response.Data.Where(x => x.Area == "Australia/Oceania").FirstOrDefault();
                var northAmerica = response.Data.Where(x => x.Area == "North America").FirstOrDefault();
                var southAmerica = response.Data.Where(x => x.Area == "South America").FirstOrDefault();

                #region PieChart for infection

                SeriesCollection series = new SeriesCollection();
                series.Add(new PieSeries() { Title = asia.Country, Values = new ChartValues<int> { asia.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie1 });
                series.Add(new PieSeries() { Title = europe.Country, Values = new ChartValues<int> { europe.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie2 });
                series.Add(new PieSeries() { Title = africa.Country, Values = new ChartValues<int> { africa.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie3 });
                series.Add(new PieSeries() { Title = oceania.Country, Values = new ChartValues<int> { oceania.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie4 });
                series.Add(new PieSeries() { Title = northAmerica.Country, Values = new ChartValues<int> { northAmerica.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie5 });
                series.Add(new PieSeries() { Title = southAmerica.Country, Values = new ChartValues<int> { southAmerica.ActiveCases }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie6 });

                pieChart1.Series = series;

                #endregion PieChart for infection

                #region PieChart for death

                SeriesCollection series2 = new SeriesCollection();
                series2.Add(new PieSeries() { Title = asia.Country, Values = new ChartValues<int> { asia.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie1 });
                series2.Add(new PieSeries() { Title = europe.Country, Values = new ChartValues<int> { europe.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie2 });
                series2.Add(new PieSeries() { Title = africa.Country, Values = new ChartValues<int> { africa.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie3 });
                series2.Add(new PieSeries() { Title = oceania.Country, Values = new ChartValues<int> { oceania.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie4 });
                series2.Add(new PieSeries() { Title = northAmerica.Country, Values = new ChartValues<int> { northAmerica.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie5 });
                series2.Add(new PieSeries() { Title = southAmerica.Country, Values = new ChartValues<int> { southAmerica.TotalDeaths }, DataLabels = true, LabelPoint = lablePoint, Fill = colorPie6 });

                pieChart2.Series = series2;

                #endregion PieChart for death

                #region CartesianChart

                cartesianChart1.Series.Clear();
                SeriesCollection series3 = new SeriesCollection();
                series3.Add(new LineSeries()
                {
                    Title = "Ca nhiễm trong ngày",
                    Values = new ChartValues<int>
                    {
                        asia.DailyConfirmed,
                        europe.DailyConfirmed,
                        africa.DailyConfirmed,
                        northAmerica.DailyConfirmed,
                        southAmerica.DailyConfirmed,
                        oceania.DailyConfirmed
                    },
                }
                );
                series3.Add(new LineSeries()
                {
                    Title = "Ca tử vong trong ngày",
                    Values = new ChartValues<int>
                    {
                        asia.DailyDeaths,
                        europe.DailyDeaths,
                        africa.DailyDeaths,
                        northAmerica.DailyDeaths,
                        southAmerica.DailyDeaths,
                        oceania.DailyDeaths
                    },
                }
                );

                cartesianChart1.Series = series3;

                #endregion CartesianChart
            }
            else
            {
                MessageBox.Show(response.Message, "Error");
            }
        }

        private Func<ChartPoint, string> lablePoint = chartPoint => string.Format("{0}", chartPoint.Y, chartPoint.Participation);

        private void InitChart()
        {
            // Pie chart
            pieChart1.LegendLocation = LegendLocation.Bottom;
            pieChart2.LegendLocation = LegendLocation.Bottom;

            // Cartesian Chart
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = new[] { "Châu Á", "Châu Âu", "Châu Phi", "Bắc Mỹ", "Nam Mỹ", "Châu Úc" }
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tình hình thế giới",
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;
        }

        #endregion Methods
    }
}