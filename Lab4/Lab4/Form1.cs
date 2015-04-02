using System;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbSize.SelectedIndex = 0;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = txtName.Text, appartments = cbSize.Text;
            if (name.Length == 0)
            {
                MessageBox.Show("Не заполнено имя пользователя !", "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmBook frm = new frmBook();
            frm.SetName(name);
            frm.SetAppartments(appartments);
            frm.SetConditionerNeed(chkConditioner.Checked);
            frm.SetTVNeed(chkTV.Checked);
            frm.SetWebNeed(chkWeb.Checked);

            this.Visible = false;
            frm.ShowDialog();
            this.Close();
        }
    }
}
