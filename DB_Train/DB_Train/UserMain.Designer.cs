namespace DB_Train
{
    partial class UserMain
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
            this.Ticketing_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.Lookup_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Member_Info_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ticketing_btn
            // 
            this.Ticketing_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ticketing_btn.Location = new System.Drawing.Point(24, 144);
            this.Ticketing_btn.Name = "Ticketing_btn";
            this.Ticketing_btn.Size = new System.Drawing.Size(300, 38);
            this.Ticketing_btn.TabIndex = 0;
            this.Ticketing_btn.Text = "열차 예매";
            this.Ticketing_btn.UseVisualStyleBackColor = true;
            this.Ticketing_btn.Click += new System.EventHandler(this.Ticketing_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Lookup_btn
            // 
            this.Lookup_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lookup_btn.Location = new System.Drawing.Point(24, 188);
            this.Lookup_btn.Name = "Lookup_btn";
            this.Lookup_btn.Size = new System.Drawing.Size(300, 38);
            this.Lookup_btn.TabIndex = 2;
            this.Lookup_btn.Text = "예매 내역 조회";
            this.Lookup_btn.UseVisualStyleBackColor = true;
            this.Lookup_btn.Click += new System.EventHandler(this.Lookup_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 69);
            this.label2.TabIndex = 3;
            this.label2.Text = "5ms_Train";
            // 
            // Member_Info_btn
            // 
            this.Member_Info_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Member_Info_btn.Location = new System.Drawing.Point(24, 232);
            this.Member_Info_btn.Name = "Member_Info_btn";
            this.Member_Info_btn.Size = new System.Drawing.Size(300, 38);
            this.Member_Info_btn.TabIndex = 4;
            this.Member_Info_btn.Text = "회원 정보";
            this.Member_Info_btn.UseVisualStyleBackColor = true;
            this.Member_Info_btn.Click += new System.EventHandler(this.Member_Info_btn_Click);
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.Member_Info_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lookup_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ticketing_btn);
            this.Name = "UserMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ticketing_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Lookup_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Member_Info_btn;
    }
}