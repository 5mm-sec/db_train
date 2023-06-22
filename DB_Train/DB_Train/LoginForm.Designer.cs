namespace DB_Train
{
    partial class LoginForm
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
            this.Id_Text = new System.Windows.Forms.TextBox();
            this.Pw_text = new System.Windows.Forms.TextBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Find_Id_btn = new System.Windows.Forms.Button();
            this.Find_Pw_btn = new System.Windows.Forms.Button();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Id_Text
            // 
            this.Id_Text.Location = new System.Drawing.Point(76, 170);
            this.Id_Text.Name = "Id_Text";
            this.Id_Text.Size = new System.Drawing.Size(216, 21);
            this.Id_Text.TabIndex = 0;
            // 
            // Pw_text
            // 
            this.Pw_text.Location = new System.Drawing.Point(77, 197);
            this.Pw_text.Name = "Pw_text";
            this.Pw_text.Size = new System.Drawing.Size(216, 21);
            this.Pw_text.TabIndex = 1;
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Login_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_btn.Location = new System.Drawing.Point(301, 170);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 106);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "로그인";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_click);
            // 
            // Find_Id_btn
            // 
            this.Find_Id_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Find_Id_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Find_Id_btn.Location = new System.Drawing.Point(76, 224);
            this.Find_Id_btn.Name = "Find_Id_btn";
            this.Find_Id_btn.Size = new System.Drawing.Size(105, 23);
            this.Find_Id_btn.TabIndex = 3;
            this.Find_Id_btn.Text = "아이디찾기";
            this.Find_Id_btn.UseVisualStyleBackColor = false;
            this.Find_Id_btn.Click += new System.EventHandler(this.Find_Id_btn_Click);
            // 
            // Find_Pw_btn
            // 
            this.Find_Pw_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Find_Pw_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Find_Pw_btn.Location = new System.Drawing.Point(187, 224);
            this.Find_Pw_btn.Name = "Find_Pw_btn";
            this.Find_Pw_btn.Size = new System.Drawing.Size(105, 23);
            this.Find_Pw_btn.TabIndex = 4;
            this.Find_Pw_btn.Text = "비밀번호찾기";
            this.Find_Pw_btn.UseVisualStyleBackColor = false;
            this.Find_Pw_btn.Click += new System.EventHandler(this.Find_Pw_btn_Click);
            // 
            // Signup_btn
            // 
            this.Signup_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Signup_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Signup_btn.Location = new System.Drawing.Point(77, 253);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(216, 23);
            this.Signup_btn.TabIndex = 5;
            this.Signup_btn.Text = "회원가입";
            this.Signup_btn.UseVisualStyleBackColor = false;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "5ms_Train";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 324);
            this.panel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Find_Pw_btn);
            this.Controls.Add(this.Find_Id_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Pw_text);
            this.Controls.Add(this.Id_Text);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Id_Text;
        private System.Windows.Forms.TextBox Pw_text;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Find_Id_btn;
        private System.Windows.Forms.Button Find_Pw_btn;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

