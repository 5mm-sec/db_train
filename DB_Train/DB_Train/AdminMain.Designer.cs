namespace DB_Train
{
    partial class AdminMain
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
            this.Add_Schedule_btn = new System.Windows.Forms.Button();
            this.Regi_Train_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Member_Manage_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Add_Schedule_btn
            // 
            this.Add_Schedule_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add_Schedule_btn.Location = new System.Drawing.Point(147, 112);
            this.Add_Schedule_btn.Name = "Add_Schedule_btn";
            this.Add_Schedule_btn.Size = new System.Drawing.Size(297, 55);
            this.Add_Schedule_btn.TabIndex = 0;
            this.Add_Schedule_btn.Text = "구간 관리";
            this.Add_Schedule_btn.UseVisualStyleBackColor = true;
            this.Add_Schedule_btn.Click += new System.EventHandler(this.Edit_Train_Schedule_btn_Click);
            // 
            // Regi_Train_btn
            // 
            this.Regi_Train_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Regi_Train_btn.Location = new System.Drawing.Point(147, 184);
            this.Regi_Train_btn.Name = "Regi_Train_btn";
            this.Regi_Train_btn.Size = new System.Drawing.Size(297, 55);
            this.Regi_Train_btn.TabIndex = 1;
            this.Regi_Train_btn.Text = "열차 등록";
            this.Regi_Train_btn.UseVisualStyleBackColor = true;
            this.Regi_Train_btn.Click += new System.EventHandler(this.Regi_Train_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "관리자님 환영합니다.";
            // 
            // Member_Manage_btn
            // 
            this.Member_Manage_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_Manage_btn.Location = new System.Drawing.Point(147, 256);
            this.Member_Manage_btn.Name = "Member_Manage_btn";
            this.Member_Manage_btn.Size = new System.Drawing.Size(297, 55);
            this.Member_Manage_btn.TabIndex = 4;
            this.Member_Manage_btn.Text = "회원 관리";
            this.Member_Manage_btn.UseVisualStyleBackColor = true;
            this.Member_Manage_btn.Click += new System.EventHandler(this.Member_Manage_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 345);
            this.panel1.TabIndex = 5;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 340);
            this.Controls.Add(this.Member_Manage_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regi_Train_btn);
            this.Controls.Add(this.Add_Schedule_btn);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Schedule_btn;
        private System.Windows.Forms.Button Regi_Train_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Member_Manage_btn;
        private System.Windows.Forms.Panel panel1;
    }
}