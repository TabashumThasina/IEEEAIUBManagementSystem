namespace demoproject
{
    partial class Cal
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(237, 97);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroButton1.Location = new System.Drawing.Point(37, 358);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(187, 40);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Back ->";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(712, 358);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(61, 15);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroRadioButton1.TabIndex = 2;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "Logout";
            this.metroRadioButton1.UseStyleColors = true;
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 412);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Modern No. 20", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Cal";
            this.Padding = new System.Windows.Forms.Padding(20, 54, 20, 18);
            this.Text = "Calender";
            this.Load += new System.EventHandler(this.Cal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
    }
}