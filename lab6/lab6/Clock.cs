using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Clock: UserControl
    {
        public enum ClockStyle
        {
            BorderedClock = 1,
            BorderlessClock,
            SimpleClock
        };

        private Pen m_secondsHand = new Pen(Color.Black, 1.5f);
        private Pen m_minutesHand = new Pen(Color.Red, 2.5f);
        private Pen m_hoursHand = new Pen(Color.Blue, 3f);

        private DateTime m_time = DateTime.Now;
        private bool m_isRepresentNow = true;
        private ClockStyle m_style = ClockStyle.BorderedClock;

        private PointF m_center;
        private double m_secLen, m_minLen, m_hourLen;

        private void PaintHand(PaintEventArgs e, Pen p, PointF start, double handLen, double angle)
        {
            e.Graphics.DrawLine(p, start, new PointF((float)(start.X + handLen * Math.Sin(angle)),
                                (float)(start.Y - handLen * Math.Cos(angle))));
        }

        private double AngleToRadians(double angle)
        {
            return angle * Math.PI / 180;
        }

        private void PaintClock()
        {
            Bitmap bmp = null;

            switch (m_style)
            {
                case ClockStyle.BorderedClock:
                    bmp = lab6.Properties.Resources.clockWithNums2;
                    break;
                case ClockStyle.BorderlessClock:
                    bmp = lab6.Properties.Resources.clockWithNums3;
                    break;
                case ClockStyle.SimpleClock:
                    bmp = lab6.Properties.Resources.clockWithNums;
                    break;
            }

            pic.BackgroundImage = bmp;
        }

        public Clock()
        {
            InitializeComponent();
        }

        public Clock(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            
            m_time = m_time.AddSeconds(1);

            pic.Invalidate();
        }

        private void Clock_Resize(object sender, EventArgs e)
        {
            if (this.Width != this.Height)
            {
                this.Width = Math.Max(this.Width, this.Height);
                this.Height = Math.Max(this.Width, this.Height);
            }

            pic.Width = this.Width;
            pic.Height = this.Height;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            if (this.DesignMode)
            {
                tmr.Enabled = false;
                return;
            }

            int seconds = m_time.Second, minutes = m_time.Minute, hours = m_time.Hour;

            double secAngle = AngleToRadians(seconds * 6), minutesAngle = AngleToRadians(minutes * 6 + seconds / 10.0),
                   hoursAngle = AngleToRadians(hours * 30 + minutes / 2.0 + seconds / 30.0);

            PaintHand(e, m_secondsHand, m_center, m_secLen, secAngle);
            PaintHand(e, m_minutesHand, m_center, m_minLen, minutesAngle);
            PaintHand(e, m_hoursHand, m_center, m_hourLen, hoursAngle);
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            pic.Width = this.Width;
            pic.Height = this.Height;

            PaintClock();

            m_center.X = pic.Width / 2;
            m_center.Y = pic.Height / 2;

            m_secLen = m_center.X * 4 / 5;
            m_minLen = m_center.X * 3 / 5;
            m_hourLen = m_center.X * 2 / 5;

            if (m_isRepresentNow)
            {
                m_time = DateTime.Now;
            }

            tmr.Enabled = true;
        }

        public DateTime CurrentTime
        {
            get 
            {
                return m_time;
            }
            set
            {
                m_time = value;
            }
        }

        public bool StartFromNow
        {
            get
            {
                return m_isRepresentNow;
            }
            set
            {
                m_isRepresentNow = value;
            }
        }

        public Color SecondsHandColor
        {
            get
            {
                return m_secondsHand.Color;
            }
            set
            {
                m_secondsHand.Color = value;
            }
        }

        public Color MinutesHandColor
        {
            get
            {
                return m_minutesHand.Color;
            }
            set
            {
                m_minutesHand.Color = value;
            }
        }

        public Color HoursHandColor
        {
            get
            {
                return m_hoursHand.Color;
            }
            set
            {
                m_hoursHand.Color = value;
            }
        }

        public void Stop()
        {
            tmr.Enabled = false;
        }

        public void Resume()
        {
            tmr.Enabled = true;
        }

        public ClockStyle Style
        {
            get
            {
                return m_style;
            }
            set
            {
                m_style = value;
                PaintClock();
            }
        }
    }
}
