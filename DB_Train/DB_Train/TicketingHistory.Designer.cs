namespace DB_Train
{
    partial class TicketingHistory
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
            this.History_View = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Train_Text = new System.Windows.Forms.Label();
            this.Direction_Text = new System.Windows.Forms.Label();
            this.Depart_Text = new System.Windows.Forms.Label();
            this.Arrival_Text = new System.Windows.Forms.Label();
            this.Train_Type_Text = new System.Windows.Forms.Label();
            this.Seat_Text = new System.Windows.Forms.Label();
            this.Pay_Text = new System.Windows.Forms.Label();
            this.Price_Text = new System.Windows.Forms.Label();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Depart_Station_Text = new System.Windows.Forms.Label();
            this.Arrival_Station_Text = new System.Windows.Forms.Label();
            this.Order_Text = new System.Windows.Forms.Label();
            this.예매번호 = new System.Windows.Forms.Label();
            this.Ticketing_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Collection_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.History_View)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // History_View
            // 
            this.History_View.AllowUserToAddRows = false;
            this.History_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.History_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.History_View.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.History_View.Location = new System.Drawing.Point(12, 12);
            this.History_View.Name = "History_View";
            this.History_View.RowTemplate.Height = 23;
            this.History_View.Size = new System.Drawing.Size(818, 150);
            this.History_View.TabIndex = 2;
            this.History_View.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.History_View_Cellclick);
            this.History_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.History_View_Cellclick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(19, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "열차번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(42, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "방향 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "출발시간 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(24, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "도착시간 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(19, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "열차종류 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(43, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "좌석 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(12, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "결제수단 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(40, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "요금 :";
            // 
            // Train_Text
            // 
            this.Train_Text.AutoSize = true;
            this.Train_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Text.Location = new System.Drawing.Point(123, 207);
            this.Train_Text.Name = "Train_Text";
            this.Train_Text.Size = new System.Drawing.Size(49, 18);
            this.Train_Text.TabIndex = 9;
            this.Train_Text.Text = "label9";
            // 
            // Direction_Text
            // 
            this.Direction_Text.AutoSize = true;
            this.Direction_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Direction_Text.Location = new System.Drawing.Point(122, 236);
            this.Direction_Text.Name = "Direction_Text";
            this.Direction_Text.Size = new System.Drawing.Size(56, 18);
            this.Direction_Text.TabIndex = 10;
            this.Direction_Text.Text = "label10";
            // 
            // Depart_Text
            // 
            this.Depart_Text.AutoSize = true;
            this.Depart_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Text.Location = new System.Drawing.Point(121, 326);
            this.Depart_Text.Name = "Depart_Text";
            this.Depart_Text.Size = new System.Drawing.Size(52, 18);
            this.Depart_Text.TabIndex = 11;
            this.Depart_Text.Text = "label11";
            // 
            // Arrival_Text
            // 
            this.Arrival_Text.AutoSize = true;
            this.Arrival_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Text.Location = new System.Drawing.Point(119, 355);
            this.Arrival_Text.Name = "Arrival_Text";
            this.Arrival_Text.Size = new System.Drawing.Size(55, 18);
            this.Arrival_Text.TabIndex = 12;
            this.Arrival_Text.Text = "label12";
            // 
            // Train_Type_Text
            // 
            this.Train_Type_Text.AutoSize = true;
            this.Train_Type_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Train_Type_Text.Location = new System.Drawing.Point(119, 384);
            this.Train_Type_Text.Name = "Train_Type_Text";
            this.Train_Type_Text.Size = new System.Drawing.Size(55, 18);
            this.Train_Type_Text.TabIndex = 13;
            this.Train_Type_Text.Text = "label13";
            // 
            // Seat_Text
            // 
            this.Seat_Text.AutoSize = true;
            this.Seat_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Seat_Text.Location = new System.Drawing.Point(119, 412);
            this.Seat_Text.Name = "Seat_Text";
            this.Seat_Text.Size = new System.Drawing.Size(56, 18);
            this.Seat_Text.TabIndex = 14;
            this.Seat_Text.Text = "label14";
            // 
            // Pay_Text
            // 
            this.Pay_Text.AutoSize = true;
            this.Pay_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Pay_Text.Location = new System.Drawing.Point(118, 440);
            this.Pay_Text.Name = "Pay_Text";
            this.Pay_Text.Size = new System.Drawing.Size(55, 18);
            this.Pay_Text.TabIndex = 15;
            this.Pay_Text.Text = "label15";
            // 
            // Price_Text
            // 
            this.Price_Text.AutoSize = true;
            this.Price_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Price_Text.Location = new System.Drawing.Point(117, 467);
            this.Price_Text.Name = "Price_Text";
            this.Price_Text.Size = new System.Drawing.Size(55, 18);
            this.Price_Text.TabIndex = 16;
            this.Price_Text.Text = "label16";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cancel_btn.Location = new System.Drawing.Point(653, 440);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(177, 59);
            this.Cancel_btn.TabIndex = 17;
            this.Cancel_btn.Text = "예매 취소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // idbox
            // 
            this.idbox.AutoSize = true;
            this.idbox.Location = new System.Drawing.Point(786, 206);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(38, 12);
            this.idbox.TabIndex = 18;
            this.idbox.Text = "label9";
            this.idbox.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(30, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "출발역 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(30, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "도착역 :";
            // 
            // Depart_Station_Text
            // 
            this.Depart_Station_Text.AutoSize = true;
            this.Depart_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Depart_Station_Text.Location = new System.Drawing.Point(122, 265);
            this.Depart_Station_Text.Name = "Depart_Station_Text";
            this.Depart_Station_Text.Size = new System.Drawing.Size(52, 18);
            this.Depart_Station_Text.TabIndex = 21;
            this.Depart_Station_Text.Text = "label11";
            // 
            // Arrival_Station_Text
            // 
            this.Arrival_Station_Text.AutoSize = true;
            this.Arrival_Station_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Arrival_Station_Text.Location = new System.Drawing.Point(122, 294);
            this.Arrival_Station_Text.Name = "Arrival_Station_Text";
            this.Arrival_Station_Text.Size = new System.Drawing.Size(55, 18);
            this.Arrival_Station_Text.TabIndex = 22;
            this.Arrival_Station_Text.Text = "label12";
            // 
            // Order_Text
            // 
            this.Order_Text.AutoSize = true;
            this.Order_Text.Location = new System.Drawing.Point(786, 180);
            this.Order_Text.Name = "Order_Text";
            this.Order_Text.Size = new System.Drawing.Size(44, 12);
            this.Order_Text.TabIndex = 23;
            this.Order_Text.Text = "label11";
            this.Order_Text.Visible = false;
            // 
            // 예매번호
            // 
            this.예매번호.AutoSize = true;
            this.예매번호.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.예매번호.Location = new System.Drawing.Point(19, 180);
            this.예매번호.Name = "예매번호";
            this.예매번호.Size = new System.Drawing.Size(72, 18);
            this.예매번호.TabIndex = 24;
            this.예매번호.Text = "예매번호 :";
            // 
            // Ticketing_Text
            // 
            this.Ticketing_Text.AutoSize = true;
            this.Ticketing_Text.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ticketing_Text.Location = new System.Drawing.Point(123, 180);
            this.Ticketing_Text.Name = "Ticketing_Text";
            this.Ticketing_Text.Size = new System.Drawing.Size(55, 18);
            this.Ticketing_Text.TabIndex = 25;
            this.Ticketing_Text.Text = "label12";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Location = new System.Drawing.Point(12, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 331);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Collection_btn);
            this.panel2.Location = new System.Drawing.Point(2, -7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 546);
            this.panel2.TabIndex = 27;
            // 
            // Collection_btn
            // 
            this.Collection_btn.Font = new System.Drawing.Font("배달의민족 한나체 Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Collection_btn.Location = new System.Drawing.Point(446, 447);
            this.Collection_btn.Name = "Collection_btn";
            this.Collection_btn.Size = new System.Drawing.Size(177, 59);
            this.Collection_btn.TabIndex = 28;
            this.Collection_btn.Text = "예매 수정";
            this.Collection_btn.UseVisualStyleBackColor = true;
            this.Collection_btn.Click += new System.EventHandler(this.Collection_btn_Click);
            // 
            // TicketingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 536);
            this.Controls.Add(this.Ticketing_Text);
            this.Controls.Add(this.예매번호);
            this.Controls.Add(this.Order_Text);
            this.Controls.Add(this.Arrival_Station_Text);
            this.Controls.Add(this.Depart_Station_Text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Price_Text);
            this.Controls.Add(this.Pay_Text);
            this.Controls.Add(this.Seat_Text);
            this.Controls.Add(this.Train_Type_Text);
            this.Controls.Add(this.Arrival_Text);
            this.Controls.Add(this.Depart_Text);
            this.Controls.Add(this.Direction_Text);
            this.Controls.Add(this.Train_Text);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.History_View);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TicketingHistory";
            this.Text = "TicketingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.History_View)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView History_View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Train_Text;
        private System.Windows.Forms.Label Direction_Text;
        private System.Windows.Forms.Label Depart_Text;
        private System.Windows.Forms.Label Arrival_Text;
        private System.Windows.Forms.Label Train_Type_Text;
        private System.Windows.Forms.Label Seat_Text;
        private System.Windows.Forms.Label Pay_Text;
        private System.Windows.Forms.Label Price_Text;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label idbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Depart_Station_Text;
        private System.Windows.Forms.Label Arrival_Station_Text;
        private System.Windows.Forms.Label Order_Text;
        private System.Windows.Forms.Label 예매번호;
        private System.Windows.Forms.Label Ticketing_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Collection_btn;
    }
}