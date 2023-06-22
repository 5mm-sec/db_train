namespace DB_Train
{
    partial class AdminAddSchedule
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
            this.Train_Type_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Depart_Label = new System.Windows.Forms.Label();
            this.Depart_Station_Label = new System.Windows.Forms.Label();
            this.Arrival_Label = new System.Windows.Forms.Label();
            this.Arrival_Station_Label = new System.Windows.Forms.Label();
            this.Depart_Station_CB = new System.Windows.Forms.ComboBox();
            this.Arrival_Station_CB = new System.Windows.Forms.ComboBox();
            this.Depart_PK = new System.Windows.Forms.DateTimePicker();
            this.Arrival_PK = new System.Windows.Forms.DateTimePicker();
            this.Fare_Label = new System.Windows.Forms.Label();
            this.Fare_Text = new System.Windows.Forms.TextBox();
            this.Train_Label = new System.Windows.Forms.Label();
            this.Regi_btn = new System.Windows.Forms.Button();
            this.Train_Data_View = new System.Windows.Forms.DataGridView();
            this.Train_View_Label = new System.Windows.Forms.Label();
            this.Train_Type_View_Label = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.Label();
            this.Direction_Label = new System.Windows.Forms.Label();
            this.Direction_Text = new System.Windows.Forms.TextBox();
            this.번역순 = new System.Windows.Forms.Label();
            this.Order_Text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Train_Data_View)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Train_Type_Label
            // 
            this.Train_Type_Label.AutoSize = true;
            this.Train_Type_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_Label.Location = new System.Drawing.Point(279, 99);
            this.Train_Type_Label.Name = "Train_Type_Label";
            this.Train_Type_Label.Size = new System.Drawing.Size(75, 18);
            this.Train_Type_Label.TabIndex = 0;
            this.Train_Type_Label.Text = "열차 종류 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 2;
            // 
            // Depart_Label
            // 
            this.Depart_Label.AutoSize = true;
            this.Depart_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Label.Location = new System.Drawing.Point(280, 126);
            this.Depart_Label.Name = "Depart_Label";
            this.Depart_Label.Size = new System.Drawing.Size(74, 18);
            this.Depart_Label.TabIndex = 3;
            this.Depart_Label.Text = "출발 시간 :";
            // 
            // Depart_Station_Label
            // 
            this.Depart_Station_Label.AutoSize = true;
            this.Depart_Station_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Station_Label.Location = new System.Drawing.Point(297, 155);
            this.Depart_Station_Label.Name = "Depart_Station_Label";
            this.Depart_Station_Label.Size = new System.Drawing.Size(56, 18);
            this.Depart_Station_Label.TabIndex = 4;
            this.Depart_Station_Label.Text = "출발역 :";
            this.Depart_Station_Label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Arrival_Label
            // 
            this.Arrival_Label.AutoSize = true;
            this.Arrival_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Label.Location = new System.Drawing.Point(280, 183);
            this.Arrival_Label.Name = "Arrival_Label";
            this.Arrival_Label.Size = new System.Drawing.Size(74, 18);
            this.Arrival_Label.TabIndex = 5;
            this.Arrival_Label.Text = "도착 시간 :";
            // 
            // Arrival_Station_Label
            // 
            this.Arrival_Station_Label.AutoSize = true;
            this.Arrival_Station_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Station_Label.Location = new System.Drawing.Point(296, 210);
            this.Arrival_Station_Label.Name = "Arrival_Station_Label";
            this.Arrival_Station_Label.Size = new System.Drawing.Size(56, 18);
            this.Arrival_Station_Label.TabIndex = 6;
            this.Arrival_Station_Label.Text = "도착역 :";
            // 
            // Depart_Station_CB
            // 
            this.Depart_Station_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Depart_Station_CB.FormattingEnabled = true;
            this.Depart_Station_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Depart_Station_CB.Location = new System.Drawing.Point(373, 153);
            this.Depart_Station_CB.Name = "Depart_Station_CB";
            this.Depart_Station_CB.Size = new System.Drawing.Size(121, 20);
            this.Depart_Station_CB.TabIndex = 5;
            // 
            // Arrival_Station_CB
            // 
            this.Arrival_Station_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Arrival_Station_CB.FormattingEnabled = true;
            this.Arrival_Station_CB.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.Arrival_Station_CB.Location = new System.Drawing.Point(373, 207);
            this.Arrival_Station_CB.Name = "Arrival_Station_CB";
            this.Arrival_Station_CB.Size = new System.Drawing.Size(121, 20);
            this.Arrival_Station_CB.TabIndex = 5;
            // 
            // Depart_PK
            // 
            this.Depart_PK.CustomFormat = "yyyy년MM월dd일 HH시mm분";
            this.Depart_PK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Depart_PK.Location = new System.Drawing.Point(373, 122);
            this.Depart_PK.Name = "Depart_PK";
            this.Depart_PK.Size = new System.Drawing.Size(176, 21);
            this.Depart_PK.TabIndex = 2;
            // 
            // Arrival_PK
            // 
            this.Arrival_PK.CustomFormat = "yyyy년MM월dd일 HH시mm분";
            this.Arrival_PK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Arrival_PK.Location = new System.Drawing.Point(373, 180);
            this.Arrival_PK.Name = "Arrival_PK";
            this.Arrival_PK.Size = new System.Drawing.Size(176, 21);
            this.Arrival_PK.TabIndex = 2;
            // 
            // Fare_Label
            // 
            this.Fare_Label.AutoSize = true;
            this.Fare_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fare_Label.Location = new System.Drawing.Point(297, 240);
            this.Fare_Label.Name = "Fare_Label";
            this.Fare_Label.Size = new System.Drawing.Size(55, 18);
            this.Fare_Label.TabIndex = 12;
            this.Fare_Label.Text = "운임료 :";
            // 
            // Fare_Text
            // 
            this.Fare_Text.Location = new System.Drawing.Point(373, 238);
            this.Fare_Text.Name = "Fare_Text";
            this.Fare_Text.Size = new System.Drawing.Size(100, 21);
            this.Fare_Text.TabIndex = 13;
            this.Fare_Text.TextChanged += new System.EventHandler(this.Fare_Text_TextChanged);
            // 
            // Train_Label
            // 
            this.Train_Label.AutoSize = true;
            this.Train_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Label.Location = new System.Drawing.Point(285, 68);
            this.Train_Label.Name = "Train_Label";
            this.Train_Label.Size = new System.Drawing.Size(71, 18);
            this.Train_Label.TabIndex = 14;
            this.Train_Label.Text = "열차번호 :";
            // 
            // Regi_btn
            // 
            this.Regi_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Regi_btn.Location = new System.Drawing.Point(578, 29);
            this.Regi_btn.Name = "Regi_btn";
            this.Regi_btn.Size = new System.Drawing.Size(95, 277);
            this.Regi_btn.TabIndex = 16;
            this.Regi_btn.Text = "등록";
            this.Regi_btn.UseVisualStyleBackColor = true;
            this.Regi_btn.Click += new System.EventHandler(this.Regi_btn_Click);
            // 
            // Train_Data_View
            // 
            this.Train_Data_View.AllowUserToAddRows = false;
            this.Train_Data_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Train_Data_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Train_Data_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Train_Data_View.Location = new System.Drawing.Point(12, 29);
            this.Train_Data_View.Name = "Train_Data_View";
            this.Train_Data_View.RowTemplate.Height = 23;
            this.Train_Data_View.Size = new System.Drawing.Size(239, 277);
            this.Train_Data_View.TabIndex = 17;
            this.Train_Data_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Train_Data_View_Cellclick);
            this.Train_Data_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Train_Data_View_Cellclick);
            // 
            // Train_View_Label
            // 
            this.Train_View_Label.AutoSize = true;
            this.Train_View_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_View_Label.Location = new System.Drawing.Point(371, 70);
            this.Train_View_Label.Name = "Train_View_Label";
            this.Train_View_Label.Size = new System.Drawing.Size(44, 16);
            this.Train_View_Label.TabIndex = 18;
            this.Train_View_Label.Text = "label1";
            this.Train_View_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Train_Type_View_Label
            // 
            this.Train_Type_View_Label.AutoSize = true;
            this.Train_Type_View_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_View_Label.Location = new System.Drawing.Point(371, 99);
            this.Train_Type_View_Label.Name = "Train_Type_View_Label";
            this.Train_Type_View_Label.Size = new System.Drawing.Size(48, 16);
            this.Train_Type_View_Label.TabIndex = 19;
            this.Train_Type_View_Label.Text = "label2";
            // 
            // idbox
            // 
            this.idbox.AutoSize = true;
            this.idbox.BackColor = System.Drawing.SystemColors.Control;
            this.idbox.ForeColor = System.Drawing.SystemColors.Control;
            this.idbox.Location = new System.Drawing.Point(595, 264);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(38, 12);
            this.idbox.TabIndex = 20;
            this.idbox.Text = "label1";
            this.idbox.Visible = false;
            // 
            // Direction_Label
            // 
            this.Direction_Label.AutoSize = true;
            this.Direction_Label.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Direction_Label.Location = new System.Drawing.Point(304, 276);
            this.Direction_Label.Name = "Direction_Label";
            this.Direction_Label.Size = new System.Drawing.Size(44, 18);
            this.Direction_Label.TabIndex = 23;
            this.Direction_Label.Text = "방향 :";
            // 
            // Direction_Text
            // 
            this.Direction_Text.Location = new System.Drawing.Point(373, 274);
            this.Direction_Text.Name = "Direction_Text";
            this.Direction_Text.Size = new System.Drawing.Size(100, 21);
            this.Direction_Text.TabIndex = 24;
            // 
            // 번역순
            // 
            this.번역순.AutoSize = true;
            this.번역순.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.번역순.Location = new System.Drawing.Point(298, 41);
            this.번역순.Name = "번역순";
            this.번역순.Size = new System.Drawing.Size(56, 18);
            this.번역순.TabIndex = 25;
            this.번역순.Text = "역순번 :";
            this.번역순.Click += new System.EventHandler(this.번역순_Click);
            // 
            // Order_Text
            // 
            this.Order_Text.Location = new System.Drawing.Point(373, 38);
            this.Order_Text.Name = "Order_Text";
            this.Order_Text.Size = new System.Drawing.Size(100, 21);
            this.Order_Text.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(272, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 277);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.idbox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 350);
            this.panel2.TabIndex = 28;
            // 
            // AdminAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 347);
            this.Controls.Add(this.Order_Text);
            this.Controls.Add(this.번역순);
            this.Controls.Add(this.Direction_Text);
            this.Controls.Add(this.Direction_Label);
            this.Controls.Add(this.Train_Type_View_Label);
            this.Controls.Add(this.Train_View_Label);
            this.Controls.Add(this.Train_Data_View);
            this.Controls.Add(this.Regi_btn);
            this.Controls.Add(this.Train_Label);
            this.Controls.Add(this.Fare_Text);
            this.Controls.Add(this.Fare_Label);
            this.Controls.Add(this.Arrival_PK);
            this.Controls.Add(this.Depart_PK);
            this.Controls.Add(this.Arrival_Station_CB);
            this.Controls.Add(this.Depart_Station_CB);
            this.Controls.Add(this.Arrival_Station_Label);
            this.Controls.Add(this.Arrival_Label);
            this.Controls.Add(this.Depart_Station_Label);
            this.Controls.Add(this.Depart_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Train_Type_Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AdminAddSchedule";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Train_Data_View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Train_Type_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Depart_Label;
        private System.Windows.Forms.Label Depart_Station_Label;
        private System.Windows.Forms.Label Arrival_Label;
        private System.Windows.Forms.Label Arrival_Station_Label;
        private System.Windows.Forms.ComboBox Depart_Station_CB;
        private System.Windows.Forms.ComboBox Arrival_Station_CB;
        private System.Windows.Forms.DateTimePicker Depart_PK;
        private System.Windows.Forms.DateTimePicker Arrival_PK;
        private System.Windows.Forms.Label Fare_Label;
        private System.Windows.Forms.TextBox Fare_Text;
        private System.Windows.Forms.Label Train_Label;
        private System.Windows.Forms.Button Regi_btn;
        private System.Windows.Forms.DataGridView Train_Data_View;
        private System.Windows.Forms.Label Train_View_Label;
        private System.Windows.Forms.Label Train_Type_View_Label;
        private System.Windows.Forms.Label idbox;
        private System.Windows.Forms.Label Direction_Label;
        private System.Windows.Forms.TextBox Direction_Text;
        private System.Windows.Forms.Label 번역순;
        private System.Windows.Forms.TextBox Order_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}