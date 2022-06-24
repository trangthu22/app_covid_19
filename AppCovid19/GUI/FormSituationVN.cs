using AppCovid19.BLL;
using AppCovid19.BLL.Implement;
using AppCovid19.DTO;
using AppCovid19.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Forms
{
    public partial class FormSituationVN : Form
    {
        #region Constructor

        private IDashboardBLL dashboardBLL;

        public FormSituationVN()
        {
            InitializeComponent();
            dashboardBLL = new DashboardBLL();
        }

        #endregion Constructor

        #region Event Form

        private void FormSituationVN_Load(object sender, EventArgs e)
        {
            InitDataGridView();
            LoadDataGridView("");
        }

        #endregion Event Form

        #region Method Event Form

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!txt_search.Text.Equals(""))
            {
                LoadDataGridView(txt_search.Text);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            LoadDataGridView("");
        }

        #endregion Method Event Form

        #region Methods

        private void LoadDataGridView(string city)
        {
            var response = new ResponseDTO<List<DashboardDTO.InfoChartForVN>>();
            response = dashboardBLL.GetInfoChartForVN();
            if (response.IsSuccess)
            {
                List<DashboardDTO.InfoChartForVN> listData = new List<DashboardDTO.InfoChartForVN>();
                if (city.Equals(""))
                {
                    listData = response.Data.ToList();
                }
                else
                {
                    listData = response.Data.Where(x => x.City.Contains(city)).ToList();
                }

                dataGridView1.Rows.Clear();
                int i = 1;
                int totalInfection = 0;
                int totalInfectionDaily = 0;
                int totalDeath = 0;
                int totalVacxin = 0;
                int totalCurred = 0;
                foreach (var data in listData)
                {
                    string infection = FormatCurrency.FormatIntToString(data.SoCaNhiem);
                    string infectionDaily = FormatCurrency.FormatIntToString(data.HomNay);
                    string death = FormatCurrency.FormatIntToString(data.TuVong);
                    dataGridView1.Rows.Add(i, data.City, infection, infectionDaily, death, data.Tiem, data.Khoi);
                    i++;
                    // Total
                    totalInfection = totalInfection + data.SoCaNhiem;
                    totalInfectionDaily = totalInfectionDaily + data.HomNay;
                    totalDeath = totalDeath + data.TuVong;
                    totalVacxin = totalVacxin + data.Tiem;
                    totalCurred = totalCurred + data.Khoi;
                }

                // Set Total lable
                this.lbl_infection.Text = FormatCurrency.FormatIntToString(totalInfection);
                this.lbl_infectionDaily.Text = FormatCurrency.FormatIntToString(totalInfectionDaily);
                this.lbl_cured.Text = totalCurred.ToString();
                this.lbl_death.Text = FormatCurrency.FormatIntToString(totalDeath);
                this.lbl_vacxin.Text = totalVacxin.ToString();
            }
            else
            {
                MessageBox.Show(response.Message, "Error");
            }
        }

        private void InitDataGridView()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 150, 136);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView1.ColumnHeadersHeight = 50;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        #endregion Methods
    }
}