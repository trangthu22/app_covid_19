
namespace WinFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_SlideMenu = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconBtn_aboutUs = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.btn_menu = new FontAwesome.Sharp.IconButton();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_titleBar = new System.Windows.Forms.Panel();
            this.iconBtn_minisize = new FontAwesome.Sharp.IconButton();
            this.iconBtn_maximize = new FontAwesome.Sharp.IconButton();
            this.iconbtn_exit = new FontAwesome.Sharp.IconButton();
            this.label_titleBar = new System.Windows.Forms.Label();
            this.panel_desktopPane = new System.Windows.Forms.Panel();
            this.panel_SlideMenu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SlideMenu
            // 
            this.panel_SlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_SlideMenu.Controls.Add(this.iconButton4);
            this.panel_SlideMenu.Controls.Add(this.iconBtn_aboutUs);
            this.panel_SlideMenu.Controls.Add(this.iconButton3);
            this.panel_SlideMenu.Controls.Add(this.iconButton2);
            this.panel_SlideMenu.Controls.Add(this.iconButton1);
            this.panel_SlideMenu.Controls.Add(this.panel_Logo);
            this.panel_SlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_SlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_SlideMenu.Name = "panel_SlideMenu";
            this.panel_SlideMenu.Size = new System.Drawing.Size(210, 561);
            this.panel_SlideMenu.TabIndex = 0;
            // 
            // iconButton4
            // 
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 260);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.iconButton4.Size = new System.Drawing.Size(210, 60);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Tag = "Tin tức";
            this.iconButton4.Text = "Tin tức";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconBtn_aboutUs
            // 
            this.iconBtn_aboutUs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconBtn_aboutUs.FlatAppearance.BorderSize = 0;
            this.iconBtn_aboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtn_aboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconBtn_aboutUs.ForeColor = System.Drawing.Color.White;
            this.iconBtn_aboutUs.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconBtn_aboutUs.IconColor = System.Drawing.Color.White;
            this.iconBtn_aboutUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtn_aboutUs.IconSize = 30;
            this.iconBtn_aboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtn_aboutUs.Location = new System.Drawing.Point(0, 501);
            this.iconBtn_aboutUs.Name = "iconBtn_aboutUs";
            this.iconBtn_aboutUs.Padding = new System.Windows.Forms.Padding(15, 0, 0, 10);
            this.iconBtn_aboutUs.Size = new System.Drawing.Size(210, 60);
            this.iconBtn_aboutUs.TabIndex = 4;
            this.iconBtn_aboutUs.Tag = "Thông tin nhóm";
            this.iconBtn_aboutUs.Text = "Thông tin nhóm";
            this.iconBtn_aboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBtn_aboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtn_aboutUs.UseVisualStyleBackColor = true;
            this.iconBtn_aboutUs.Click += new System.EventHandler(this.iconBtn_refesh_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 200);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.iconButton3.Size = new System.Drawing.Size(210, 60);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Tag = "Thế giới";
            this.iconButton3.Text = "Tình hình thế giới";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 140);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.iconButton2.Size = new System.Drawing.Size(210, 60);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Tag = "Việt Nam";
            this.iconButton2.Text = "Tình hình Việt Nam";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 80);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(15, 10, 0, 10);
            this.iconButton1.Size = new System.Drawing.Size(210, 60);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Tag = "Dashboard";
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_Logo.Controls.Add(this.btn_menu);
            this.panel_Logo.Controls.Add(this.pictureBox_Logo);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(210, 80);
            this.panel_Logo.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_menu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_menu.IconColor = System.Drawing.Color.White;
            this.btn_menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_menu.IconSize = 30;
            this.btn_menu.Location = new System.Drawing.Point(132, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(60, 60);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(30, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(84, 60);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel_titleBar.Controls.Add(this.iconBtn_minisize);
            this.panel_titleBar.Controls.Add(this.iconBtn_maximize);
            this.panel_titleBar.Controls.Add(this.iconbtn_exit);
            this.panel_titleBar.Controls.Add(this.label_titleBar);
            this.panel_titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_titleBar.Location = new System.Drawing.Point(210, 0);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(921, 80);
            this.panel_titleBar.TabIndex = 1;
            this.panel_titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titleBar_MouseDown);
            // 
            // iconBtn_minisize
            // 
            this.iconBtn_minisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtn_minisize.FlatAppearance.BorderSize = 0;
            this.iconBtn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtn_minisize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtn_minisize.IconColor = System.Drawing.Color.White;
            this.iconBtn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtn_minisize.IconSize = 20;
            this.iconBtn_minisize.Location = new System.Drawing.Point(837, 3);
            this.iconBtn_minisize.Name = "iconBtn_minisize";
            this.iconBtn_minisize.Size = new System.Drawing.Size(23, 23);
            this.iconBtn_minisize.TabIndex = 3;
            this.iconBtn_minisize.UseVisualStyleBackColor = true;
            this.iconBtn_minisize.Click += new System.EventHandler(this.iconBtn_minimize_Click);
            // 
            // iconBtn_maximize
            // 
            this.iconBtn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconBtn_maximize.FlatAppearance.BorderSize = 0;
            this.iconBtn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtn_maximize.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconBtn_maximize.IconColor = System.Drawing.Color.White;
            this.iconBtn_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtn_maximize.IconSize = 20;
            this.iconBtn_maximize.Location = new System.Drawing.Point(866, 3);
            this.iconBtn_maximize.Name = "iconBtn_maximize";
            this.iconBtn_maximize.Size = new System.Drawing.Size(23, 23);
            this.iconBtn_maximize.TabIndex = 2;
            this.iconBtn_maximize.UseVisualStyleBackColor = true;
            this.iconBtn_maximize.Click += new System.EventHandler(this.iconBtn_maximize_Click);
            // 
            // iconbtn_exit
            // 
            this.iconbtn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtn_exit.FlatAppearance.BorderSize = 0;
            this.iconbtn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtn_exit.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.iconbtn_exit.IconColor = System.Drawing.Color.White;
            this.iconbtn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtn_exit.IconSize = 20;
            this.iconbtn_exit.Location = new System.Drawing.Point(895, 3);
            this.iconbtn_exit.Name = "iconbtn_exit";
            this.iconbtn_exit.Size = new System.Drawing.Size(23, 23);
            this.iconbtn_exit.TabIndex = 1;
            this.iconbtn_exit.UseVisualStyleBackColor = true;
            this.iconbtn_exit.Click += new System.EventHandler(this.iconbtn_exit_Click);
            // 
            // label_titleBar
            // 
            this.label_titleBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titleBar.AutoSize = true;
            this.label_titleBar.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_titleBar.ForeColor = System.Drawing.Color.White;
            this.label_titleBar.Location = new System.Drawing.Point(435, 27);
            this.label_titleBar.Name = "label_titleBar";
            this.label_titleBar.Size = new System.Drawing.Size(82, 29);
            this.label_titleBar.TabIndex = 0;
            this.label_titleBar.Text = "HOME";
            // 
            // panel_desktopPane
            // 
            this.panel_desktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_desktopPane.Location = new System.Drawing.Point(210, 80);
            this.panel_desktopPane.Name = "panel_desktopPane";
            this.panel_desktopPane.Size = new System.Drawing.Size(921, 481);
            this.panel_desktopPane.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1131, 561);
            this.Controls.Add(this.panel_desktopPane);
            this.Controls.Add(this.panel_titleBar);
            this.Controls.Add(this.panel_SlideMenu);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel_SlideMenu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_SlideMenu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private FontAwesome.Sharp.IconButton btn_menu;
        private FontAwesome.Sharp.IconButton iconBtn_aboutUs;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel_titleBar;
        private System.Windows.Forms.Label label_titleBar;
        private System.Windows.Forms.Panel panel_desktopPane;
        private FontAwesome.Sharp.IconButton iconBtn_minisize;
        private FontAwesome.Sharp.IconButton iconBtn_maximize;
        private FontAwesome.Sharp.IconButton iconbtn_exit;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}

