using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ClassRegistrationQuery clubRegistrationQuery = new ClassRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)

        {
            new FrmUpdateMember().Show();
          
        }

        private long StudentId;

        public int RegistrationID()
        {
            count++;
            return count;
        }

        public void RefreshOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }


        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshOfClubMembers();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassRegistrationQuery classRegistrationQuery = new ClassRegistrationQuery();
            RefreshOfClubMembers();
        }
     




        private void register_btn_Click(object sender, EventArgs e)
        {

            Random rnd = new Random();
            int num = rnd.Next();

            ID = RegistrationID();
            StudentId = Convert.ToInt32(studentid_tb.Text);
            FirstName = firstname_tb.Text;
            MiddleName = middlename_tb.Text;
            LastName = lastname_tb.Text;

            Gender = gender_cb.Text;
            Program = program_cb.Text;

            Age = Convert.ToInt32(age_tb.Text);


            clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program);
            RegistrationID();


            studentid_tb.Text = "";
            age_tb.Text = "";
            gender_cb.Text = "";
            firstname_tb.Text = "";
            middlename_tb.Text = "";
            lastname_tb.Text = "";
            gender_cb.Text = "";
            program_cb.Text = "";
        }

    }
}
