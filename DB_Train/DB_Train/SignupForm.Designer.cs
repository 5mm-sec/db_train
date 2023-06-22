namespace DB_Train
{
    partial class SignupForm
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
            this.Email_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pw_label = new System.Windows.Forms.Label();
            this.Pw_Check_label = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.Card_label = new System.Windows.Forms.Label();
            this.Email_Text = new System.Windows.Forms.TextBox();
            this.Pw_Check_Text = new System.Windows.Forms.TextBox();
            this.Pw_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.First_Phone_Text = new System.Windows.Forms.TextBox();
            this.First_Card_Text = new System.Windows.Forms.TextBox();
            this.Second_Phone_Text = new System.Windows.Forms.TextBox();
            this.Third_Phone_Text = new System.Windows.Forms.TextBox();
            this.Second_Card_Text = new System.Windows.Forms.TextBox();
            this.Third_Card_Text = new System.Windows.Forms.TextBox();
            this.Signup_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Email_label.Location = new System.Drawing.Point(77, 100);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(57, 18);
            this.Email_label.TabIndex = 0;
            this.Email_label.Text = "이메일 :";
            // 
            // Pw_label
            // 
            this.Pw_label.AutoSize = true;
            this.Pw_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pw_label.Location = new System.Drawing.Point(64, 136);
            this.Pw_label.Name = "Pw_label";
            this.Pw_label.Size = new System.Drawing.Size(70, 18);
            this.Pw_label.TabIndex = 2;
            this.Pw_label.Text = "비밀번호 :";
            this.Pw_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pw_Check_label
            // 
            this.Pw_Check_label.AutoSize = true;
            this.Pw_Check_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pw_Check_label.Location = new System.Drawing.Point(32, 169);
            this.Pw_Check_label.Name = "Pw_Check_label";
            this.Pw_Check_label.Size = new System.Drawing.Size(102, 18);
            this.Pw_Check_label.TabIndex = 3;
            this.Pw_Check_label.Text = "비밀번호 확인 :";
            this.Pw_Check_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name_label.Location = new System.Drawing.Point(90, 199);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(43, 18);
            this.Name_label.TabIndex = 4;
            this.Name_label.Text = "이름 :";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Phone_label.Location = new System.Drawing.Point(44, 228);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(90, 18);
            this.Phone_label.TabIndex = 5;
            this.Phone_label.Text = "휴대폰 번호 :";
            this.Phone_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // Card_label
            // 
            this.Card_label.AutoSize = true;
            this.Card_label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Card_label.Location = new System.Drawing.Point(60, 260);
            this.Card_label.Name = "Card_label";
            this.Card_label.Size = new System.Drawing.Size(76, 18);
            this.Card_label.TabIndex = 6;
            this.Card_label.Text = "카드 번호 :";
            // 
            // Email_Text
            // 
            this.Email_Text.Location = new System.Drawing.Point(153, 97);
            this.Email_Text.Name = "Email_Text";
            this.Email_Text.Size = new System.Drawing.Size(162, 21);
            this.Email_Text.TabIndex = 7;
            // 
            // Pw_Check_Text
            // 
            this.Pw_Check_Text.Location = new System.Drawing.Point(153, 169);
            this.Pw_Check_Text.Name = "Pw_Check_Text";
            this.Pw_Check_Text.Size = new System.Drawing.Size(162, 21);
            this.Pw_Check_Text.TabIndex = 9;
            this.Pw_Check_Text.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Pw_Text
            // 
            this.Pw_Text.Location = new System.Drawing.Point(153, 135);
            this.Pw_Text.Name = "Pw_Text";
            this.Pw_Text.Size = new System.Drawing.Size(162, 21);
            this.Pw_Text.TabIndex = 10;
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(153, 198);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(162, 21);
            this.Name_Text.TabIndex = 11;
            // 
            // First_Phone_Text
            // 
            this.First_Phone_Text.Location = new System.Drawing.Point(153, 225);
            this.First_Phone_Text.Name = "First_Phone_Text";
            this.First_Phone_Text.Size = new System.Drawing.Size(50, 21);
            this.First_Phone_Text.TabIndex = 12;
            // 
            // First_Card_Text
            // 
            this.First_Card_Text.Location = new System.Drawing.Point(153, 257);
            this.First_Card_Text.Name = "First_Card_Text";
            this.First_Card_Text.Size = new System.Drawing.Size(50, 21);
            this.First_Card_Text.TabIndex = 13;
            // 
            // Second_Phone_Text
            // 
            this.Second_Phone_Text.Location = new System.Drawing.Point(209, 225);
            this.Second_Phone_Text.Name = "Second_Phone_Text";
            this.Second_Phone_Text.Size = new System.Drawing.Size(50, 21);
            this.Second_Phone_Text.TabIndex = 14;
            // 
            // Third_Phone_Text
            // 
            this.Third_Phone_Text.Location = new System.Drawing.Point(267, 225);
            this.Third_Phone_Text.Name = "Third_Phone_Text";
            this.Third_Phone_Text.Size = new System.Drawing.Size(50, 21);
            this.Third_Phone_Text.TabIndex = 15;
            // 
            // Second_Card_Text
            // 
            this.Second_Card_Text.Location = new System.Drawing.Point(209, 257);
            this.Second_Card_Text.Name = "Second_Card_Text";
            this.Second_Card_Text.Size = new System.Drawing.Size(50, 21);
            this.Second_Card_Text.TabIndex = 16;
            // 
            // Third_Card_Text
            // 
            this.Third_Card_Text.Location = new System.Drawing.Point(265, 257);
            this.Third_Card_Text.Name = "Third_Card_Text";
            this.Third_Card_Text.Size = new System.Drawing.Size(50, 21);
            this.Third_Card_Text.TabIndex = 17;
            // 
            // Signup_btn
            // 
            this.Signup_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Signup_btn.Location = new System.Drawing.Point(366, 115);
            this.Signup_btn.Name = "Signup_btn";
            this.Signup_btn.Size = new System.Drawing.Size(131, 57);
            this.Signup_btn.TabIndex = 18;
            this.Signup_btn.Text = "회원가입";
            this.Signup_btn.UseVisualStyleBackColor = true;
            this.Signup_btn.Click += new System.EventHandler(this.Signup_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_btn.Location = new System.Drawing.Point(366, 182);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(131, 57);
            this.Cancel_btn.TabIndex = 19;
            this.Cancel_btn.Text = "취소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 20;
            this.label1.Text = "환영합니다";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.ForeColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(22, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 207);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(3, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 325);
            this.panel2.TabIndex = 22;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Signup_btn);
            this.Controls.Add(this.Third_Card_Text);
            this.Controls.Add(this.Second_Card_Text);
            this.Controls.Add(this.Third_Phone_Text);
            this.Controls.Add(this.Second_Phone_Text);
            this.Controls.Add(this.First_Card_Text);
            this.Controls.Add(this.First_Phone_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Pw_Text);
            this.Controls.Add(this.Pw_Check_Text);
            this.Controls.Add(this.Email_Text);
            this.Controls.Add(this.Card_label);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Pw_Check_label);
            this.Controls.Add(this.Pw_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SignupForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Pw_label;
        private System.Windows.Forms.Label Pw_Check_label;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Label Card_label;
        private System.Windows.Forms.TextBox Email_Text;
        private System.Windows.Forms.TextBox Pw_Check_Text;
        private System.Windows.Forms.TextBox Pw_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox First_Phone_Text;
        private System.Windows.Forms.TextBox First_Card_Text;
        private System.Windows.Forms.TextBox Second_Phone_Text;
        private System.Windows.Forms.TextBox Third_Phone_Text;
        private System.Windows.Forms.TextBox Second_Card_Text;
        private System.Windows.Forms.TextBox Third_Card_Text;
        private System.Windows.Forms.Button Signup_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}