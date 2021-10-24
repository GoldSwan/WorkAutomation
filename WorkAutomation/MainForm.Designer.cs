
namespace WorkAutomation
{
    partial class MainForm
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
            this.GbxInput = new System.Windows.Forms.GroupBox();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.LblCode = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtServerUrl = new System.Windows.Forms.TextBox();
            this.LblServerUrl = new System.Windows.Forms.Label();
            this.GbxExecute = new System.Windows.Forms.GroupBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.GbxLog = new System.Windows.Forms.GroupBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.GbxInput.SuspendLayout();
            this.GbxExecute.SuspendLayout();
            this.GbxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxInput
            // 
            this.GbxInput.Controls.Add(this.TxtCode);
            this.GbxInput.Controls.Add(this.LblCode);
            this.GbxInput.Controls.Add(this.TxtPassword);
            this.GbxInput.Controls.Add(this.LblPassword);
            this.GbxInput.Controls.Add(this.TxtId);
            this.GbxInput.Controls.Add(this.LblId);
            this.GbxInput.Controls.Add(this.TxtServerUrl);
            this.GbxInput.Controls.Add(this.LblServerUrl);
            this.GbxInput.Location = new System.Drawing.Point(10, 10);
            this.GbxInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxInput.Name = "GbxInput";
            this.GbxInput.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxInput.Size = new System.Drawing.Size(679, 127);
            this.GbxInput.TabIndex = 0;
            this.GbxInput.TabStop = false;
            this.GbxInput.Text = "입력";
            // 
            // TxtCode
            // 
            this.TxtCode.Location = new System.Drawing.Point(426, 24);
            this.TxtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(190, 21);
            this.TxtCode.TabIndex = 9;
            // 
            // LblCode
            // 
            this.LblCode.Location = new System.Drawing.Point(324, 25);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(96, 20);
            this.LblCode.TabIndex = 8;
            this.LblCode.Text = "Code";
            this.LblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(426, 61);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(190, 21);
            this.TxtPassword.TabIndex = 5;
            // 
            // LblPassword
            // 
            this.LblPassword.Location = new System.Drawing.Point(324, 65);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(96, 20);
            this.LblPassword.TabIndex = 4;
            this.LblPassword.Text = "비밀번호";
            this.LblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(116, 64);
            this.TxtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(190, 21);
            this.TxtId.TabIndex = 3;
            // 
            // LblId
            // 
            this.LblId.Location = new System.Drawing.Point(5, 62);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(96, 20);
            this.LblId.TabIndex = 2;
            this.LblId.Text = "아이디";
            this.LblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtServerUrl
            // 
            this.TxtServerUrl.Location = new System.Drawing.Point(116, 26);
            this.TxtServerUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtServerUrl.Name = "TxtServerUrl";
            this.TxtServerUrl.Size = new System.Drawing.Size(190, 21);
            this.TxtServerUrl.TabIndex = 1;
            // 
            // LblServerUrl
            // 
            this.LblServerUrl.Location = new System.Drawing.Point(5, 26);
            this.LblServerUrl.Name = "LblServerUrl";
            this.LblServerUrl.Size = new System.Drawing.Size(96, 20);
            this.LblServerUrl.TabIndex = 0;
            this.LblServerUrl.Text = "서버";
            this.LblServerUrl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GbxExecute
            // 
            this.GbxExecute.Controls.Add(this.BtnLogin);
            this.GbxExecute.Location = new System.Drawing.Point(10, 141);
            this.GbxExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxExecute.Name = "GbxExecute";
            this.GbxExecute.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxExecute.Size = new System.Drawing.Size(679, 57);
            this.GbxExecute.TabIndex = 1;
            this.GbxExecute.TabStop = false;
            this.GbxExecute.Text = "실행";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(7, 18);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(106, 22);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "로그인";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // GbxLog
            // 
            this.GbxLog.Controls.Add(this.TxtLog);
            this.GbxLog.Location = new System.Drawing.Point(10, 202);
            this.GbxLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxLog.Name = "GbxLog";
            this.GbxLog.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbxLog.Size = new System.Drawing.Size(679, 137);
            this.GbxLog.TabIndex = 2;
            this.GbxLog.TabStop = false;
            this.GbxLog.Text = "로그";
            // 
            // TxtLog
            // 
            this.TxtLog.Location = new System.Drawing.Point(0, 19);
            this.TxtLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.Size = new System.Drawing.Size(674, 114);
            this.TxtLog.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.GbxLog);
            this.Controls.Add(this.GbxExecute);
            this.Controls.Add(this.GbxInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "업무 자동화 프로그램";
            this.GbxInput.ResumeLayout(false);
            this.GbxInput.PerformLayout();
            this.GbxExecute.ResumeLayout(false);
            this.GbxLog.ResumeLayout(false);
            this.GbxLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxInput;
        private System.Windows.Forms.GroupBox GbxExecute;
        private System.Windows.Forms.GroupBox GbxLog;
        private System.Windows.Forms.Label LblServerUrl;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblPassword;
        public System.Windows.Forms.TextBox TxtServerUrl;
        public System.Windows.Forms.TextBox TxtId;
        public System.Windows.Forms.TextBox TxtPassword;
        public System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblCode;
        public System.Windows.Forms.TextBox TxtCode;
    }
}

