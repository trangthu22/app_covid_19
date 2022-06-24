
namespace AppCovid19.GUI
{
    partial class FormSituationWorld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_tmpArea = new System.Windows.Forms.Label();
            this.btn_reset = new FontAwesome.Sharp.IconButton();
            this.btn_search = new FontAwesome.Sharp.IconButton();
            this.txt_search = new AppCovid19.CustomerComponent.CustomTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_australia = new FontAwesome.Sharp.IconButton();
            this.btn_northAmerica = new FontAwesome.Sharp.IconButton();
            this.btn_southAmerica = new FontAwesome.Sharp.IconButton();
            this.btn_africa = new FontAwesome.Sharp.IconButton();
            this.btn_europe = new FontAwesome.Sharp.IconButton();
            this.btn_asia = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 350);
            this.panel3.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 59);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(800, 291);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(239)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(800, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Quốc gia";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ca nhiễm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trong ngày";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ca tử vong";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trong ngày";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ca khỏi bệnh";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ca dương tính";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ca nguy kịch";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbl_tmpArea);
            this.panel4.Controls.Add(this.btn_reset);
            this.panel4.Controls.Add(this.btn_search);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 59);
            this.panel4.TabIndex = 0;
            // 
            // lbl_tmpArea
            // 
            this.lbl_tmpArea.AutoSize = true;
            this.lbl_tmpArea.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tmpArea.ForeColor = System.Drawing.Color.White;
            this.lbl_tmpArea.Location = new System.Drawing.Point(725, 0);
            this.lbl_tmpArea.Name = "lbl_tmpArea";
            this.lbl_tmpArea.Size = new System.Drawing.Size(0, 15);
            this.lbl_tmpArea.TabIndex = 3;
            // 
            // btn_reset
            // 
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.btn_reset.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reset.IconSize = 30;
            this.btn_reset.Location = new System.Drawing.Point(725, 0);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 59);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_search.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_search.IconSize = 30;
            this.btn_search.Location = new System.Drawing.Point(291, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 40);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txt_search.BorderSize = 2;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_search.ForeColor = System.Drawing.Color.DimGray;
            this.txt_search.Location = new System.Drawing.Point(34, 7);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(7);
            this.txt_search.Size = new System.Drawing.Size(250, 35);
            this.txt_search.TabIndex = 0;
            this.txt_search.UnderLinedStyle = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btn_australia, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_northAmerica, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_southAmerica, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_africa, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_europe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_asia, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_australia
            // 
            this.btn_australia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_australia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_australia.FlatAppearance.BorderSize = 0;
            this.btn_australia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_australia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_australia.ForeColor = System.Drawing.Color.White;
            this.btn_australia.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.btn_australia.IconColor = System.Drawing.Color.White;
            this.btn_australia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_australia.Location = new System.Drawing.Point(668, 3);
            this.btn_australia.Name = "btn_australia";
            this.btn_australia.Size = new System.Drawing.Size(129, 94);
            this.btn_australia.TabIndex = 5;
            this.btn_australia.Tag = "Australia/Oceania";
            this.btn_australia.Text = "Châu Úc";
            this.btn_australia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_australia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_australia.UseVisualStyleBackColor = false;
            this.btn_australia.Click += new System.EventHandler(this.btn_australia_Click);
            // 
            // btn_northAmerica
            // 
            this.btn_northAmerica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_northAmerica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_northAmerica.FlatAppearance.BorderSize = 0;
            this.btn_northAmerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_northAmerica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_northAmerica.ForeColor = System.Drawing.Color.White;
            this.btn_northAmerica.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btn_northAmerica.IconColor = System.Drawing.Color.White;
            this.btn_northAmerica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_northAmerica.Location = new System.Drawing.Point(535, 3);
            this.btn_northAmerica.Name = "btn_northAmerica";
            this.btn_northAmerica.Size = new System.Drawing.Size(127, 94);
            this.btn_northAmerica.TabIndex = 4;
            this.btn_northAmerica.Tag = "North America";
            this.btn_northAmerica.Text = "Bắc Mỹ";
            this.btn_northAmerica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_northAmerica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_northAmerica.UseVisualStyleBackColor = false;
            this.btn_northAmerica.Click += new System.EventHandler(this.btn_northAmerica_Click);
            // 
            // btn_southAmerica
            // 
            this.btn_southAmerica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_southAmerica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_southAmerica.FlatAppearance.BorderSize = 0;
            this.btn_southAmerica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_southAmerica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_southAmerica.ForeColor = System.Drawing.Color.White;
            this.btn_southAmerica.IconChar = FontAwesome.Sharp.IconChar.GlobeAmericas;
            this.btn_southAmerica.IconColor = System.Drawing.Color.White;
            this.btn_southAmerica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_southAmerica.Location = new System.Drawing.Point(402, 3);
            this.btn_southAmerica.Name = "btn_southAmerica";
            this.btn_southAmerica.Size = new System.Drawing.Size(127, 94);
            this.btn_southAmerica.TabIndex = 3;
            this.btn_southAmerica.Tag = "South America";
            this.btn_southAmerica.Text = "Nam Mỹ";
            this.btn_southAmerica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_southAmerica.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_southAmerica.UseVisualStyleBackColor = false;
            this.btn_southAmerica.Click += new System.EventHandler(this.btn_southAmerica_Click);
            // 
            // btn_africa
            // 
            this.btn_africa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_africa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_africa.FlatAppearance.BorderSize = 0;
            this.btn_africa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_africa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_africa.ForeColor = System.Drawing.Color.White;
            this.btn_africa.IconChar = FontAwesome.Sharp.IconChar.GlobeAfrica;
            this.btn_africa.IconColor = System.Drawing.Color.White;
            this.btn_africa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_africa.Location = new System.Drawing.Point(269, 3);
            this.btn_africa.Name = "btn_africa";
            this.btn_africa.Size = new System.Drawing.Size(127, 94);
            this.btn_africa.TabIndex = 2;
            this.btn_africa.Tag = "Africa";
            this.btn_africa.Text = "Châu Phi";
            this.btn_africa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_africa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_africa.UseVisualStyleBackColor = false;
            this.btn_africa.Click += new System.EventHandler(this.btn_africa_Click);
            // 
            // btn_europe
            // 
            this.btn_europe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_europe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_europe.FlatAppearance.BorderSize = 0;
            this.btn_europe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_europe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_europe.ForeColor = System.Drawing.Color.White;
            this.btn_europe.IconChar = FontAwesome.Sharp.IconChar.GlobeEurope;
            this.btn_europe.IconColor = System.Drawing.Color.White;
            this.btn_europe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_europe.Location = new System.Drawing.Point(136, 3);
            this.btn_europe.Name = "btn_europe";
            this.btn_europe.Size = new System.Drawing.Size(127, 94);
            this.btn_europe.TabIndex = 1;
            this.btn_europe.Tag = "Europe";
            this.btn_europe.Text = "Châu Âu";
            this.btn_europe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_europe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_europe.UseVisualStyleBackColor = false;
            this.btn_europe.Click += new System.EventHandler(this.btn_europe_Click);
            // 
            // btn_asia
            // 
            this.btn_asia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(91)))));
            this.btn_asia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_asia.FlatAppearance.BorderSize = 0;
            this.btn_asia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_asia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_asia.ForeColor = System.Drawing.Color.White;
            this.btn_asia.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.btn_asia.IconColor = System.Drawing.Color.White;
            this.btn_asia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_asia.Location = new System.Drawing.Point(3, 3);
            this.btn_asia.Name = "btn_asia";
            this.btn_asia.Size = new System.Drawing.Size(127, 94);
            this.btn_asia.TabIndex = 0;
            this.btn_asia.Tag = "Asia";
            this.btn_asia.Text = "Châu Á";
            this.btn_asia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_asia.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_asia.UseVisualStyleBackColor = false;
            this.btn_asia.Click += new System.EventHandler(this.btn_asia_Click);
            // 
            // FormSituationWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormSituationWorld";
            this.Text = "Tình hình thế giới";
            this.Load += new System.EventHandler(this.FormSituationWorld_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_asia;
        private FontAwesome.Sharp.IconButton btn_australia;
        private FontAwesome.Sharp.IconButton btn_northAmerica;
        private FontAwesome.Sharp.IconButton btn_southAmerica;
        private FontAwesome.Sharp.IconButton btn_africa;
        private FontAwesome.Sharp.IconButton btn_europe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private CustomerComponent.CustomTextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_reset;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label lbl_tmpArea;
    }
}