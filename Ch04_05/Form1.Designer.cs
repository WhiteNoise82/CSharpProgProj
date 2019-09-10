namespace Ch04_05
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
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbbMonitor = new System.Windows.Forms.ComboBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.fbdFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 9);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(29, 12);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = "경로";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(12, 36);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(29, 12);
            this.lblExtension.TabIndex = 1;
            this.lblExtension.Text = "타입";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(177, 36);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(57, 12);
            this.lblMonitor.TabIndex = 2;
            this.lblMonitor.Text = "하위 감시";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(56, 6);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(369, 21);
            this.txtPath.TabIndex = 3;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(56, 33);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(100, 21);
            this.txtExtension.TabIndex = 4;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(431, 4);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(36, 23);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(487, 4);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 49);
            this.btnMonitor.TabIndex = 6;
            this.btnMonitor.Text = "모니터 ON";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.BtnMonitor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(568, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "로그 저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbbMonitor
            // 
            this.cbbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMonitor.FormattingEnabled = true;
            this.cbbMonitor.Items.AddRange(new object[] {
            "ON",
            "OFF"});
            this.cbbMonitor.Location = new System.Drawing.Point(240, 33);
            this.cbbMonitor.Name = "cbbMonitor";
            this.cbbMonitor.Size = new System.Drawing.Size(121, 20);
            this.cbbMonitor.TabIndex = 8;
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 12;
            this.lbLog.Location = new System.Drawing.Point(14, 60);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(629, 304);
            this.lbLog.TabIndex = 9;
            // 
            // sfdFile
            // 
            this.sfdFile.Filter = "로그 파일(*.log)|*.log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 374);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.cbbMonitor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.txtExtension);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "파일 모니터";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbbMonitor;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.FolderBrowserDialog fbdFolder;
        private System.Windows.Forms.SaveFileDialog sfdFile;
    }
}

