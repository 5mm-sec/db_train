namespace DB_Train
{
    partial class AdminMangeMember
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
            this.Member_View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Id_Text = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Grade_Text = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.Label();
            this.Info_Change_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Member_View)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Member_View
            // 
            this.Member_View.AllowUserToAddRows = false;
            this.Member_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Member_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Member_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Member_View.Location = new System.Drawing.Point(12, 12);
            this.Member_View.Name = "Member_View";
            this.Member_View.RowTemplate.Height = 23;
            this.Member_View.Size = new System.Drawing.Size(593, 227);
            this.Member_View.TabIndex = 0;
            this.Member_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Member_View_Cellclick);
            this.Member_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Member_View_Cellclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(630, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "아이디 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(640, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "이름 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(639, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "등급 :";
            // 
            // Id_Text
            // 
            this.Id_Text.AutoSize = true;
            this.Id_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Id_Text.Location = new System.Drawing.Point(702, 22);
            this.Id_Text.Name = "Id_Text";
            this.Id_Text.Size = new System.Drawing.Size(47, 16);
            this.Id_Text.TabIndex = 5;
            this.Id_Text.Text = "label5";
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(703, 50);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(100, 21);
            this.Name_Text.TabIndex = 7;
            // 
            // Grade_Text
            // 
            this.Grade_Text.Location = new System.Drawing.Point(703, 81);
            this.Grade_Text.Name = "Grade_Text";
            this.Grade_Text.Size = new System.Drawing.Size(100, 21);
            this.Grade_Text.TabIndex = 8;
            // 
            // idbox
            // 
            this.idbox.AutoSize = true;
            this.idbox.Location = new System.Drawing.Point(749, 7);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(0, 12);
            this.idbox.TabIndex = 9;
            this.idbox.Visible = false;
            // 
            // Info_Change_btn
            // 
            this.Info_Change_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Info_Change_btn.Location = new System.Drawing.Point(62, 175);
            this.Info_Change_btn.Name = "Info_Change_btn";
            this.Info_Change_btn.Size = new System.Drawing.Size(177, 36);
            this.Info_Change_btn.TabIndex = 10;
            this.Info_Change_btn.Text = "수정";
            this.Info_Change_btn.UseVisualStyleBackColor = true;
            this.Info_Change_btn.Click += new System.EventHandler(this.Info_Change_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Info_Change_btn);
            this.panel1.Location = new System.Drawing.Point(626, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 227);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 262);
            this.panel2.TabIndex = 12;
            // 
            // AdminMangeMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 261);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.Grade_Text);
            this.Controls.Add(this.Name_Text);
            this.Controls.Add(this.Id_Text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Member_View);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminMangeMember";
            this.Text = "AdminMangeMember";
            ((System.ComponentModel.ISupportInitialize)(this.Member_View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Member_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Id_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Grade_Text;
        private System.Windows.Forms.Label idbox;
        private System.Windows.Forms.Button Info_Change_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}