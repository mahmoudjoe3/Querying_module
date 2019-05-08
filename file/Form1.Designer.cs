﻿namespace file
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.choice_fileB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studentpanal = new System.Windows.Forms.Panel();
            this.search_B = new System.Windows.Forms.Button();
            this.search_TX = new System.Windows.Forms.TextBox();
            this.kindOfSearch_CB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.or = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.studentpanal.SuspendLayout();
            this.Aggregate.SuspendLayout();
            this.Comparison.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Boolean.SuspendLayout();
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
            // comboBox1
            // 
            this.bunifuTransition2.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "=",
            "!=",
            ">",
            "<",
            "in"});
            this.comboBox1.Location = new System.Drawing.Point(252, 755);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(22, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Update);
            this.panel2.Controls.Add(this.choice_fileB);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 850);
            this.panel2.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(15, 570);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 267);
            this.button3.TabIndex = 3;
            this.button3.Text = "Make Any Query";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.Update, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.Update, BunifuAnimatorNS.DecorationType.None);
            this.Update.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.Location = new System.Drawing.Point(15, 295);
            this.Update.Margin = new System.Windows.Forms.Padding(4);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(211, 276);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update Your Changes";
            this.Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // choice_fileB
            // 
            this.choice_fileB.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.choice_fileB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.choice_fileB, BunifuAnimatorNS.DecorationType.None);
            this.choice_fileB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.choice_fileB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.choice_fileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice_fileB.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_fileB.Image = ((System.Drawing.Image)(resources.GetObject("choice_fileB.Image")));
            this.choice_fileB.Location = new System.Drawing.Point(15, 18);
            this.choice_fileB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.choice_fileB.Name = "choice_fileB";
            this.choice_fileB.Size = new System.Drawing.Size(211, 280);
            this.choice_fileB.TabIndex = 1;
            this.choice_fileB.Text = "Upload Your XML File";
            this.choice_fileB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.choice_fileB.UseVisualStyleBackColor = false;
            this.choice_fileB.Click += new System.EventHandler(this.choice_file_Click);
            // 
            // panel3
            // 
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
            // studentpanal
            // 
            this.studentpanal.Controls.Add(this.search_B);
            this.studentpanal.Controls.Add(this.search_TX);
            this.studentpanal.Controls.Add(this.kindOfSearch_CB);
            this.studentpanal.Controls.Add(this.label5);
            this.bunifuTransition2.SetDecoration(this.studentpanal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.studentpanal, BunifuAnimatorNS.DecorationType.None);
            this.studentpanal.Location = new System.Drawing.Point(440, 763);
            this.studentpanal.Name = "studentpanal";
            this.studentpanal.Size = new System.Drawing.Size(603, 100);
            this.studentpanal.TabIndex = 13;
            this.studentpanal.Visible = false;
            // 
            // search_B
            // 
            this.search_B.BackColor = System.Drawing.Color.White;
            this.search_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.search_B, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.search_B, BunifuAnimatorNS.DecorationType.None);
            this.search_B.FlatAppearance.BorderSize = 0;
            this.search_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_B.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.search_B.Location = new System.Drawing.Point(522, 36);
            this.search_B.Name = "search_B";
            this.search_B.Size = new System.Drawing.Size(71, 32);
            this.search_B.TabIndex = 8;
            this.search_B.Text = "Search";
            this.search_B.UseVisualStyleBackColor = false;
            this.search_B.Click += new System.EventHandler(this.search_B_Click);
            // 
            // search_TX
            // 
            this.search_TX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.search_TX, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.search_TX, BunifuAnimatorNS.DecorationType.None);
            this.search_TX.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.search_TX.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.search_TX.Location = new System.Drawing.Point(326, 36);
            this.search_TX.Name = "search_TX";
            this.search_TX.Size = new System.Drawing.Size(197, 32);
            this.search_TX.TabIndex = 7;
            this.search_TX.Text = " search";
            this.search_TX.Click += new System.EventHandler(this.search_TX_Click);
            // 
            // kindOfSearch_CB
            // 
            this.kindOfSearch_CB.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuTransition2.SetDecoration(this.kindOfSearch_CB, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.kindOfSearch_CB, BunifuAnimatorNS.DecorationType.None);
            this.kindOfSearch_CB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.kindOfSearch_CB.FormattingEnabled = true;
            this.kindOfSearch_CB.Items.AddRange(new object[] {
            "department",
            "gender",
            "id",
            "name"});
            this.kindOfSearch_CB.Location = new System.Drawing.Point(141, 36);
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
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(4, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 35);
            this.label5.TabIndex = 5;
            this.label5.Text = "Search By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(35, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your File Path is :";
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
            this.Aggregate.BackColor = System.Drawing.Color.Black;
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
            this.max.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.max, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.max, BunifuAnimatorNS.DecorationType.None);
            this.max.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.max.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.max.Image = ((System.Drawing.Image)(resources.GetObject("max.Image")));
            this.max.Location = new System.Drawing.Point(626, 20);
            this.max.Margin = new System.Windows.Forms.Padding(4);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(112, 95);
            this.max.TabIndex = 3;
            this.max.Text = "MAX";
            this.max.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.max.UseVisualStyleBackColor = false;
            this.max.Visible = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // avg
            // 
            this.avg.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.avg, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.avg, BunifuAnimatorNS.DecorationType.None);
            this.avg.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.avg.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.avg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.avg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avg.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.avg.Image = ((System.Drawing.Image)(resources.GetObject("avg.Image")));
            this.avg.Location = new System.Drawing.Point(386, 20);
            this.avg.Margin = new System.Windows.Forms.Padding(4);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(112, 95);
            this.avg.TabIndex = 2;
            this.avg.Text = "AVG";
            this.avg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.avg.UseVisualStyleBackColor = false;
            this.avg.Visible = false;
            this.avg.Click += new System.EventHandler(this.avg_Click);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.min, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.min, BunifuAnimatorNS.DecorationType.None);
            this.min.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.min.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.Location = new System.Drawing.Point(506, 20);
            this.min.Margin = new System.Windows.Forms.Padding(4);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(112, 95);
            this.min.TabIndex = 1;
            this.min.Text = "MIN";
            this.min.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.min.UseVisualStyleBackColor = false;
            this.min.Visible = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.sum, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.sum, BunifuAnimatorNS.DecorationType.None);
            this.sum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sum.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.sum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sum.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.sum.Image = ((System.Drawing.Image)(resources.GetObject("sum.Image")));
            this.sum.Location = new System.Drawing.Point(266, 20);
            this.sum.Margin = new System.Windows.Forms.Padding(4);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(112, 95);
            this.sum.TabIndex = 0;
            this.sum.Text = "SUM";
            this.sum.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sum.UseVisualStyleBackColor = false;
            this.sum.Visible = false;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Comparison
            // 
            this.Comparison.BackColor = System.Drawing.Color.Black;
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
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
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
            this.cfield_tx.Location = new System.Drawing.Point(13, 61);
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
            this.in_range.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.in_range, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.in_range, BunifuAnimatorNS.DecorationType.None);
            this.in_range.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.in_range.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.in_range.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.in_range.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.in_range.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.in_range.Image = ((System.Drawing.Image)(resources.GetObject("in_range.Image")));
            this.in_range.Location = new System.Drawing.Point(39, 533);
            this.in_range.Margin = new System.Windows.Forms.Padding(4);
            this.in_range.Name = "in_range";
            this.in_range.Size = new System.Drawing.Size(112, 95);
            this.in_range.TabIndex = 3;
            this.in_range.Text = "IN";
            this.in_range.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.in_range.UseVisualStyleBackColor = false;
            this.in_range.Visible = false;
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.equal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.equal, BunifuAnimatorNS.DecorationType.None);
            this.equal.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.equal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.equal.Image = ((System.Drawing.Image)(resources.GetObject("equal.Image")));
            this.equal.Location = new System.Drawing.Point(39, 124);
            this.equal.Margin = new System.Windows.Forms.Padding(4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(112, 95);
            this.equal.TabIndex = 5;
            this.equal.Text = "Equal";
            this.equal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Visible = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // not_equal
            // 
            this.not_equal.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.not_equal, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.not_equal, BunifuAnimatorNS.DecorationType.None);
            this.not_equal.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.not_equal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.not_equal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.not_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.not_equal.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.not_equal.Image = ((System.Drawing.Image)(resources.GetObject("not_equal.Image")));
            this.not_equal.Location = new System.Drawing.Point(39, 228);
            this.not_equal.Margin = new System.Windows.Forms.Padding(4);
            this.not_equal.Name = "not_equal";
            this.not_equal.Size = new System.Drawing.Size(112, 95);
            this.not_equal.TabIndex = 4;
            this.not_equal.Text = "Not Equal";
            this.not_equal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.not_equal.UseVisualStyleBackColor = false;
            this.not_equal.Visible = false;
            this.not_equal.Click += new System.EventHandler(this.not_equal_Click);
            // 
            // small
            // 
            this.small.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.small, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.small, BunifuAnimatorNS.DecorationType.None);
            this.small.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.small.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.small.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.small.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.small.Image = ((System.Drawing.Image)(resources.GetObject("small.Image")));
            this.small.Location = new System.Drawing.Point(39, 428);
            this.small.Margin = new System.Windows.Forms.Padding(4);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(112, 95);
            this.small.TabIndex = 2;
            this.small.Text = "SmallThan";
            this.small.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.small.UseVisualStyleBackColor = false;
            this.small.Visible = false;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // great
            // 
            this.great.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.great, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.great, BunifuAnimatorNS.DecorationType.None);
            this.great.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.great.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.great.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.great.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.great.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.great.Image = ((System.Drawing.Image)(resources.GetObject("great.Image")));
            this.great.Location = new System.Drawing.Point(39, 333);
            this.great.Margin = new System.Windows.Forms.Padding(4);
            this.great.Name = "great";
            this.great.Size = new System.Drawing.Size(112, 85);
            this.great.TabIndex = 1;
            this.great.Text = "GreatThan";
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
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
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
            this.comboBox3.Items.AddRange(new object[] {
            "Aggregate functions",
            "Comparison queries",
            "Boolean opperators",
            "Search"});
            this.comboBox3.Location = new System.Drawing.Point(1, 42);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(183, 32);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MistyRose;
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
            this.Boolean.BackColor = System.Drawing.Color.Black;
            this.Boolean.Controls.Add(this.or);
            this.Boolean.Controls.Add(this.and);
            this.bunifuTransition2.SetDecoration(this.Boolean, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.Boolean, BunifuAnimatorNS.DecorationType.None);
            this.Boolean.Location = new System.Drawing.Point(621, 768);
            this.Boolean.Margin = new System.Windows.Forms.Padding(4);
            this.Boolean.Name = "Boolean";
            this.Boolean.Size = new System.Drawing.Size(238, 99);
            this.Boolean.TabIndex = 11;
            this.Boolean.Visible = false;
            // 
            // or
            // 
            this.or.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.or, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.or, BunifuAnimatorNS.DecorationType.None);
            this.or.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.or.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.or.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.or.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.or.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.or.Image = ((System.Drawing.Image)(resources.GetObject("or.Image")));
            this.or.Location = new System.Drawing.Point(124, 0);
            this.or.Margin = new System.Windows.Forms.Padding(4);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(112, 95);
            this.or.TabIndex = 2;
            this.or.Text = "OR";
            this.or.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.or.UseVisualStyleBackColor = false;
            this.or.Visible = false;
            // 
            // and
            // 
            this.and.BackColor = System.Drawing.Color.MistyRose;
            this.bunifuTransition1.SetDecoration(this.and, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.and, BunifuAnimatorNS.DecorationType.None);
            this.and.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.and.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GrayText;
            this.and.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.and.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.and.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold);
            this.and.Image = ((System.Drawing.Image)(resources.GetObject("and.Image")));
            this.and.Location = new System.Drawing.Point(4, 0);
            this.and.Margin = new System.Windows.Forms.Padding(4);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(112, 95);
            this.and.TabIndex = 1;
            this.and.Text = "AND";
            this.and.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.and.UseVisualStyleBackColor = false;
            this.and.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(497, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Welcome To Querying Module";
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1427, 36);
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
            this.panel6.Location = new System.Drawing.Point(0, 873);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1427, 13);
            this.panel6.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel7, BunifuAnimatorNS.DecorationType.None);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(13, 850);
            this.panel7.TabIndex = 15;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel8, BunifuAnimatorNS.DecorationType.None);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1427, 13);
            this.panel8.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuTransition2.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel9, BunifuAnimatorNS.DecorationType.None);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(231, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 850);
            this.panel9.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1440, 886);
            this.Controls.Add(this.studentpanal);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Boolean);
            this.Controls.Add(this.Aggregate);
            this.Controls.Add(this.Comparison);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button choice_fileB;
        private System.Windows.Forms.TextBox filepathTX;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private new System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Panel panel9;
    }
}

