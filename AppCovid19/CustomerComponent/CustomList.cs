using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCovid19.CustomerComponent
{
    public partial class CustomList : UserControl
    {
        public CustomList()
        {
            InitializeComponent();
        }

        #region Properties

        [Category("Custom Props")]
        public string Title
        {
            get => label3.Text;
            set => label3.Text = value;
        }

        [Category("Custom Props")]
        public string CreateTime
        {
            get => label2.Text;
            set => label2.Text = value;
        }

        public event EventHandler LableClick;

        #endregion Properties

        private void label3_Click(object sender, EventArgs e)
        {
            if (this.LableClick != null)
                this.LableClick(this, e);
        }
    }
}