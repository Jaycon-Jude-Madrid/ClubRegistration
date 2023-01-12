namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            this.label8 = new System.Windows.Forms.Label();
            this.lastname_tb = new System.Windows.Forms.TextBox();
            this.firstname_tb = new System.Windows.Forms.TextBox();
            this.middlename_tb = new System.Windows.Forms.TextBox();
            this.age_tb = new System.Windows.Forms.TextBox();
            this.studentid_cb = new System.Windows.Forms.ComboBox();
            this.gender_cb = new System.Windows.Forms.ComboBox();
            this.program_cb = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Middle Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Program:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 6;
            // 
            // lastname_tb
            // 
            this.lastname_tb.Location = new System.Drawing.Point(140, 113);
            this.lastname_tb.Name = "lastname_tb";
            this.lastname_tb.Size = new System.Drawing.Size(121, 20);
            this.lastname_tb.TabIndex = 7;
            // 
            // firstname_tb
            // 
            this.firstname_tb.Location = new System.Drawing.Point(140, 161);
            this.firstname_tb.Name = "firstname_tb";
            this.firstname_tb.Size = new System.Drawing.Size(121, 20);
            this.firstname_tb.TabIndex = 8;
            // 
            // middlename_tb
            // 
            this.middlename_tb.Location = new System.Drawing.Point(140, 216);
            this.middlename_tb.Name = "middlename_tb";
            this.middlename_tb.Size = new System.Drawing.Size(121, 20);
            this.middlename_tb.TabIndex = 9;
            // 
            // age_tb
            // 
            this.age_tb.Location = new System.Drawing.Point(140, 269);
            this.age_tb.Name = "age_tb";
            this.age_tb.Size = new System.Drawing.Size(121, 20);
            this.age_tb.TabIndex = 10;
            // 
            // studentid_cb
            // 
            this.studentid_cb.FormattingEnabled = true;
            this.studentid_cb.Location = new System.Drawing.Point(140, 66);
            this.studentid_cb.Name = "studentid_cb";
            this.studentid_cb.Size = new System.Drawing.Size(121, 21);
            this.studentid_cb.TabIndex = 11;
            this.studentid_cb.SelectedIndexChanged += new System.EventHandler(this.studentid_cb_SelectedIndexChanged);
            // 
            // gender_cb
            // 
            this.gender_cb.FormattingEnabled = true;
            this.gender_cb.Location = new System.Drawing.Point(140, 321);
            this.gender_cb.Name = "gender_cb";
            this.gender_cb.Size = new System.Drawing.Size(121, 21);
            this.gender_cb.TabIndex = 12;
            // 
            // program_cb
            // 
            this.program_cb.FormattingEnabled = true;
            this.program_cb.Location = new System.Drawing.Point(140, 361);
            this.program_cb.Name = "program_cb";
            this.program_cb.Size = new System.Drawing.Size(121, 21);
            this.program_cb.TabIndex = 13;
            // 
            // confirm_btn
            // 
            this.confirm_btn.Location = new System.Drawing.Point(140, 413);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(121, 23);
            this.confirm_btn.TabIndex = 14;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 660);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.program_cb);
            this.Controls.Add(this.gender_cb);
            this.Controls.Add(this.studentid_cb);
            this.Controls.Add(this.age_tb);
            this.Controls.Add(this.middlename_tb);
            this.Controls.Add(this.firstname_tb);
            this.Controls.Add(this.lastname_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateMember";
            this.Text = "Form2";
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lastname_tb;
        private System.Windows.Forms.TextBox firstname_tb;
        private System.Windows.Forms.TextBox middlename_tb;
        private System.Windows.Forms.TextBox age_tb;
        private System.Windows.Forms.ComboBox studentid_cb;
        private System.Windows.Forms.ComboBox gender_cb;
        private System.Windows.Forms.ComboBox program_cb;
        private System.Windows.Forms.Button confirm_btn;
    }
}