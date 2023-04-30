namespace GUI
{
    partial class Report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ToExcel = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cb_BookReturn = new System.Windows.Forms.RadioButton();
            this.cb_Reader = new System.Windows.Forms.RadioButton();
            this.cb_BookLate = new System.Windows.Forms.RadioButton();
            this.cb_BorrowBook = new System.Windows.Forms.RadioButton();
            this.btn_Report = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lv_Report = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.lbl_SumNumber = new System.Windows.Forms.Label();
            this.lv_Acc = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 105);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 105);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo thống kê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ToExcel);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.cb_BookReturn);
            this.groupBox1.Controls.Add(this.cb_Reader);
            this.groupBox1.Controls.Add(this.cb_BookLate);
            this.groupBox1.Controls.Add(this.cb_BorrowBook);
            this.groupBox1.Controls.Add(this.btn_Report);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btn_ToExcel
            // 
            this.btn_ToExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ToExcel.Location = new System.Drawing.Point(537, 29);
            this.btn_ToExcel.Name = "btn_ToExcel";
            this.btn_ToExcel.Size = new System.Drawing.Size(169, 51);
            this.btn_ToExcel.TabIndex = 10;
            this.btn_ToExcel.Text = "Xuất file Excel";
            this.btn_ToExcel.UseVisualStyleBackColor = true;
            this.btn_ToExcel.Click += new System.EventHandler(this.btn_ToExcel_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(692, 104);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(117, 51);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // cb_BookReturn
            // 
            this.cb_BookReturn.AutoSize = true;
            this.cb_BookReturn.Location = new System.Drawing.Point(169, 128);
            this.cb_BookReturn.Name = "cb_BookReturn";
            this.cb_BookReturn.Size = new System.Drawing.Size(117, 27);
            this.cb_BookReturn.TabIndex = 8;
            this.cb_BookReturn.TabStop = true;
            this.cb_BookReturn.Text = "Sách đã trả";
            this.cb_BookReturn.UseVisualStyleBackColor = true;
            // 
            // cb_Reader
            // 
            this.cb_Reader.AutoSize = true;
            this.cb_Reader.Location = new System.Drawing.Point(169, 95);
            this.cb_Reader.Name = "cb_Reader";
            this.cb_Reader.Size = new System.Drawing.Size(103, 27);
            this.cb_Reader.TabIndex = 7;
            this.cb_Reader.TabStop = true;
            this.cb_Reader.Text = "Tài khoản";
            this.cb_Reader.UseVisualStyleBackColor = true;
            // 
            // cb_BookLate
            // 
            this.cb_BookLate.AutoSize = true;
            this.cb_BookLate.Location = new System.Drawing.Point(169, 62);
            this.cb_BookLate.Name = "cb_BookLate";
            this.cb_BookLate.Size = new System.Drawing.Size(127, 27);
            this.cb_BookLate.TabIndex = 6;
            this.cb_BookLate.TabStop = true;
            this.cb_BookLate.Text = "Sách trễ hạn";
            this.cb_BookLate.UseVisualStyleBackColor = true;
            // 
            // cb_BorrowBook
            // 
            this.cb_BorrowBook.AutoSize = true;
            this.cb_BorrowBook.Location = new System.Drawing.Point(169, 29);
            this.cb_BorrowBook.Name = "cb_BorrowBook";
            this.cb_BorrowBook.Size = new System.Drawing.Size(194, 27);
            this.cb_BorrowBook.TabIndex = 5;
            this.cb_BorrowBook.TabStop = true;
            this.cb_BorrowBook.Text = "Sách đang cho mượn";
            this.cb_BorrowBook.UseVisualStyleBackColor = true;
            // 
            // btn_Report
            // 
            this.btn_Report.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Report.Location = new System.Drawing.Point(537, 104);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(117, 51);
            this.btn_Report.TabIndex = 4;
            this.btn_Report.Text = "Thống kê";
            this.btn_Report.UseVisualStyleBackColor = true;
            this.btn_Report.Click += new System.EventHandler(this.btn_Report_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 277);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(900, 4);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // lv_Report
            // 
            this.lv_Report.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv_Report.FullRowSelect = true;
            this.lv_Report.GridLines = true;
            this.lv_Report.Location = new System.Drawing.Point(0, 308);
            this.lv_Report.Name = "lv_Report";
            this.lv_Report.Size = new System.Drawing.Size(900, 210);
            this.lv_Report.TabIndex = 3;
            this.lv_Report.UseCompatibleStateImageBehavior = false;
            this.lv_Report.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã sách";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thể loại";
            this.columnHeader4.Width = 135;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày mượn";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày trả";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tình trạng";
            this.columnHeader7.Width = 120;
            // 
            // lbl_SumNumber
            // 
            this.lbl_SumNumber.AutoSize = true;
            this.lbl_SumNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_SumNumber.Location = new System.Drawing.Point(692, 284);
            this.lbl_SumNumber.Name = "lbl_SumNumber";
            this.lbl_SumNumber.Size = new System.Drawing.Size(59, 23);
            this.lbl_SumNumber.TabIndex = 4;
            this.lbl_SumNumber.Text = "label2";
            // 
            // lv_Acc
            // 
            this.lv_Acc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lv_Acc.FullRowSelect = true;
            this.lv_Acc.GridLines = true;
            this.lv_Acc.Location = new System.Drawing.Point(0, 310);
            this.lv_Acc.Name = "lv_Acc";
            this.lv_Acc.Size = new System.Drawing.Size(900, 208);
            this.lv_Acc.TabIndex = 5;
            this.lv_Acc.UseCompatibleStateImageBehavior = false;
            this.lv_Acc.View = System.Windows.Forms.View.Details;
            this.lv_Acc.Visible = false;
            this.lv_Acc.SelectedIndexChanged += new System.EventHandler(this.lv_Acc_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên tài khoản";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Mật khẩu";
            this.columnHeader9.Width = 200;
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(73, 281);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(316, 30);
            this.txtBookName.TabIndex = 6;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 518);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lv_Acc);
            this.Controls.Add(this.lbl_SumNumber);
            this.Controls.Add(this.lv_Report);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button btn_Report;
        private Splitter splitter1;
        private ListView lv_Report;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label lbl_SumNumber;
        private RadioButton cb_BorrowBook;
        private RadioButton cb_BookReturn;
        private RadioButton cb_Reader;
        private RadioButton cb_BookLate;
        private Button btn_Exit;
        private ListView lv_Acc;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button btn_ToExcel;
        private TextBox txtBookName;
    }
}