namespace file
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.table = new System.Windows.Forms.DataGridView();
            this.filepathTX = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.view_query = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.choice_fileB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentpanal = new System.Windows.Forms.Panel();
            this.search_B = new System.Windows.Forms.Button();
            this.search_TX = new System.Windows.Forms.TextBox();
            this.kindOfSearch_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Aggregate = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.Button();
            this.avg = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.Comparison = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cfield_tx = new System.Windows.Forms.TextBox();
            this.in_range = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.not_equal = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.Button();
            this.great = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Boolean = new System.Windows.Forms.Panel();
            this.conferm = new System.Windows.Forms.Button();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.value = new System.Windows.Forms.TextBox();
            this.or = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.studentpanal.SuspendLayout();
            this.Aggregate.SuspendLayout();
            this.Comparison.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Boolean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition2.SetDecoration(this.table, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.table, BunifuAnimatorNS.DecorationType.None);
            this.table.Location = new System.Drawing.Point(41, 58);
            this.table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.table.Name = "table";
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(920, 449);
            this.table.TabIndex = 0;
            // 
            // filepathTX
            // 
            this.bunifuTransition1.SetDecoration(this.filepathTX, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.filepathTX, BunifuAnimatorNS.DecorationType.None);
            this.filepathTX.Location = new System.Drawing.Point(267, 20);
            this.filepathTX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filepathTX.Name = "filepathTX";
            this.filepathTX.Size = new System.Drawing.Size(488, 22);
            this.filepathTX.TabIndex = 2;
            // 
            // openFile
            // 
            this.openFile.FileName = "open";
            this.openFile.Filter = "(*.xml)|*.xml";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 36);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = global::file.Properties.Resources.box;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::file.Properties.Resources._operator;
            this.pictureBox1.Location = new System.Drawing.Point(663, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(699, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Querying Module";
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1393, -5);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.reset);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.view_query);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.choice_fileB);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 850);
            this.panel2.TabIndex = 8;
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.bunifuTransition1.SetDecoration(this.reset, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.reset, BunifuAnimatorNS.DecorationType.None);
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.reset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.reset.ForeColor = System.Drawing.Color.DarkRed;
            this.reset.Image = global::file.Properties.Resources.eraser;
            this.reset.Location = new System.Drawing.Point(15, 400);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(211, 220);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 850);
            this.panel7.TabIndex = 15;
            // 
            // view_query
            // 
            this.view_query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.bunifuTransition1.SetDecoration(this.view_query, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.view_query, BunifuAnimatorNS.DecorationType.None);
            this.view_query.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.view_query.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.view_query.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.view_query.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.view_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_query.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.view_query.ForeColor = System.Drawing.Color.DarkRed;
            this.view_query.Image = global::file.Properties.Resources.Webp_net_resizeimage;
            this.view_query.Location = new System.Drawing.Point(15, 620);
            this.view_query.Margin = new System.Windows.Forms.Padding(4);
            this.view_query.Name = "view_query";
            this.view_query.Size = new System.Drawing.Size(211, 217);
            this.view_query.TabIndex = 3;
            this.view_query.Text = "Make Any Query";
            this.view_query.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.view_query.UseVisualStyleBackColor = false;
            this.view_query.Click += new System.EventHandler(this.view_query_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.bunifuTransition1.SetDecoration(this.Update, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Update, BunifuAnimatorNS.DecorationType.None);
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Update.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.Update.ForeColor = System.Drawing.Color.DarkRed;
            this.Update.Image = global::file.Properties.Resources.update__2_;
            this.Update.Location = new System.Drawing.Point(15, 208);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(211, 192);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update Your Changes";
            this.Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // choice_fileB
            // 
            this.choice_fileB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.bunifuTransition1.SetDecoration(this.choice_fileB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.choice_fileB, BunifuAnimatorNS.DecorationType.None);
            this.choice_fileB.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.choice_fileB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.choice_fileB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.choice_fileB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.choice_fileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice_fileB.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_fileB.ForeColor = System.Drawing.Color.DarkRed;
            this.choice_fileB.Image = global::file.Properties.Resources.file__1_;
            this.choice_fileB.Location = new System.Drawing.Point(15, 15);
            this.choice_fileB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choice_fileB.Name = "choice_fileB";
            this.choice_fileB.Size = new System.Drawing.Size(211, 193);
            this.choice_fileB.TabIndex = 1;
            this.choice_fileB.Text = "Upload Your XML File";
            this.choice_fileB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.choice_fileB.UseVisualStyleBackColor = false;
            this.choice_fileB.Click += new System.EventHandler(this.choice_file_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.filepathTX);
            this.panel3.Controls.Add(this.table);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(248, 244);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(980, 516);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::file.Properties.Resources.sql_file_black_rounded_rectangular_interface_symbol__1_;
            this.button2.Location = new System.Drawing.Point(798, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 36);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your File Name is :";
            // 
            // studentpanal
            // 
            this.studentpanal.BackColor = System.Drawing.Color.Transparent;
            this.studentpanal.Controls.Add(this.search_B);
            this.studentpanal.Controls.Add(this.search_TX);
            this.studentpanal.Controls.Add(this.kindOfSearch_CB);
            this.studentpanal.Controls.Add(this.label5);
            this.bunifuTransition2.SetDecoration(this.studentpanal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.studentpanal, BunifuAnimatorNS.DecorationType.None);
            this.studentpanal.Location = new System.Drawing.Point(252, 766);
            this.studentpanal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentpanal.Name = "studentpanal";
            this.studentpanal.Size = new System.Drawing.Size(556, 100);
            this.studentpanal.TabIndex = 13;
            this.studentpanal.Visible = false;
            // 
            // search_B
            // 
            this.search_B.BackColor = System.Drawing.Color.Transparent;
            this.search_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.search_B, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.search_B, BunifuAnimatorNS.DecorationType.None);
            this.search_B.FlatAppearance.BorderSize = 0;
            this.search_B.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.search_B.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.search_B.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_B.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.search_B.Image = global::file.Properties.Resources.search__1_;
            this.search_B.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_B.Location = new System.Drawing.Point(308, 34);
            this.search_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_B.Name = "search_B";
            this.search_B.Size = new System.Drawing.Size(44, 32);
            this.search_B.TabIndex = 8;
            this.search_B.UseVisualStyleBackColor = false;
            this.search_B.Click += new System.EventHandler(this.search_B_Click);
            // 
            // search_TX
            // 
            this.search_TX.BackColor = System.Drawing.Color.Black;
            this.search_TX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.search_TX, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.search_TX, BunifuAnimatorNS.DecorationType.None);
            this.search_TX.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.search_TX.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.search_TX.Location = new System.Drawing.Point(349, 36);
            this.search_TX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_TX.Name = "search_TX";
            this.search_TX.Size = new System.Drawing.Size(197, 32);
            this.search_TX.TabIndex = 7;
            this.search_TX.Text = " search";
            this.search_TX.Click += new System.EventHandler(this.search_TX_Click);
            // 
            // kindOfSearch_CB
            // 
            this.kindOfSearch_CB.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.kindOfSearch_CB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.kindOfSearch_CB, BunifuAnimatorNS.DecorationType.None);
            this.kindOfSearch_CB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.kindOfSearch_CB.FormattingEnabled = true;
            this.kindOfSearch_CB.Items.AddRange(new object[] {
            "department",
            "gender",
            "id",
            "name",
            "project"});
            this.kindOfSearch_CB.Location = new System.Drawing.Point(141, 36);
            this.kindOfSearch_CB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kindOfSearch_CB.Name = "kindOfSearch_CB";
            this.kindOfSearch_CB.Size = new System.Drawing.Size(161, 32);
            this.kindOfSearch_CB.Sorted = true;
            this.kindOfSearch_CB.TabIndex = 6;
            this.kindOfSearch_CB.Text = "name";
            this.kindOfSearch_CB.SelectedIndexChanged += new System.EventHandler(this.kindOfSearch_CB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label5.Location = new System.Drawing.Point(4, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search By :";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.MaxAnimationTime = 30000;
            // 
            // Aggregate
            // 
            this.Aggregate.BackColor = System.Drawing.Color.Transparent;
            this.Aggregate.Controls.Add(this.max);
            this.Aggregate.Controls.Add(this.avg);
            this.Aggregate.Controls.Add(this.min);
            this.Aggregate.Controls.Add(this.sum);
            this.bunifuTransition2.SetDecoration(this.Aggregate, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Aggregate, BunifuAnimatorNS.DecorationType.None);
            this.Aggregate.Location = new System.Drawing.Point(252, 117);
            this.Aggregate.Margin = new System.Windows.Forms.Padding(4);
            this.Aggregate.Name = "Aggregate";
            this.Aggregate.Size = new System.Drawing.Size(976, 127);
            this.Aggregate.TabIndex = 2;
            this.Aggregate.Visible = false;
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.max, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.max, BunifuAnimatorNS.DecorationType.None);
            this.max.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.max.Image = global::file.Properties.Resources.max;
            this.max.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.max.Location = new System.Drawing.Point(627, 20);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(112, 95);
            this.max.TabIndex = 3;
            this.max.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.max.UseVisualStyleBackColor = false;
            this.max.Visible = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // avg
            // 
            this.avg.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.avg, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.avg, BunifuAnimatorNS.DecorationType.None);
            this.avg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.avg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.avg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.avg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avg.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.avg.Image = global::file.Properties.Resources.average;
            this.avg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.avg.Location = new System.Drawing.Point(387, 20);
            this.avg.Margin = new System.Windows.Forms.Padding(4);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(112, 95);
            this.avg.TabIndex = 2;
            this.avg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.avg.UseVisualStyleBackColor = false;
            this.avg.Visible = false;
            this.avg.Click += new System.EventHandler(this.avg_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.min, BunifuAnimatorNS.DecorationType.None);
            this.min.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.min.Image = global::file.Properties.Resources.min1;
            this.min.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.min.Location = new System.Drawing.Point(507, 20);
            this.min.Margin = new System.Windows.Forms.Padding(4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(112, 95);
            this.min.TabIndex = 1;
            this.min.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.min.UseVisualStyleBackColor = false;
            this.min.Visible = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.sum, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.sum, BunifuAnimatorNS.DecorationType.None);
            this.sum.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.sum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.sum.Image = global::file.Properties.Resources.symbol__2_;
            this.sum.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.Location = new System.Drawing.Point(267, 20);
            this.sum.Margin = new System.Windows.Forms.Padding(4);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(112, 95);
            this.sum.TabIndex = 0;
            this.sum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Visible = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Comparison
            // 
            this.Comparison.BackColor = System.Drawing.Color.Transparent;
            this.Comparison.Controls.Add(this.label4);
            this.Comparison.Controls.Add(this.cfield_tx);
            this.Comparison.Controls.Add(this.in_range);
            this.Comparison.Controls.Add(this.equal);
            this.Comparison.Controls.Add(this.not_equal);
            this.Comparison.Controls.Add(this.small);
            this.Comparison.Controls.Add(this.great);
            this.bunifuTransition2.SetDecoration(this.Comparison, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Comparison, BunifuAnimatorNS.DecorationType.None);
            this.Comparison.Location = new System.Drawing.Point(1237, 137);
            this.Comparison.Margin = new System.Windows.Forms.Padding(4);
            this.Comparison.Name = "Comparison";
            this.Comparison.Size = new System.Drawing.Size(200, 750);
            this.Comparison.TabIndex = 4;
            this.Comparison.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add Number :";
            // 
            // cfield_tx
            // 
            this.bunifuTransition1.SetDecoration(this.cfield_tx, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.cfield_tx, BunifuAnimatorNS.DecorationType.None);
            this.cfield_tx.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.cfield_tx.ForeColor = System.Drawing.Color.Gray;
            this.cfield_tx.Location = new System.Drawing.Point(13, 62);
            this.cfield_tx.Margin = new System.Windows.Forms.Padding(4);
            this.cfield_tx.Multiline = true;
            this.cfield_tx.Name = "cfield_tx";
            this.cfield_tx.Size = new System.Drawing.Size(179, 32);
            this.cfield_tx.TabIndex = 3;
            this.cfield_tx.Text = "Comparison Field";
            this.cfield_tx.Visible = false;
            this.cfield_tx.Click += new System.EventHandler(this.cfield_tx_Click);
            // 
            // in_range
            // 
            this.in_range.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.in_range, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.in_range, BunifuAnimatorNS.DecorationType.None);
            this.in_range.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.in_range.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.in_range.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.in_range.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.in_range.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.in_range.Image = global::file.Properties.Resources.spacing;
            this.in_range.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.in_range.Location = new System.Drawing.Point(39, 533);
            this.in_range.Margin = new System.Windows.Forms.Padding(4);
            this.in_range.Name = "in_range";
            this.in_range.Size = new System.Drawing.Size(112, 95);
            this.in_range.TabIndex = 3;
            this.in_range.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.in_range.UseVisualStyleBackColor = false;
            this.in_range.Visible = false;
            this.in_range.Click += new System.EventHandler(this.in_range_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.equal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.equal, BunifuAnimatorNS.DecorationType.None);
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.equal.Image = global::file.Properties.Resources.judge;
            this.equal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.equal.Location = new System.Drawing.Point(39, 124);
            this.equal.Margin = new System.Windows.Forms.Padding(4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(112, 95);
            this.equal.TabIndex = 5;
            this.equal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Visible = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // not_equal
            // 
            this.not_equal.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.not_equal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.not_equal, BunifuAnimatorNS.DecorationType.None);
            this.not_equal.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.not_equal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.not_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.not_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.not_equal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.not_equal.Image = global::file.Properties.Resources.balance;
            this.not_equal.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.not_equal.Location = new System.Drawing.Point(39, 228);
            this.not_equal.Margin = new System.Windows.Forms.Padding(4);
            this.not_equal.Name = "not_equal";
            this.not_equal.Size = new System.Drawing.Size(112, 95);
            this.not_equal.TabIndex = 4;
            this.not_equal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.not_equal.UseVisualStyleBackColor = false;
            this.not_equal.Visible = false;
            this.not_equal.Click += new System.EventHandler(this.not_equal_Click);
            // 
            // small
            // 
            this.small.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.small, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.small, BunifuAnimatorNS.DecorationType.None);
            this.small.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.small.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.small.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.small.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.small.Image = global::file.Properties.Resources.chevron_pointing_to_the_left__1_;
            this.small.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.small.Location = new System.Drawing.Point(39, 428);
            this.small.Margin = new System.Windows.Forms.Padding(4);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(112, 95);
            this.small.TabIndex = 2;
            this.small.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.small.UseVisualStyleBackColor = false;
            this.small.Visible = false;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // great
            // 
            this.great.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.great, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.great, BunifuAnimatorNS.DecorationType.None);
            this.great.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.great.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(47)))), ((int)(((byte)(189)))));
            this.great.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(199)))), ((int)(((byte)(228)))));
            this.great.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.great.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.great.Image = global::file.Properties.Resources.move_to_next__1_;
            this.great.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.great.Location = new System.Drawing.Point(39, 334);
            this.great.Margin = new System.Windows.Forms.Padding(4);
            this.great.Name = "great";
            this.great.Size = new System.Drawing.Size(112, 85);
            this.great.TabIndex = 1;
            this.great.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.great.UseVisualStyleBackColor = false;
            this.great.Visible = false;
            this.great.Click += new System.EventHandler(this.great_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose Of Following :";
            // 
            // comboBox3
            // 
            this.bunifuTransition2.SetDecoration(this.comboBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.comboBox3, BunifuAnimatorNS.DecorationType.None);
            this.comboBox3.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1, 42);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(183, 32);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.comboBox3);
            this.panel4.Controls.Add(this.label3);
            this.bunifuTransition2.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(1243, 50);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 68);
            this.panel4.TabIndex = 10;
            this.panel4.Visible = false;
            // 
            // Boolean
            // 
            this.Boolean.BackColor = System.Drawing.Color.Transparent;
            this.Boolean.Controls.Add(this.conferm);
            this.Boolean.Controls.Add(this.Operator);
            this.Boolean.Controls.Add(this.value);
            this.Boolean.Controls.Add(this.or);
            this.Boolean.Controls.Add(this.and);
            this.bunifuTransition2.SetDecoration(this.Boolean, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Boolean, BunifuAnimatorNS.DecorationType.None);
            this.Boolean.Location = new System.Drawing.Point(812, 768);
            this.Boolean.Margin = new System.Windows.Forms.Padding(4);
            this.Boolean.Name = "Boolean";
            this.Boolean.Size = new System.Drawing.Size(417, 98);
            this.Boolean.TabIndex = 11;
            this.Boolean.Visible = false;
            // 
            // conferm
            // 
            this.conferm.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.conferm, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.conferm, BunifuAnimatorNS.DecorationType.None);
            this.conferm.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.conferm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.conferm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.conferm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.conferm.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.conferm.ForeColor = System.Drawing.Color.DarkRed;
            this.conferm.Location = new System.Drawing.Point(259, 64);
            this.conferm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.conferm.Name = "conferm";
            this.conferm.Size = new System.Drawing.Size(148, 34);
            this.conferm.TabIndex = 10;
            this.conferm.Text = "Confarm";
            this.conferm.UseVisualStyleBackColor = false;
            this.conferm.Click += new System.EventHandler(this.conferm_Click);
            // 
            // Operator
            // 
            this.Operator.BackColor = System.Drawing.Color.White;
            this.bunifuTransition2.SetDecoration(this.Operator, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Operator, BunifuAnimatorNS.DecorationType.None);
            this.Operator.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.Operator.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Operator.FormattingEnabled = true;
            this.Operator.Items.AddRange(new object[] {
            "!=",
            "<",
            "=",
            ">"});
            this.Operator.Location = new System.Drawing.Point(259, 2);
            this.Operator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(148, 32);
            this.Operator.Sorted = true;
            this.Operator.TabIndex = 9;
            this.Operator.Text = "Operator";
            this.Operator.SelectedIndexChanged += new System.EventHandler(this.kind_SelectedIndexChanged);
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.Black;
            this.value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.value, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.value, BunifuAnimatorNS.DecorationType.None);
            this.value.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.value.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.value.Location = new System.Drawing.Point(259, 32);
            this.value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(149, 32);
            this.value.TabIndex = 8;
            this.value.Text = "Value";
            this.value.Click += new System.EventHandler(this.value_click);
            // 
            // or
            // 
            this.or.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.or, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.or, BunifuAnimatorNS.DecorationType.None);
            this.or.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.or.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.or.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.or.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.or.ForeColor = System.Drawing.Color.DarkRed;
            this.or.Image = global::file.Properties.Resources.Webp_net_resizeimage__3_;
            this.or.Location = new System.Drawing.Point(124, 0);
            this.or.Margin = new System.Windows.Forms.Padding(4);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(112, 95);
            this.or.TabIndex = 2;
            this.or.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.or.UseVisualStyleBackColor = false;
            this.or.Visible = false;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // and
            // 
            this.and.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.and, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.and, BunifuAnimatorNS.DecorationType.None);
            this.and.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.and.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.and.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(151)))), ((int)(((byte)(221)))));
            this.and.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.and.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.and.ForeColor = System.Drawing.Color.DarkRed;
            this.and.Image = ((System.Drawing.Image)(resources.GetObject("and.Image")));
            this.and.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.and.Location = new System.Drawing.Point(4, 0);
            this.and.Margin = new System.Windows.Forms.Padding(4);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(112, 95);
            this.and.TabIndex = 1;
            this.and.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.and.UseVisualStyleBackColor = false;
            this.and.Visible = false;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(497, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To Querying Module";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1427, 36);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 850);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 872);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1427, 14);
            this.panel6.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1427, 14);
            this.panel8.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1440, 851);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(1282, 839);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "Loading...";
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.VertBlind;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.studentpanal);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Boolean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aggregate);
            this.Controls.Add(this.Comparison);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.studentpanal.ResumeLayout(false);
            this.studentpanal.PerformLayout();
            this.Aggregate.ResumeLayout(false);
            this.Comparison.ResumeLayout(false);
            this.Comparison.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Boolean.ResumeLayout(false);
            this.Boolean.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button choice_fileB;
        private System.Windows.Forms.TextBox filepathTX;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button view_query;
        private System.Windows.Forms.Panel Aggregate;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button avg;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button sum;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Panel Comparison;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button not_equal;
        private System.Windows.Forms.Button in_range;
        private System.Windows.Forms.Button small;
        private System.Windows.Forms.Button great;
        private System.Windows.Forms.TextBox cfield_tx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Boolean;
        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel studentpanal;
        private System.Windows.Forms.Button search_B;
        private System.Windows.Forms.TextBox search_TX;
        private System.Windows.Forms.ComboBox kindOfSearch_CB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button conferm;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
