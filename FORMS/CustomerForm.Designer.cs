namespace BMS.FORMS
{
    partial class CustomerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomerPanelTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnLoanApply = new System.Windows.Forms.Button();
            this.btnWIthdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.CustomerPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.CustomerPanelTop);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 609);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CustomerPanelTop
            // 
            this.CustomerPanelTop.BackColor = System.Drawing.Color.DarkRed;
            this.CustomerPanelTop.Controls.Add(this.btnLogout);
            this.CustomerPanelTop.Controls.Add(this.btnCenter);
            this.CustomerPanelTop.Controls.Add(this.btnLoanApply);
            this.CustomerPanelTop.Controls.Add(this.btnWIthdraw);
            this.CustomerPanelTop.Controls.Add(this.btnDeposit);
            this.CustomerPanelTop.Controls.Add(this.button2);
            this.CustomerPanelTop.Controls.Add(this.btnInfo);
            this.CustomerPanelTop.Location = new System.Drawing.Point(1, 47);
            this.CustomerPanelTop.Name = "CustomerPanelTop";
            this.CustomerPanelTop.Size = new System.Drawing.Size(981, 54);
            this.CustomerPanelTop.TabIndex = 1;
            this.CustomerPanelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomerPanelTop_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(840, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 54);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.BackColor = System.Drawing.Color.DarkRed;
            this.btnCenter.ForeColor = System.Drawing.Color.White;
            this.btnCenter.Location = new System.Drawing.Point(643, 0);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(104, 54);
            this.btnCenter.TabIndex = 6;
            this.btnCenter.Text = "Loan Center";
            this.btnCenter.UseVisualStyleBackColor = false;
            this.btnCenter.Visible = false;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnLoanApply
            // 
            this.btnLoanApply.BackColor = System.Drawing.Color.DarkRed;
            this.btnLoanApply.ForeColor = System.Drawing.Color.White;
            this.btnLoanApply.Location = new System.Drawing.Point(518, 0);
            this.btnLoanApply.Name = "btnLoanApply";
            this.btnLoanApply.Size = new System.Drawing.Size(104, 54);
            this.btnLoanApply.TabIndex = 5;
            this.btnLoanApply.Text = "Apply For Loan";
            this.btnLoanApply.UseVisualStyleBackColor = false;
            this.btnLoanApply.Click += new System.EventHandler(this.btnLoanApply_Click);
            // 
            // btnWIthdraw
            // 
            this.btnWIthdraw.BackColor = System.Drawing.Color.DarkRed;
            this.btnWIthdraw.ForeColor = System.Drawing.Color.White;
            this.btnWIthdraw.Location = new System.Drawing.Point(393, 0);
            this.btnWIthdraw.Name = "btnWIthdraw";
            this.btnWIthdraw.Size = new System.Drawing.Size(104, 54);
            this.btnWIthdraw.TabIndex = 4;
            this.btnWIthdraw.Text = "Withdraw Cash";
            this.btnWIthdraw.UseVisualStyleBackColor = false;
            this.btnWIthdraw.Click += new System.EventHandler(this.btnWIthdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(266, 0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(104, 54);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit Cash";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(137, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Balance";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.DarkRed;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(28, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(87, 54);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Account Info";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMS.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(985, 445);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 609);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.panel1.ResumeLayout(false);
            this.CustomerPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel CustomerPanelTop;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnLoanApply;
        private System.Windows.Forms.Button btnWIthdraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLogout;
    }
}