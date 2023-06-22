namespace DB_Train
{
    partial class UserTicketing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Depart_Station_CB = new System.Windows.Forms.ComboBox();
            this.Arrival_Staion_CB = new System.Windows.Forms.ComboBox();
            this.Schedule_View = new System.Windows.Forms.DataGridView();
            this.Choice_Seat_btn = new System.Windows.Forms.Button();
            this.Lookup_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Depart_Station_Text = new System.Windows.Forms.Label();
            this.Arrival_Station_Text = new System.Windows.Forms.Label();
            this.Depart_Date_Text = new System.Windows.Forms.Label();
            this.Fare_Text = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Arrival_Date_Text = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Train_Text = new System.Windows.Forms.Label();
            this.Order_Label = new System.Windows.Forms.Label();
            this.Order_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_View)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(104, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(104, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역";
            // 
            // Depart_Station_CB
            // 
            this.Depart_Station_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Depart_Station_CB.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Station_CB.FormattingEnabled = true;
            this.Depart_Station_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Depart_Station_CB.Location = new System.Drawing.Point(172, 56);
            this.Depart_Station_CB.Name = "Depart_Station_CB";
            this.Depart_Station_CB.Size = new System.Drawing.Size(121, 21);
            this.Depart_Station_CB.TabIndex = 8;
            // 
            // Arrival_Staion_CB
            // 
            this.Arrival_Staion_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Arrival_Staion_CB.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Staion_CB.FormattingEnabled = true;
            this.Arrival_Staion_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Arrival_Staion_CB.Location = new System.Drawing.Point(172, 87);
            this.Arrival_Staion_CB.Name = "Arrival_Staion_CB";
            this.Arrival_Staion_CB.Size = new System.Drawing.Size(121, 21);
            this.Arrival_Staion_CB.TabIndex = 8;
            // 
            // Schedule_View
            // 
            this.Schedule_View.AllowUserToAddRows = false;
            this.Schedule_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Schedule_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Schedule_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Schedule_View.Location = new System.Drawing.Point(26, 151);
            this.Schedule_View.Name = "Schedule_View";
            this.Schedule_View.RowTemplate.Height = 23;
            this.Schedule_View.Size = new System.Drawing.Size(601, 106);
            this.Schedule_View.TabIndex = 6;
            this.Schedule_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schedule_View_Cellclick);
            this.Schedule_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Schedule_View_Cellclick);
            // 
            // Choice_Seat_btn
            // 
            this.Choice_Seat_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Choice_Seat_btn.Location = new System.Drawing.Point(515, 36);
            this.Choice_Seat_btn.Name = "Choice_Seat_btn";
            this.Choice_Seat_btn.Size = new System.Drawing.Size(112, 86);
            this.Choice_Seat_btn.TabIndex = 7;
            this.Choice_Seat_btn.Text = "좌석 선택";
            this.Choice_Seat_btn.UseVisualStyleBackColor = true;
            this.Choice_Seat_btn.Click += new System.EventHandler(this.Choice_Seat_btn_Click);
            // 
            // Lookup_btn
            // 
            this.Lookup_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Lookup_btn.Location = new System.Drawing.Point(361, 36);
            this.Lookup_btn.Name = "Lookup_btn";
            this.Lookup_btn.Size = new System.Drawing.Size(112, 86);
            this.Lookup_btn.TabIndex = 8;
            this.Lookup_btn.Text = "열차 조회";
            this.Lookup_btn.UseVisualStyleBackColor = true;
            this.Lookup_btn.Click += new System.EventHandler(this.Lookup_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(698, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "출발역 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(698, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "도착역 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(657, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "출발 날짜/시간 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(707, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "운임료 :";
            // 
            // Depart_Station_Text
            // 
            this.Depart_Station_Text.AutoSize = true;
            this.Depart_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Station_Text.Location = new System.Drawing.Point(771, 103);
            this.Depart_Station_Text.Name = "Depart_Station_Text";
            this.Depart_Station_Text.Size = new System.Drawing.Size(0, 16);
            this.Depart_Station_Text.TabIndex = 13;
            // 
            // Arrival_Station_Text
            // 
            this.Arrival_Station_Text.AutoSize = true;
            this.Arrival_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Station_Text.Location = new System.Drawing.Point(771, 139);
            this.Arrival_Station_Text.Name = "Arrival_Station_Text";
            this.Arrival_Station_Text.Size = new System.Drawing.Size(0, 16);
            this.Arrival_Station_Text.TabIndex = 14;
            // 
            // Depart_Date_Text
            // 
            this.Depart_Date_Text.AutoSize = true;
            this.Depart_Date_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Date_Text.Location = new System.Drawing.Point(771, 174);
            this.Depart_Date_Text.Name = "Depart_Date_Text";
            this.Depart_Date_Text.Size = new System.Drawing.Size(0, 16);
            this.Depart_Date_Text.TabIndex = 15;
            // 
            // Fare_Text
            // 
            this.Fare_Text.AutoSize = true;
            this.Fare_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fare_Text.Location = new System.Drawing.Point(771, 245);
            this.Fare_Text.Name = "Fare_Text";
            this.Fare_Text.Size = new System.Drawing.Size(0, 16);
            this.Fare_Text.TabIndex = 16;
            // 
            // idbox
            // 
            this.idbox.AutoSize = true;
            this.idbox.BackColor = System.Drawing.SystemColors.Control;
            this.idbox.ForeColor = System.Drawing.SystemColors.Control;
            this.idbox.Location = new System.Drawing.Point(589, 270);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(38, 12);
            this.idbox.TabIndex = 17;
            this.idbox.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(657, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "도착 날짜/시간 :";
            // 
            // Arrival_Date_Text
            // 
            this.Arrival_Date_Text.AutoSize = true;
            this.Arrival_Date_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Date_Text.Location = new System.Drawing.Point(771, 211);
            this.Arrival_Date_Text.Name = "Arrival_Date_Text";
            this.Arrival_Date_Text.Size = new System.Drawing.Size(0, 16);
            this.Arrival_Date_Text.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(686, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "열차번호 :";
            // 
            // Train_Text
            // 
            this.Train_Text.AutoSize = true;
            this.Train_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Text.Location = new System.Drawing.Point(769, 67);
            this.Train_Text.Name = "Train_Text";
            this.Train_Text.Size = new System.Drawing.Size(0, 16);
            this.Train_Text.TabIndex = 21;
            // 
            // Order_Label
            // 
            this.Order_Label.AutoSize = true;
            this.Order_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order_Label.Location = new System.Drawing.Point(692, 36);
            this.Order_Label.Name = "Order_Label";
            this.Order_Label.Size = new System.Drawing.Size(53, 16);
            this.Order_Label.TabIndex = 22;
            this.Order_Label.Text = "역순번 :";
            this.Order_Label.Visible = false;
            // 
            // Order_Text
            // 
            this.Order_Text.AutoSize = true;
            this.Order_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order_Text.Location = new System.Drawing.Point(771, 36);
            this.Order_Text.Name = "Order_Text";
            this.Order_Text.Size = new System.Drawing.Size(0, 16);
            this.Order_Text.TabIndex = 23;
            this.Order_Text.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 316);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(651, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 259);
            this.panel2.TabIndex = 0;
            // 
            // UserTicketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 307);
            this.Controls.Add(this.Order_Text);
            this.Controls.Add(this.Order_Label);
            this.Controls.Add(this.Train_Text);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Arrival_Date_Text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Fare_Text);
            this.Controls.Add(this.Depart_Date_Text);
            this.Controls.Add(this.Arrival_Station_Text);
            this.Controls.Add(this.Depart_Station_Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lookup_btn);
            this.Controls.Add(this.Choice_Seat_btn);
            this.Controls.Add(this.Schedule_View);
            this.Controls.Add(this.Arrival_Staion_CB);
            this.Controls.Add(this.Depart_Station_CB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.idbox);
            this.Name = "UserTicketing";
            this.Text = "UserTicketing";
            ((System.ComponentModel.ISupportInitialize)(this.Schedule_View)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Depart_Station_CB;
        private System.Windows.Forms.ComboBox Arrival_Staion_CB;
        private System.Windows.Forms.DataGridView Schedule_View;
        private System.Windows.Forms.Button Choice_Seat_btn;
        private System.Windows.Forms.Button Lookup_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Depart_Station_Text;
        private System.Windows.Forms.Label Arrival_Station_Text;
        private System.Windows.Forms.Label Depart_Date_Text;
        private System.Windows.Forms.Label Fare_Text;
        private System.Windows.Forms.Label idbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Arrival_Date_Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Train_Text;
        private System.Windows.Forms.Label Order_Label;
        private System.Windows.Forms.Label Order_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}