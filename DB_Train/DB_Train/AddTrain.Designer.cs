namespace DB_Train
{
    partial class AddTrain
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
            this.Train_Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Train_Type_Label = new System.Windows.Forms.Label();
            this.Train_Text = new System.Windows.Forms.TextBox();
            this.Regi_Train_btn = new System.Windows.Forms.Button();
            this.Train_Type_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Train_Label
            // 
            this.Train_Label.AutoSize = true;
            this.Train_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Label.Location = new System.Drawing.Point(52, 113);
            this.Train_Label.Name = "Train_Label";
            this.Train_Label.Size = new System.Drawing.Size(68, 18);
            this.Train_Label.TabIndex = 0;
            this.Train_Label.Text = "열차 번호";
            // 
            // Train_Type_Label
            // 
            this.Train_Type_Label.AutoSize = true;
            this.Train_Type_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_Label.Location = new System.Drawing.Point(52, 140);
            this.Train_Type_Label.Name = "Train_Type_Label";
            this.Train_Type_Label.Size = new System.Drawing.Size(68, 18);
            this.Train_Type_Label.TabIndex = 1;
            this.Train_Type_Label.Text = "열차 등급";
            // 
            // Train_Text
            // 
            this.Train_Text.Location = new System.Drawing.Point(138, 110);
            this.Train_Text.Name = "Train_Text";
            this.Train_Text.Size = new System.Drawing.Size(148, 21);
            this.Train_Text.TabIndex = 2;
            // 
            // Regi_Train_btn
            // 
            this.Regi_Train_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Regi_Train_btn.Location = new System.Drawing.Point(306, 109);
            this.Regi_Train_btn.Name = "Regi_Train_btn";
            this.Regi_Train_btn.Size = new System.Drawing.Size(90, 51);
            this.Regi_Train_btn.TabIndex = 4;
            this.Regi_Train_btn.Text = "열차 등록";
            this.Regi_Train_btn.UseVisualStyleBackColor = true;
            this.Regi_Train_btn.Click += new System.EventHandler(this.Regi_Train_btn_Click);
            // 
            // Train_Type_Text
            // 
            this.Train_Type_Text.Location = new System.Drawing.Point(138, 137);
            this.Train_Type_Text.Name = "Train_Type_Text";
            this.Train_Type_Text.Size = new System.Drawing.Size(148, 21);
            this.Train_Type_Text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "열차 등록";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 228);
            this.panel1.TabIndex = 7;
            // 
            // AddTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Train_Type_Text);
            this.Controls.Add(this.Regi_Train_btn);
            this.Controls.Add(this.Train_Text);
            this.Controls.Add(this.Train_Type_Label);
            this.Controls.Add(this.Train_Label);
            this.Controls.Add(this.panel1);
            this.Name = "AddTrain";
            this.Text = "AddTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Train_Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Train_Type_Label;
        private System.Windows.Forms.TextBox Train_Text;
        private System.Windows.Forms.Button Regi_Train_btn;
        private System.Windows.Forms.TextBox Train_Type_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}