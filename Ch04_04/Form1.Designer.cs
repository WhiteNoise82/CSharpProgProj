namespace Ch04_04
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
            this.lblPath = new System.Windows.Forms.Label();
            this.lblWipe = new System.Windows.Forms.Label();
            this.lblPgb = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnWipe = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cbWipe = new System.Windows.Forms.ComboBox();
            this.pgbBar = new System.Windows.Forms.ProgressBar();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(10, 10);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(37, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "파일 :";
            // 
            // lblWipe
            // 
            this.lblWipe.AutoSize = true;
            this.lblWipe.Location = new System.Drawing.Point(10, 37);
            this.lblWipe.Name = "lblWipe";
            this.lblWipe.Size = new System.Drawing.Size(37, 12);
            this.lblWipe.TabIndex = 1;
            this.lblWipe.Text = "선택 :";
            // 
            // lblPgb
            // 
            this.lblPgb.AutoSize = true;
            this.lblPgb.Location = new System.Drawing.Point(18, 75);
            this.lblPgb.Name = "lblPgb";
            this.lblPgb.Size = new System.Drawing.Size(21, 12);
            this.lblPgb.TabIndex = 2;
            this.lblPgb.Text = "0%";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(398, 5);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(25, 23);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(429, 6);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(54, 47);
            this.btnWipe.TabIndex = 4;
            this.btnWipe.Text = "삭제";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(55, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(337, 21);
            this.txtPath.TabIndex = 5;
            // 
            // cbWipe
            // 
            this.cbWipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWipe.FormattingEnabled = true;
            this.cbWipe.Items.AddRange(new object[] {
            "British HMG IS5 (Base Line)",
            "British HMG IS5 (Enhanced)"});
            this.cbWipe.Location = new System.Drawing.Point(55, 33);
            this.cbWipe.Name = "cbWipe";
            this.cbWipe.Size = new System.Drawing.Size(368, 20);
            this.cbWipe.TabIndex = 6;
            // 
            // pgbBar
            // 
            this.pgbBar.Location = new System.Drawing.Point(55, 70);
            this.pgbBar.Name = "pgbBar";
            this.pgbBar.Size = new System.Drawing.Size(428, 23);
            this.pgbBar.TabIndex = 7;
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "모든 파일 (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 102);
            this.Controls.Add(this.pgbBar);
            this.Controls.Add(this.cbWipe);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnWipe);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPgb);
            this.Controls.Add(this.lblWipe);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 지우기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblWipe;
        private System.Windows.Forms.Label lblPgb;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ComboBox cbWipe;
        private System.Windows.Forms.ProgressBar pgbBar;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}

