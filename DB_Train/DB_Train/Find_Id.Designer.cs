namespace DB_Train
{
    partial class Find_Id
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.Phone_Label = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.First_Phone_Text = new System.Windows.Forms.TextBox();
            this.Second_Phone_Text = new System.Windows.Forms.TextBox();
            this.Third_Phone_Text = new System.Windows.Forms.TextBox();
            this.Find_Id_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name_Label.Location = new System.Drawing.Point(84, 89);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(40, 16);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "이름 :";
            // 
            // Phone_Label
            // 
            this.Phone_Label.AutoSize = true;
            this.Phone_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Phone_Label.Location = new System.Drawing.Point(58, 121);
            this.Phone_Label.Name = "Phone_Label";
            this.Phone_Label.Size = new System.Drawing.Size(66, 16);
            this.Phone_Label.TabIndex = 1;
            this.Phone_Label.Text = "전화번호 :";
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(145, 80);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(216, 21);
            this.Name_Text.TabIndex = 2;
            // 
            // First_Phone_Text
            // 
            this.First_Phone_Text.Location = new System.Drawing.Point(145, 120);
            this.First_Phone_Text.Name = "First_Phone_Text";
            this.First_Phone_Text.Size = new System.Drawing.Size(68, 21);
            this.First_Phone_Text.TabIndex = 3;
            // 
            // Second_Phone_Text
            // 
            this.Second_Phone_Text.Location = new System.Drawing.Point(219, 120);
            this.Second_Phone_Text.Name = "Second_Phone_Text";
            this.Second_Phone_Text.Size = new System.Drawing.Size(68, 21);
            this.Second_Phone_Text.TabIndex = 4;
            // 
            // Third_Phone_Text
            // 
            this.Third_Phone_Text.Location = new System.Drawing.Point(293, 121);
            this.Third_Phone_Text.Name = "Third_Phone_Text";
            this.Third_Phone_Text.Size = new System.Drawing.Size(68, 21);
            this.Third_Phone_Text.TabIndex = 5;
            // 
            // Find_Id_btn
            // 
            this.Find_Id_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Find_Id_btn.Location = new System.Drawing.Point(145, 161);
            this.Find_Id_btn.Name = "Find_Id_btn";
            this.Find_Id_btn.Size = new System.Drawing.Size(216, 23);
            this.Find_Id_btn.TabIndex = 6;
            this.Find_Id_btn.Text = "아이디 찾기";
            this.Find_Id_btn.UseVisualStyleBackColor = true;
            this.Find_Id_btn.Click += new System.EventHandler(this.Find_Id_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_btn.Location = new System.Drawing.Point(145, 201);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(216, 23);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "취소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(53, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 185);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 295);
            this.panel2.TabIndex = 9;
            // 
            // Find_Id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 287);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Find_Id_btn);
            this.Controls.Add(this.Third_Phone_Text);
            this.Controls.Add(this.Second_Phone_Text);
            this.Controls.Add(this.First_Phone_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Phone_Label);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Find_Id";
            this.Text = "Find_Id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Phone_Label;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox First_Phone_Text;
        private System.Windows.Forms.TextBox Second_Phone_Text;
        private System.Windows.Forms.TextBox Third_Phone_Text;
        private System.Windows.Forms.Button Find_Id_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}