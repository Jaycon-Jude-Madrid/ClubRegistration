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
    public partial class FrmUpdateMember : Form

    {
        ClassRegistrationQuery classRegistrationQuery = new ClassRegistrationQuery();

        public FrmUpdateMember()
        {
            InitializeComponent();

            classRegistrationQuery.IdSelect(studentid_cb);

        }


        private void confirm_btn_Click(object sender, EventArgs e)
        {
            classRegistrationQuery.UpdateStudent(Convert.ToInt32(studentid_cb.Text), firstname_tb.Text, middlename_tb.Text, lastname_tb.Text, Convert.ToInt32(age_tb.Text), gender_cb.Text, program_cb.Text);
            Form1 frmClubRegistration = new Form1();
            frmClubRegistration.RefreshOfClubMembers();
            
        }

        private void studentid_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            classRegistrationQuery.AutoSearch(firstname_tb, middlename_tb, lastname_tb, age_tb, gender_cb, program_cb, Convert.ToInt32(studentid_cb.Text));
        }
    }
}
