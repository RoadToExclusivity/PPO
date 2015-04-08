using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab5
{
    public partial class frmMain : Form
    {
        private Image m_ball, m_field;
        private int m_x, m_y, m_dx, m_dy, m_counter;
        private const int BALL_DX = 1, BALL_DY = 1, BALL_START_X = 0, BALL_START_Y = 200, OFFSET_X = 20, OFFSET_Y = 20;

        public frmMain()
        {
            InitializeComponent();
        }

        private bool LoadImage(ref Image image, string fileName)
        {
            try
            {
                image = Image.FromFile(fileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Картинки " + fileName + " не могут быть загружены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);

            if (!LoadImage(ref m_field, "field.jpg") || !LoadImage(ref m_ball, "ball.png"))
            {
                this.Close();
            }

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = m_field;

            m_dx = BALL_DX;
            m_dy = BALL_DY;
            m_x = BALL_START_X;
            m_y = BALL_START_Y;

            m_counter = Environment.TickCount;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (m_x + m_dx < OFFSET_X || m_x + m_ball.Width + m_dx > this.ClientSize.Width)
            {
                m_dx = -m_dx;
            }
            if (m_y + m_dy < OFFSET_Y || m_y + m_ball.Height + m_dy > this.ClientSize.Height)
            {
                m_dy = -m_dy;
            }
            ImageAttributes attr = new ImageAttributes();
            //attr.SetColorKey(Color.White, Color.White);

            Rectangle dstRect = new Rectangle(m_x, m_y, m_ball.Width, m_ball.Height);
            pe.Graphics.DrawImage(m_ball, dstRect, 0, 0, m_ball.Width, m_ball.Height, GraphicsUnit.Pixel, attr);
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            m_x += m_dx * (Environment.TickCount - m_counter);
            m_y += m_dy * (Environment.TickCount - m_counter);
            m_counter = Environment.TickCount;

            this.Refresh();
        }
    }
}
