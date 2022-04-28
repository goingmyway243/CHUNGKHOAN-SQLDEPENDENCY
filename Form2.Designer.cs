using System.Windows.Forms;

namespace CHUNGKHOAN
{
    partial class Form2
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
            this.buttonCommit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.comboBoxMuaBan = new System.Windows.Forms.ComboBox();
            this.comboBoxLenh = new System.Windows.Forms.ComboBox();
            this.dataGridViewDat = new System.Windows.Forms.DataGridView();
            this.dataGridViewKhop = new System.Windows.Forms.DataGridView();
            this.numericUpDownKL = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMaCK = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCommit
            // 
            this.buttonCommit.BackColor = System.Drawing.Color.Gold;
            this.buttonCommit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCommit.Location = new System.Drawing.Point(368, 145);
            this.buttonCommit.Name = "buttonCommit";
            this.buttonCommit.Size = new System.Drawing.Size(99, 32);
            this.buttonCommit.TabIndex = 0;
            this.buttonCommit.Text = "Đặt lệnh";
            this.buttonCommit.UseVisualStyleBackColor = false;
            this.buttonCommit.Click += new System.EventHandler(this.buttonCommit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã CK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khối lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(430, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(789, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại lệnh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mua/bán";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.Location = new System.Drawing.Point(584, 145);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(102, 32);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Làm lại";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // comboBoxMuaBan
            // 
            this.comboBoxMuaBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuaBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMuaBan.FormattingEnabled = true;
            this.comboBoxMuaBan.Items.AddRange(new object[] {
            "Mua",
            "Bán"});
            this.comboBoxMuaBan.Location = new System.Drawing.Point(156, 88);
            this.comboBoxMuaBan.Name = "comboBoxMuaBan";
            this.comboBoxMuaBan.Size = new System.Drawing.Size(121, 25);
            this.comboBoxMuaBan.TabIndex = 14;
            // 
            // comboBoxLenh
            // 
            this.comboBoxLenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLenh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLenh.FormattingEnabled = true;
            this.comboBoxLenh.Items.AddRange(new object[] {
            "LO"});
            this.comboBoxLenh.Location = new System.Drawing.Point(866, 39);
            this.comboBoxLenh.Name = "comboBoxLenh";
            this.comboBoxLenh.Size = new System.Drawing.Size(121, 25);
            this.comboBoxLenh.TabIndex = 15;
            // 
            // dataGridViewDat
            // 
            this.dataGridViewDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDat.Location = new System.Drawing.Point(12, 242);
            this.dataGridViewDat.Name = "dataGridViewDat";
            this.dataGridViewDat.RowTemplate.Height = 25;
            this.dataGridViewDat.Size = new System.Drawing.Size(502, 326);
            this.dataGridViewDat.TabIndex = 16;
            // 
            // dataGridViewKhop
            // 
            this.dataGridViewKhop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhop.Location = new System.Drawing.Point(542, 242);
            this.dataGridViewKhop.Name = "dataGridViewKhop";
            this.dataGridViewKhop.RowTemplate.Height = 25;
            this.dataGridViewKhop.Size = new System.Drawing.Size(510, 326);
            this.dataGridViewKhop.TabIndex = 17;
            // 
            // numericUpDownKL
            // 
            this.numericUpDownKL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownKL.Location = new System.Drawing.Point(529, 43);
            this.numericUpDownKL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownKL.Name = "numericUpDownKL";
            this.numericUpDownKL.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownKL.TabIndex = 18;
            // 
            // numericUpDownGia
            // 
            this.numericUpDownGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownGia.Location = new System.Drawing.Point(529, 88);
            this.numericUpDownGia.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownGia.Name = "numericUpDownGia";
            this.numericUpDownGia.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownGia.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(655, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "* 1000 VND";
            // 
            // comboBoxMaCK
            // 
            this.comboBoxMaCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaCK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxMaCK.FormattingEnabled = true;
            this.comboBoxMaCK.Items.AddRange(new object[] {
            "Mua",
            "Bán"});
            this.comboBoxMaCK.Location = new System.Drawing.Point(156, 39);
            this.comboBoxMaCK.Name = "comboBoxMaCK";
            this.comboBoxMaCK.Size = new System.Drawing.Size(121, 25);
            this.comboBoxMaCK.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(187, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lệnh Đặt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(748, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 30);
            this.label8.TabIndex = 23;
            this.label8.Text = "Lệnh Khớp";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxMaCK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownGia);
            this.Controls.Add(this.numericUpDownKL);
            this.Controls.Add(this.dataGridViewKhop);
            this.Controls.Add(this.dataGridViewDat);
            this.Controls.Add(this.comboBoxLenh);
            this.Controls.Add(this.comboBoxMuaBan);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCommit);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCommit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button buttonRefresh;
        private ComboBox comboBoxMuaBan;
        private ComboBox comboBoxLenh;
        private DataGridView dataGridViewDat;
        private DataGridView dataGridViewKhop;
        private NumericUpDown numericUpDownKL;
        private NumericUpDown numericUpDownGia;
        private Label label4;
        private ComboBox comboBoxMaCK;
        private Label label7;
        private Label label8;
    }
}