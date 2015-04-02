namespace Lab4
{
    partial class frmBook
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
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mcCalendar
            // 
            this.mcCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mcCalendar.Location = new System.Drawing.Point(3, 5);
            this.mcCalendar.MaxSelectionCount = 1;
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.ShowWeekNumbers = true;
            this.mcCalendar.TabIndex = 0;
            // 
            // btnReady
            // 
            this.btnReady.AutoSize = true;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReady.Location = new System.Drawing.Point(201, 71);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(75, 26);
            this.btnReady.TabIndex = 1;
            this.btnReady.Text = "Готово";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 176);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.mcCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBook";
            this.Text = "Дата бронирования";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.Button btnReady;
    }
}