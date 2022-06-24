using AppCovid19.BLL;
using AppCovid19.BLL.Implement;
using AppCovid19.DTO;
using AppCovid19.Extensions;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using WinFormsApp2.Extensions;

namespace AppCovid19.GUI
{
    public partial class FormSituationWorld : Form
    {
        #region Constructure

        private IDashboardBLL dashboardBLL;

        private IconButton currentButton;

        public FormSituationWorld()
        {
            InitializeComponent();
            dashboardBLL = new DashboardBLL();
        }

        #endregion Constructure

        #region Event Form

        private void FormSituationWorld_Load(object sender, EventArgs e)
        {
            ActiveButton(btn_asia);
            LoadDataGridView(lbl_tmpArea.Text, "");
        }

        private void btn_asia_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_europe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_africa_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_southAmerica_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_northAmerica_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_australia_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!txt_search.Text.Equals(""))
            {
                LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadDataGridView(lbl_tmpArea.Text, txt_search.Text);
        }

        #endregion Event Form

        #region Methods

        private void LoadDataGridView(string area, string country)
        {
            /*            var response1 = new HttpResponseMessage();
                        response1.Content = new StringContent("<div>Hello World</div>");
                        response1.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
                        var a = response1.Content.ReadAsStringAsync().Result;
                        var plainText = HtmlUtilities.ConvertToPlainText(string html);*/
            var response = new ResponseDTO<List<DashboardDTO.InfoChartForWorld>>();
            response = dashboardBLL.GetInfoChartForWorld();
            if (response.IsSuccess)
            {
                List<DashboardDTO.InfoChartForWorld> listData = new List<DashboardDTO.InfoChartForWorld>();

                if (country.Equals(""))
                {
                    listData = response.Data.Where(x => x.Area == area).ToList();
                }
                else
                {
                    listData = response.Data.Where(x => x.Country.Contains(country) && x.Area == area).ToList();
                }

                dataGridView1.Rows.Clear();
                foreach (var data in listData)
                {
                    string infection = FormatCurrency.FormatIntToString(data.TotalConfirmed);
                    string infectionDaily = FormatCurrency.FormatIntToString(data.DailyConfirmed);
                    string death = FormatCurrency.FormatIntToString(data.TotalDeaths);
                    string deathDaily = FormatCurrency.FormatIntToString(data.DailyDeaths);
                    string cured = FormatCurrency.FormatIntToString(data.TotalRecovered);
                    string activeCase = FormatCurrency.FormatIntToString(data.ActiveCases);
                    string critical = FormatCurrency.FormatIntToString(data.TotalCritical);

                    dataGridView1.Rows.Add(data.Country, infection, infectionDaily, death, deathDaily, cured, activeCase, critical);
                }
                dataGridView1.Rows[0].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            }
            else
            {
                MessageBox.Show(response.Message, "Error");
            }
        }

        private void CustomIconButton()
        {
            System.Drawing.Color color = System.Drawing.Color.FromArgb(0, 150, 136);
            System.Drawing.Color color1 = ThemeColor.ChangeColorBrightness(color, -0.2);
            System.Drawing.Color color2 = ThemeColor.ChangeColorBrightness(color, -0.1);
            System.Drawing.Color color3 = ThemeColor.ChangeColorBrightness(color, 0.1);
            System.Drawing.Color color4 = ThemeColor.ChangeColorBrightness(color, 0.2);
            System.Drawing.Color color5 = ThemeColor.ChangeColorBrightness(color, 0.3);

            this.btn_asia.BackColor = color1;
            this.btn_europe.BackColor = color2;
            this.btn_africa.BackColor = color;
            this.btn_southAmerica.BackColor = color3;
            this.btn_northAmerica.BackColor = color4;
            this.btn_australia.BackColor = color5;
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                System.Drawing.Color color = System.Drawing.Color.FromArgb(0, 150, 136);
                currentButton = (IconButton)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = System.Drawing.Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                lbl_tmpArea.Text = currentButton.Tag.ToString();
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in tableLayoutPanel1.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = System.Drawing.Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        #endregion Methods
    }
}