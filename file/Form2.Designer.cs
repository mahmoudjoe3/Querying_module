namespace file
{
    partial class add_student_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_student_form));
            this.add_b = new System.Windows.Forms.Button();
            this.projects_clb = new System.Windows.Forms.CheckedListBox();
            this.department_cb = new System.Windows.Forms.ComboBox();
            this.female_rb = new System.Windows.Forms.RadioButton();
            this.male_rb = new System.Windows.Forms.RadioButton();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // add_b
            // 
            this.add_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_b.FlatAppearance.BorderSize = 0;
            this.add_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.add_b.Location = new System.Drawing.Point(464, 303);
            this.add_b.Name = "add_b";
            this.add_b.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_b.Size = new System.Drawing.Size(109, 32);
            this.add_b.TabIndex = 24;
            this.add_b.Text = "ADD";
            this.add_b.UseVisualStyleBackColor = true;
            this.add_b.Click += new System.EventHandler(this.add_b_Click_1);
            // 
            // projects_clb
            // 
            this.projects_clb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.projects_clb.CheckOnClick = true;
            this.projects_clb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projects_clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.projects_clb.FormattingEnabled = true;
            this.projects_clb.Items.AddRange(new object[] {
            "mario",
            "XO",
            "connect 4",
            "chess",
            "task manager"});
            this.projects_clb.Location = new System.Drawing.Point(201, 201);
            this.projects_clb.Name = "projects_clb";
            this.projects_clb.Size = new System.Drawing.Size(190, 115);
            this.projects_clb.TabIndex = 23;
            // 
            // department_cb
            // 
            this.department_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.department_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.department_cb.FormattingEnabled = true;
            this.department_cb.Items.AddRange(new object[] {
            "General",
            "Bioinformatic",
            "Software",
            "AI",
            "IT"});
            this.department_cb.Location = new System.Drawing.Point(201, 146);
            this.department_cb.Name = "department_cb";
            this.department_cb.Size = new System.Drawing.Size(121, 30);
            this.department_cb.TabIndex = 22;
            // 
            // female_rb
            // 
            this.female_rb.AutoSize = true;
            this.female_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.female_rb.Location = new System.Drawing.Point(358, 79);
            this.female_rb.Name = "female_rb";
            this.female_rb.Size = new System.Drawing.Size(95, 28);
            this.female_rb.TabIndex = 21;
            this.female_rb.TabStop = true;
            this.female_rb.Text = "Female";
            this.female_rb.UseVisualStyleBackColor = true;
            // 
            // male_rb
            // 
            this.male_rb.AutoSize = true;
            this.male_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.male_rb.Location = new System.Drawing.Point(185, 79);
            this.male_rb.Name = "male_rb";
            this.male_rb.Size = new System.Drawing.Size(72, 28);
            this.male_rb.TabIndex = 20;
            this.male_rb.TabStop = true;
            this.male_rb.Text = "Male";
            this.male_rb.UseVisualStyleBackColor = true;
            // 
            // name_tb
            // 
            this.name_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.name_tb.Location = new System.Drawing.Point(414, 28);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(159, 28);
            this.name_tb.TabIndex = 19;
            // 
            // id_tb
            // 
            this.id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.id_tb.Location = new System.Drawing.Point(121, 28);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(162, 28);
            this.id_tb.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(63, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Projects :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(63, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(63, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gender :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(313, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(63, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID :";
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.close.Location = new System.Drawing.Point(464, 341);
            this.close.Name = "close";
            this.close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.close.Size = new System.Drawing.Size(109, 32);
            this.close.TabIndex = 26;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 13);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 13);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 373);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(624, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 373);
            this.panel4.TabIndex = 30;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // add_student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 399);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add_b);
            this.Controls.Add(this.projects_clb);
            this.Controls.Add(this.department_cb);
            this.Controls.Add(this.female_rb);
            this.Controls.Add(this.male_rb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_student_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_b;
        private System.Windows.Forms.CheckedListBox projects_clb;
        private System.Windows.Forms.ComboBox department_cb;
        private System.Windows.Forms.RadioButton female_rb;
        private System.Windows.Forms.RadioButton male_rb;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}