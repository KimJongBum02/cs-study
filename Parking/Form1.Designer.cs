namespace Parking
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarIn = new System.Windows.Forms.Button();
            this.btnCarOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarIn
            // 
            this.btnCarIn.Location = new System.Drawing.Point(36, 72);
            this.btnCarIn.Name = "btnCarIn";
            this.btnCarIn.Size = new System.Drawing.Size(154, 74);
            this.btnCarIn.TabIndex = 0;
            this.btnCarIn.Text = "입차";
            this.btnCarIn.UseVisualStyleBackColor = true;
            this.btnCarIn.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // btnCarOut
            // 
            this.btnCarOut.Location = new System.Drawing.Point(232, 72);
            this.btnCarOut.Name = "btnCarOut";
            this.btnCarOut.Size = new System.Drawing.Size(154, 74);
            this.btnCarOut.TabIndex = 1;
            this.btnCarOut.Text = "출차";
            this.btnCarOut.UseVisualStyleBackColor = true;
            this.btnCarOut.Click += new System.EventHandler(this.btnCarOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 233);
            this.Controls.Add(this.btnCarOut);
            this.Controls.Add(this.btnCarIn);
            this.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yuhan Parking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarIn;
        private System.Windows.Forms.Button btnCarOut;
    }
}

