using AppCovid19.BLL;
using AppCovid19.BLL.Implement;
using AppCovid19.CustomerComponent;
using AppCovid19.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCovid19.GUI
{
    public partial class FormNews : Form
    {
        #region Constructor

        private INewsBLL newsBLL;
        private const string BASE_URL = "https://ncov.vnanet.vn/";

        public FormNews()
        {
            InitializeComponent();
            newsBLL = new NewsBLL();
            InitPageLable();
        }

        #endregion Constructor

        #region Form Event

        private void FormNews_Load(object sender, EventArgs e)
        {
            LoadListTitle(1);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(lbl_page.Text.ToString());
            int pageNext = page + 1;
            int lastPage = Int32.Parse(lbl_allPage.Text.ToString().Replace("/", ""));
            if (pageNext > lastPage)
            {
                this.lbl_page.Text = "1";
                LoadListTitle(1);
            }
            else
            {
                this.lbl_page.Text = pageNext.ToString();
                LoadListTitle(pageNext);
            }
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            int page = Int32.Parse(lbl_page.Text.ToString());
            int pagePrevious = page - 1;
            int lastPage = Int32.Parse(lbl_allPage.Text.ToString().Replace("/", ""));
            if (pagePrevious == 0)
            {
                this.lbl_page.Text = lastPage.ToString();
                LoadListTitle(lastPage);
            }
            else
            {
                this.lbl_page.Text = pagePrevious.ToString();
                LoadListTitle(pagePrevious);
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            int lastPage = Int32.Parse(lbl_allPage.Text.ToString().Replace("/", ""));
            this.lbl_page.Text = lastPage.ToString();
            LoadListTitle(lastPage);
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            this.lbl_page.Text = "1";
            LoadListTitle(1);
        }

        private async void lbl_title_Click(object sender, EventArgs e)
        {
            CustomList label = (CustomList)sender;
            await webView21.EnsureCoreWebView2Async(null);
            webView21.CoreWebView2.Navigate(BASE_URL + label.Tag.ToString());
        }

        #endregion Form Event

        #region Methods

        private async void LoadListTitle(int pageNumber)
        {
            var response = new ResponseDTO<List<NewsDTO.News>>();
            response = await newsBLL.GetNews(pageNumber);

            if (response.IsSuccess)
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (var data in response.Data)
                {
                    CustomList customList = new CustomList();
                    customList.Title = data.Title;
                    customList.CreateTime = data.CreateTime;
                    customList.Tag = data.Url;
                    customList.LableClick += new System.EventHandler(lbl_title_Click);
                    flowLayoutPanel1.Controls.Add(customList);
                }
            }
        }

        private void InitPageLable()
        {
            var allPage = newsBLL.GetAllPage();
            this.lbl_allPage.Text = "/" + allPage.ToString();
        }

        #endregion Methods
    }
}