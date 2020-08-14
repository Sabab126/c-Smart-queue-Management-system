namespace SQMS
{
    partial class Create_Event
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dtEndDay = new MetroFramework.Controls.MetroDateTime();
            this.dtStartDay = new MetroFramework.Controls.MetroDateTime();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtTimeReq = new MetroFramework.Controls.MetroTextBox();
            this.txtDetails = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.dtEndDay);
            this.metroPanel1.Controls.Add(this.dtStartDay);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.txtTimeReq);
            this.metroPanel1.Controls.Add(this.txtDetails);
            this.metroPanel1.Controls.Add(this.txtName);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 364);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtEndDay
            // 
            this.dtEndDay.Location = new System.Drawing.Point(313, 201);
            this.dtEndDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEndDay.Name = "dtEndDay";
            this.dtEndDay.Size = new System.Drawing.Size(206, 29);
            this.dtEndDay.TabIndex = 16;
            // 
            // dtStartDay
            // 
            this.dtStartDay.Location = new System.Drawing.Point(313, 158);
            this.dtStartDay.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStartDay.Name = "dtStartDay";
            this.dtStartDay.Size = new System.Drawing.Size(206, 29);
            this.dtStartDay.TabIndex = 15;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(444, 252);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 14;
            this.metroButton3.Text = "Back";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.MetroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(313, 252);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 13;
            this.metroButton2.Text = "Create";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(636, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 23);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Logout";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // txtTimeReq
            // 
            // 
            // 
            // 
            this.txtTimeReq.CustomButton.Image = null;
            this.txtTimeReq.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtTimeReq.CustomButton.Name = "";
            this.txtTimeReq.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTimeReq.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeReq.CustomButton.TabIndex = 1;
            this.txtTimeReq.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeReq.CustomButton.UseSelectable = true;
            this.txtTimeReq.CustomButton.Visible = false;
            this.txtTimeReq.Lines = new string[0];
            this.txtTimeReq.Location = new System.Drawing.Point(313, 113);
            this.txtTimeReq.MaxLength = 32767;
            this.txtTimeReq.Name = "txtTimeReq";
            this.txtTimeReq.PasswordChar = '\0';
            this.txtTimeReq.PromptText = "Fixed Duration (Optional)";
            this.txtTimeReq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeReq.SelectedText = "";
            this.txtTimeReq.SelectionLength = 0;
            this.txtTimeReq.SelectionStart = 0;
            this.txtTimeReq.ShortcutsEnabled = true;
            this.txtTimeReq.Size = new System.Drawing.Size(206, 23);
            this.txtTimeReq.TabIndex = 9;
            this.txtTimeReq.UseSelectable = true;
            this.txtTimeReq.WaterMark = "Fixed Duration (Optional)";
            this.txtTimeReq.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeReq.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDetails
            // 
            // 
            // 
            // 
            this.txtDetails.CustomButton.Image = null;
            this.txtDetails.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtDetails.CustomButton.Name = "";
            this.txtDetails.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetails.CustomButton.TabIndex = 1;
            this.txtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetails.CustomButton.UseSelectable = true;
            this.txtDetails.CustomButton.Visible = false;
            this.txtDetails.Lines = new string[0];
            this.txtDetails.Location = new System.Drawing.Point(313, 67);
            this.txtDetails.MaxLength = 32767;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.PromptText = "Event Details (Optional)";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetails.SelectedText = "";
            this.txtDetails.SelectionLength = 0;
            this.txtDetails.SelectionStart = 0;
            this.txtDetails.ShortcutsEnabled = true;
            this.txtDetails.Size = new System.Drawing.Size(206, 23);
            this.txtDetails.TabIndex = 8;
            this.txtDetails.UseSelectable = true;
            this.txtDetails.WaterMark = "Event Details (Optional)";
            this.txtDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(313, 28);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Event Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(206, 23);
            this.txtName.TabIndex = 7;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Event Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(159, 201);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "End Day:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(159, 160);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Start Day:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(161, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(98, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Time Required:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(161, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Event Details:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(161, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Event Name:";
            // 
            // Create_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Create_Event";
            this.Text = "Create_Event";
            this.Load += new System.EventHandler(this.Create_Event_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroDateTime dtEndDay;
        private MetroFramework.Controls.MetroDateTime dtStartDay;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtTimeReq;
        private MetroFramework.Controls.MetroTextBox txtDetails;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}