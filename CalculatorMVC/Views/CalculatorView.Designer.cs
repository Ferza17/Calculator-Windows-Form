namespace CalculatorMVC.Views {
    partial class CalculatorView {
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
            this.DashboardName = new System.Windows.Forms.Label();
            this.ValueGroup = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Hasil = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nilai2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nilai1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.bagi = new System.Windows.Forms.Button();
            this.kurang = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.ValueGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardName
            // 
            this.DashboardName.AutoSize = true;
            this.DashboardName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardName.Location = new System.Drawing.Point(12, 18);
            this.DashboardName.Name = "DashboardName";
            this.DashboardName.Size = new System.Drawing.Size(269, 37);
            this.DashboardName.TabIndex = 0;
            this.DashboardName.Text = "Kalkulator Sederhana";
            // 
            // ValueGroup
            // 
            this.ValueGroup.Controls.Add(this.textBox3);
            this.ValueGroup.Controls.Add(this.Hasil);
            this.ValueGroup.Controls.Add(this.textBox2);
            this.ValueGroup.Controls.Add(this.nilai2);
            this.ValueGroup.Controls.Add(this.textBox1);
            this.ValueGroup.Controls.Add(this.Nilai1);
            this.ValueGroup.Location = new System.Drawing.Point(12, 58);
            this.ValueGroup.Name = "ValueGroup";
            this.ValueGroup.Size = new System.Drawing.Size(256, 184);
            this.ValueGroup.TabIndex = 1;
            this.ValueGroup.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(64, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Hasil
            // 
            this.Hasil.AutoSize = true;
            this.Hasil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasil.Location = new System.Drawing.Point(3, 137);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(44, 21);
            this.Hasil.TabIndex = 4;
            this.Hasil.Text = "Hasil";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 3;
            // 
            // nilai2
            // 
            this.nilai2.AutoSize = true;
            this.nilai2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilai2.Location = new System.Drawing.Point(6, 72);
            this.nilai2.Name = "nilai2";
            this.nilai2.Size = new System.Drawing.Size(55, 21);
            this.nilai2.TabIndex = 2;
            this.nilai2.Text = "Nilai 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Nilai1
            // 
            this.Nilai1.AutoSize = true;
            this.Nilai1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nilai1.Location = new System.Drawing.Point(6, 33);
            this.Nilai1.Name = "Nilai1";
            this.Nilai1.Size = new System.Drawing.Size(55, 21);
            this.Nilai1.TabIndex = 0;
            this.Nilai1.Text = "Nilai 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.bagi);
            this.groupBox1.Controls.Add(this.kurang);
            this.groupBox1.Controls.Add(this.kali);
            this.groupBox1.Controls.Add(this.tambah);
            this.groupBox1.Location = new System.Drawing.Point(285, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 184);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(6, 123);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(156, 46);
            this.clear.TabIndex = 4;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // bagi
            // 
            this.bagi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagi.Location = new System.Drawing.Point(87, 71);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(75, 46);
            this.bagi.TabIndex = 3;
            this.bagi.Text = ":";
            this.bagi.UseVisualStyleBackColor = true;
            this.bagi.Click += new System.EventHandler(this.bagi_Click);
            // 
            // kurang
            // 
            this.kurang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurang.Location = new System.Drawing.Point(6, 71);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(75, 46);
            this.kurang.TabIndex = 2;
            this.kurang.Text = "-";
            this.kurang.UseVisualStyleBackColor = true;
            this.kurang.Click += new System.EventHandler(this.kurang_Click);
            // 
            // kali
            // 
            this.kali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kali.Location = new System.Drawing.Point(87, 19);
            this.kali.Name = "kali";
            this.kali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kali.Size = new System.Drawing.Size(75, 46);
            this.kali.TabIndex = 1;
            this.kali.Text = "x";
            this.kali.UseVisualStyleBackColor = true;
            this.kali.Click += new System.EventHandler(this.kali_Click);
            // 
            // tambah
            // 
            this.tambah.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(6, 19);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 46);
            this.tambah.TabIndex = 0;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // CalculatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 249);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ValueGroup);
            this.Controls.Add(this.DashboardName);
            this.Name = "CalculatorView";
            this.Text = "CalculatorView";
            this.ValueGroup.ResumeLayout(false);
            this.ValueGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashboardName;
        private System.Windows.Forms.GroupBox ValueGroup;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Hasil;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nilai2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nilai1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Button kurang;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.Button tambah;
    }
}