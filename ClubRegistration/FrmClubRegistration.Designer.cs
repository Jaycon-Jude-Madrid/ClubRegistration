namespace ClubRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.studentid_tb = new System.Windows.Forms.TextBox();
            this.lastname_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.middlename_tb = new System.Windows.Forms.TextBox();
            this.firstname_tb = new System.Windows.Forms.TextBox();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.program_cb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.register_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Program:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gender:";
            // 
            // studentid_tb
            // 
            this.studentid_tb.Location = new System.Drawing.Point(12, 54);
            this.studentid_tb.Name = "studentid_tb";
            this.studentid_tb.Size = new System.Drawing.Size(148, 20);
            this.studentid_tb.TabIndex = 7;
            // 
            // lastname_tb
            // 
            this.lastname_tb.Location = new System.Drawing.Point(12, 120);
            this.lastname_tb.Name = "lastname_tb";
            this.lastname_tb.Size = new System.Drawing.Size(148, 20);
            this.lastname_tb.TabIndex = 8;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(12, 166);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(148, 20);
            this.age_tb.TabIndex = 9;
            // 
            // middlename_tb
            // 
            this.middlename_tb.Location = new System.Drawing.Point(340, 120);
            this.middlename_tb.Name = "middlename_tb";
            this.middlename_tb.Size = new System.Drawing.Size(168, 20);
            this.middlename_tb.TabIndex = 10;
            // 
            // firstname_tb
            // 
            this.firstname_tb.Location = new System.Drawing.Point(166, 120);
            this.firstname_tb.Name = "firstname_tb";
            this.firstname_tb.Size = new System.Drawing.Size(168, 20);
            this.firstname_tb.TabIndex = 11;
            // 
            // gender_cb
            // 
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender_cb.Location = new System.Drawing.Point(166, 166);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(168, 21);
            this.gender_cb.TabIndex = 12;
            // 
            // program_cb
            // 
            this.program_cb.FormattingEnabled = true;
            this.program_cb.Items.AddRange(new object[] {
            "BSIT",
            "BSHM",
            "BSBA"});
            this.program_cb.Location = new System.Drawing.Point(340, 53);
            this.program_cb.Name = "program_cb";
            this.program_cb.Size = new System.Drawing.Size(168, 21);
            this.program_cb.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(496, 275);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(542, 51);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(93, 23);
            this.register_btn.TabIndex = 16;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(542, 117);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(93, 23);
            this.update_btn.TabIndex = 17;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(539, 30);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(93, 23);
            this.refresh_btn.TabIndex = 18;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refresh_btn);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 373);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of display Members:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 602);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.program_cb);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.firstname_tb);
            this.Controls.Add(this.middlename_tb);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.lastname_tb);
            this.Controls.Add(this.studentid_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentid_tb;
        private System.Windows.Forms.TextBox lastname_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.TextBox middlename_tb;
        private System.Windows.Forms.TextBox firstname_tb;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.ComboBox program_cb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

