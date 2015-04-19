namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clock1 = new lab6.Clock(this.components);
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.CurrentTime = new System.DateTime(2015, 4, 19, 18, 20, 15, 927);
            this.clock1.HoursHandColor = System.Drawing.Color.Blue;
            this.clock1.Location = new System.Drawing.Point(0, 0);
            this.clock1.MinutesHandColor = System.Drawing.Color.Red;
            this.clock1.Name = "clock1";
            this.clock1.SecondsHandColor = System.Drawing.Color.Black;
            this.clock1.Size = new System.Drawing.Size(367, 367);
            this.clock1.StartFromNow = true;
            this.clock1.Style = lab6.Clock.ClockStyle.BorderlessClock;
            this.clock1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 503);
            this.Controls.Add(this.clock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private lab6.Clock clock1;









    }
}

