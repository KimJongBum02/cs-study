namespace Parking
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarNum = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCorp = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량번호:";
            // 
            // txtCarNum
            // 
            this.txtCarNum.Location = new System.Drawing.Point(250, 34);
            this.txtCarNum.Name = "txtCarNum";
            this.txtCarNum.Size = new System.Drawing.Size(275, 61);
            this.txtCarNum.TabIndex = 1;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(590, 40);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(358, 55);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "입차완료";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(590, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(358, 55);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "차량번호초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "초기 30분 : 1000원";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "10분 당 : 500원";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 43);
            this.statusStrip1.TabIndex = 6;
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
            this.tsslDateTime.Size = new System.Drawing.Size(679, 34);
            this.tsslDateTime.Spring = true;
            this.tsslDateTime.Text = "toolStripStatusLabel2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 254);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtCarNum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "입차화면";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarNum;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCorp;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateTime;
    }
}