namespace Parking
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCorp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(227, 26);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(209, 61);
            this.txtCarNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "차량번호:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(645, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(270, 63);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "차량번호 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 47);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 47);
            this.label4.TabIndex = 7;
            this.label4.Text = "결제하실금액 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 47);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCorp,
            this.tsslDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(927, 43);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCorp
            // 
            this.tsslCorp.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslCorp.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsslCorp.Name = "tsslCorp";
            this.tsslCorp.Size = new System.Drawing.Size(212, 34);
            this.tsslCorp.Text = "Yuhan Parking Corp.";
            // 
            // tsslDateTime
            // 
            this.tsslDateTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsslDateTime.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.tsslDateTime.Name = "tsslDateTime";
            this.tsslDateTime.Size = new System.Drawing.Size(646, 34);
            this.tsslDateTime.Spring = true;
            this.tsslDateTime.Text = "toolStripStatusLabel2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 47);
            this.label6.TabIndex = 11;
            this.label6.Text = "10분 당 : 500원";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 47);
            this.label7.TabIndex = 10;
            this.label7.Text = "초기 30분 : 1000원";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(645, 243);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(270, 61);
            this.btnPay.TabIndex = 12;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 47);
            this.label8.TabIndex = 13;
            this.label8.Text = "주차시간 : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 47);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 418);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCarNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "출차화면";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCorp;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}