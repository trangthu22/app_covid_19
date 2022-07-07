using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Extensions;
using WinFormsApp2.Forms;
using AppCovid19.GUI;
using AppCovid19.BLL;
using AppCovid19.BLL.Implement;
using AppCovid19.DTO;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        #region Constructor

        private IconButton currentButton;
        private Form activeForm;
        private Random random;
        private int tempIndex;
        private int borderSize = 0;
        private IDashboardBLL dashboardBLL;

        public MainForm()
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);
            random = new Random();
            CollapseMenu();
            OpenChildForm(new Forms.FormDashboard(), iconButton1);
            dashboardBLL = new DashboardBLL();
        }

        #endregion Constructor

        #region Event Form

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void iconBtn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void iconBtn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconbtn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDashboard(), sender);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSituationVN(), sender);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FormSituationWorld situationWorld = new FormSituationWorld();
            OpenChildForm(situationWorld, sender);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FormNews formNews = new FormNews();
            OpenChildForm(formNews, sender);
        }

        private void iconBtn_refesh_Click(object sender, EventArgs e)
        {
            string info = "Nguyễn Thị Thu Trang - 20187155 - HUST";
            MessageBox.Show(info.Replace(";", "" + System.Environment.NewLine), "THÔNG TIN NHÓM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion Event Form

        #region Method Event Form

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;

                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                    }
                    break;
            }
        }

        private void CollapseMenu()
        {
            if (this.panel_SlideMenu.Width > 200)
            {
                panel_SlideMenu.Width = 100;
                pictureBox_Logo.Visible = false;
                btn_menu.Dock = DockStyle.Top;
                foreach (Button menuButton in panel_SlideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panel_SlideMenu.Width = 210;
                pictureBox_Logo.Visible = true;
                btn_menu.Dock = DockStyle.None;
                foreach (Button menuButton in panel_SlideMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(15, 10, 0, 0);
                }
            }
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                Color color = Color.FromArgb(0, 150, 136);
                currentButton = (IconButton)btnSender;
                currentButton.BackColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                panel_titleBar.BackColor = color;
                panel_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_SlideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_desktopPane.Controls.Add(childForm);
            this.panel_desktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_titleBar.Text = childForm.Text;
        }

        #endregion Method Event Form

        #region Methods

        private void GetDataVN() { 
        }

        #endregion Methods

        #region DragForm

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsgn, int wParam, int lParam);

        private void panel_titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WN_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }

            #endregion Form Resize

            // remove border and keep snap window
            if (m.Msg == WN_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        #endregion DragForm  
    }
}
