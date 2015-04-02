using System;
using System.Text;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmBook : Form
    {
        private string m_name;
        private string m_appartments;

        private bool m_isConditioner;
        private bool m_isTV;
        private bool m_isWeb;

        public void SetName(string name)
        {
            m_name = name;
        }

        public void SetAppartments(string appartment)
        {
            m_appartments = appartment;
        }

        public void SetConditionerNeed(bool isConditionerNeed)
        {
            m_isConditioner = isConditionerNeed;
        }

        public void SetTVNeed(bool isTVNeed)
        {
            m_isTV = isTVNeed;
        }

        public void SetWebNeed(bool isWebNeed)
        {
            m_isWeb = isWebNeed;
        }

        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder(null, 200);

            str.Append("Имя: ");
            str.AppendLine(m_name);

            str.Append("Выбранные аппартаменты: ");
            str.AppendLine(m_appartments);

            if (!(m_isConditioner || m_isTV || m_isWeb))
            {
                str.AppendLine("Не выбрано дополнительных услуг");
            }
            else
            {
               if (m_isConditioner)
               {
                   str.AppendLine("Дополнительно выбран кондиционер");
               }

               if (m_isTV)
               {
                   str.AppendLine("Дополнительно выбран телевизор");
               }

               if (m_isWeb)
               {
                   str.AppendLine("Дополнительно выбран интернет");
               }
            }

            str.Append("Дата начала бронирования: ");
            str.AppendLine(mcCalendar.SelectionRange.Start.ToString());

            MessageBox.Show(str.ToString(), "Отчет", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
