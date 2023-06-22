namespace DB_Train
{
    partial class AdminManageSchedule
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
            this.Delete_Schedule_btn = new System.Windows.Forms.Button();
            this.Train_Schedule_View = new System.Windows.Forms.DataGridView();
            this.Train_Label = new System.Windows.Forms.Label();
            this.Train_Type_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Train_Text = new System.Windows.Forms.Label();
            this.Train_Type_Text = new System.Windows.Forms.Label();
            this.Depart_Text = new System.Windows.Forms.Label();
            this.Depart_Station_Text = new System.Windows.Forms.Label();
            this.Arrival_Text = new System.Windows.Forms.Label();
            this.Arrival_Station_Text = new System.Windows.Forms.Label();
            this.Fare_Text = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Jo_btn = new System.Windows.Forms.Button();
            this.Arrival_CB = new System.Windows.Forms.ComboBox();
            this.Depart_CB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Train_Schedule_View)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Schedule_btn
            // 
            this.Add_Schedule_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Add_Schedule_btn.Location = new System.Drawing.Point(958, 265);
            this.Add_Schedule_btn.Name = "Add_Schedule_btn";
            this.Add_Schedule_btn.Size = new System.Drawing.Size(339, 75);
            this.Add_Schedule_btn.TabIndex = 0;
            this.Add_Schedule_btn.Text = "구간 등록";
            this.Add_Schedule_btn.UseVisualStyleBackColor = true;
            this.Add_Schedule_btn.Click += new System.EventHandler(this.Add_Schedule_btn_Click);
            // 
            // Delete_Schedule_btn
            // 
            this.Delete_Schedule_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Delete_Schedule_btn.Location = new System.Drawing.Point(16, 334);
            this.Delete_Schedule_btn.Name = "Delete_Schedule_btn";
            this.Delete_Schedule_btn.Size = new System.Drawing.Size(339, 75);
            this.Delete_Schedule_btn.TabIndex = 1;
            this.Delete_Schedule_btn.Text = "구간 삭제";
            this.Delete_Schedule_btn.UseVisualStyleBackColor = true;
            this.Delete_Schedule_btn.Click += new System.EventHandler(this.Delete_Schedule_btn_Click);
            // 
            // Train_Schedule_View
            // 
            this.Train_Schedule_View.AllowUserToAddRows = false;
            this.Train_Schedule_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Train_Schedule_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Train_Schedule_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Train_Schedule_View.Location = new System.Drawing.Point(17, 44);
            this.Train_Schedule_View.Name = "Train_Schedule_View";
            this.Train_Schedule_View.RowTemplate.Height = 23;
            this.Train_Schedule_View.Size = new System.Drawing.Size(918, 193);
            this.Train_Schedule_View.TabIndex = 2;
            this.Train_Schedule_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Train_Schedule_View_Cellclick);
            this.Train_Schedule_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Train_Schedule_View_Cellclick);
            // 
            // Train_Label
            // 
            this.Train_Label.AutoSize = true;
            this.Train_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Label.Location = new System.Drawing.Point(955, 25);
            this.Train_Label.Name = "Train_Label";
            this.Train_Label.Size = new System.Drawing.Size(76, 18);
            this.Train_Label.TabIndex = 3;
            this.Train_Label.Text = "열차 번호 :";
            // 
            // Train_Type_Label
            // 
            this.Train_Type_Label.AutoSize = true;
            this.Train_Type_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_Label.Location = new System.Drawing.Point(955, 54);
            this.Train_Type_Label.Name = "Train_Type_Label";
            this.Train_Type_Label.Size = new System.Drawing.Size(76, 18);
            this.Train_Type_Label.TabIndex = 4;
            this.Train_Type_Label.Text = "열차 등급 :";
            this.Train_Type_Label.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(955, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "출발 시간 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(973, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "출발역 :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(955, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "도착 시간 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(973, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "도착역 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(973, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "운임료 :";
            // 
            // Train_Text
            // 
            this.Train_Text.AutoSize = true;
            this.Train_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Text.Location = new System.Drawing.Point(1048, 25);
            this.Train_Text.Name = "Train_Text";
            this.Train_Text.Size = new System.Drawing.Size(49, 18);
            this.Train_Text.TabIndex = 10;
            this.Train_Text.Text = "label8";
            // 
            // Train_Type_Text
            // 
            this.Train_Type_Text.AutoSize = true;
            this.Train_Type_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_Text.Location = new System.Drawing.Point(1048, 54);
            this.Train_Type_Text.Name = "Train_Type_Text";
            this.Train_Type_Text.Size = new System.Drawing.Size(49, 18);
            this.Train_Type_Text.TabIndex = 11;
            this.Train_Type_Text.Text = "label9";
            // 
            // Depart_Text
            // 
            this.Depart_Text.AutoSize = true;
            this.Depart_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Text.Location = new System.Drawing.Point(1049, 84);
            this.Depart_Text.Name = "Depart_Text";
            this.Depart_Text.Size = new System.Drawing.Size(56, 18);
            this.Depart_Text.TabIndex = 12;
            this.Depart_Text.Text = "label10";
            // 
            // Depart_Station_Text
            // 
            this.Depart_Station_Text.AutoSize = true;
            this.Depart_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Station_Text.Location = new System.Drawing.Point(1048, 113);
            this.Depart_Station_Text.Name = "Depart_Station_Text";
            this.Depart_Station_Text.Size = new System.Drawing.Size(52, 18);
            this.Depart_Station_Text.TabIndex = 13;
            this.Depart_Station_Text.Text = "label11";
            // 
            // Arrival_Text
            // 
            this.Arrival_Text.AutoSize = true;
            this.Arrival_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Text.Location = new System.Drawing.Point(1051, 144);
            this.Arrival_Text.Name = "Arrival_Text";
            this.Arrival_Text.Size = new System.Drawing.Size(55, 18);
            this.Arrival_Text.TabIndex = 14;
            this.Arrival_Text.Text = "label12";
            // 
            // Arrival_Station_Text
            // 
            this.Arrival_Station_Text.AutoSize = true;
            this.Arrival_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Station_Text.Location = new System.Drawing.Point(1051, 175);
            this.Arrival_Station_Text.Name = "Arrival_Station_Text";
            this.Arrival_Station_Text.Size = new System.Drawing.Size(55, 18);
            this.Arrival_Station_Text.TabIndex = 15;
            this.Arrival_Station_Text.Text = "label13";
            // 
            // Fare_Text
            // 
            this.Fare_Text.AutoSize = true;
            this.Fare_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fare_Text.Location = new System.Drawing.Point(1051, 203);
            this.Fare_Text.Name = "Fare_Text";
            this.Fare_Text.Size = new System.Drawing.Size(56, 18);
            this.Fare_Text.TabIndex = 16;
            this.Fare_Text.Text = "label14";
            // 
            // idbox
            // 
            this.idbox.AutoSize = true;
            this.idbox.BackColor = System.Drawing.SystemColors.Control;
            this.idbox.ForeColor = System.Drawing.SystemColors.Control;
            this.idbox.Location = new System.Drawing.Point(1331, 593);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(38, 12);
            this.idbox.TabIndex = 17;
            this.idbox.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Delete_Schedule_btn);
            this.panel1.Location = new System.Drawing.Point(942, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 425);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Train_Schedule_View);
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 465);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Jo_btn);
            this.panel3.Controls.Add(this.Arrival_CB);
            this.panel3.Controls.Add(this.Depart_CB);
            this.panel3.Location = new System.Drawing.Point(542, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 163);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "도착역";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(42, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "출발역";
            // 
            // Jo_btn
            // 
            this.Jo_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Jo_btn.Location = new System.Drawing.Point(261, 55);
            this.Jo_btn.Name = "Jo_btn";
            this.Jo_btn.Size = new System.Drawing.Size(105, 46);
            this.Jo_btn.TabIndex = 2;
            this.Jo_btn.Text = "조회";
            this.Jo_btn.UseVisualStyleBackColor = true;
            this.Jo_btn.Click += new System.EventHandler(this.LookUp_btn_Click);
            // 
            // Arrival_CB
            // 
            this.Arrival_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Arrival_CB.FormattingEnabled = true;
            this.Arrival_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Arrival_CB.Location = new System.Drawing.Point(114, 81);
            this.Arrival_CB.Name = "Arrival_CB";
            this.Arrival_CB.Size = new System.Drawing.Size(121, 20);
            this.Arrival_CB.TabIndex = 1;
            // 
            // Depart_CB
            // 
            this.Depart_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Depart_CB.FormattingEnabled = true;
            this.Depart_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Depart_CB.Location = new System.Drawing.Point(114, 55);
            this.Depart_CB.Name = "Depart_CB";
            this.Depart_CB.Size = new System.Drawing.Size(121, 20);
            this.Depart_CB.TabIndex = 5;
            this.Depart_CB.SelectedIndexChanged += new System.EventHandler(this.Depart_CB_SelectedIndexChanged);
            // 
            // AdminManageSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 465);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.Fare_Text);
            this.Controls.Add(this.Arrival_Station_Text);
            this.Controls.Add(this.Arrival_Text);
            this.Controls.Add(this.Depart_Station_Text);
            this.Controls.Add(this.Depart_Text);
            this.Controls.Add(this.Train_Type_Text);
            this.Controls.Add(this.Train_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Train_Type_Label);
            this.Controls.Add(this.Train_Label);
            this.Controls.Add(this.Add_Schedule_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminManageSchedule";
            this.Text = "AdminManageSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.Train_Schedule_View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Schedule_btn;
        private System.Windows.Forms.Button Delete_Schedule_btn;
        private System.Windows.Forms.DataGridView Train_Schedule_View;
        private System.Windows.Forms.Label Train_Label;
        private System.Windows.Forms.Label Train_Type_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Train_Text;
        private System.Windows.Forms.Label Train_Type_Text;
        private System.Windows.Forms.Label Depart_Text;
        private System.Windows.Forms.Label Depart_Station_Text;
        private System.Windows.Forms.Label Arrival_Text;
        private System.Windows.Forms.Label Arrival_Station_Text;
        private System.Windows.Forms.Label Fare_Text;
        private System.Windows.Forms.Label idbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Jo_btn;
        private System.Windows.Forms.ComboBox Arrival_CB;
        private System.Windows.Forms.ComboBox Depart_CB;
    }
}