
namespace Bai1
{
    partial class Bai1
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxKQ = new System.Windows.Forms.TextBox();
            this.buttonCong = new System.Windows.Forms.Button();
            this.buttonTru = new System.Windows.Forms.Button();
            this.buttonNhan = new System.Windows.Forms.Button();
            this.buttonChia = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thứ 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập số thứ 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết quả là:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(378, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(378, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxKQ
            // 
            this.textBoxKQ.Location = new System.Drawing.Point(378, 181);
            this.textBoxKQ.Name = "textBoxKQ";
            this.textBoxKQ.Size = new System.Drawing.Size(239, 26);
            this.textBoxKQ.TabIndex = 1;
            this.textBoxKQ.TextChanged += new System.EventHandler(this.textBoxKQ_TextChanged);
            // 
            // buttonCong
            // 
            this.buttonCong.Location = new System.Drawing.Point(35, 278);
            this.buttonCong.Name = "buttonCong";
            this.buttonCong.Size = new System.Drawing.Size(103, 65);
            this.buttonCong.TabIndex = 3;
            this.buttonCong.Text = "+";
            this.buttonCong.UseVisualStyleBackColor = true;
            this.buttonCong.Click += new System.EventHandler(this.buttonCong_Click);
            // 
            // buttonTru
            // 
            this.buttonTru.Location = new System.Drawing.Point(193, 278);
            this.buttonTru.Name = "buttonTru";
            this.buttonTru.Size = new System.Drawing.Size(103, 65);
            this.buttonTru.TabIndex = 3;
            this.buttonTru.Text = "-";
            this.buttonTru.UseVisualStyleBackColor = true;
            this.buttonTru.Click += new System.EventHandler(this.buttonTru_Click);
            // 
            // buttonNhan
            // 
            this.buttonNhan.Location = new System.Drawing.Point(336, 278);
            this.buttonNhan.Name = "buttonNhan";
            this.buttonNhan.Size = new System.Drawing.Size(103, 65);
            this.buttonNhan.TabIndex = 3;
            this.buttonNhan.Text = "*";
            this.buttonNhan.UseVisualStyleBackColor = true;
            this.buttonNhan.Click += new System.EventHandler(this.buttonNhan_Click);
            // 
            // buttonChia
            // 
            this.buttonChia.Location = new System.Drawing.Point(490, 278);
            this.buttonChia.Name = "buttonChia";
            this.buttonChia.Size = new System.Drawing.Size(103, 65);
            this.buttonChia.TabIndex = 3;
            this.buttonChia.Text = "/";
            this.buttonChia.UseVisualStyleBackColor = true;
            this.buttonChia.Click += new System.EventHandler(this.buttonChia_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(645, 278);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(103, 65);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonChia);
            this.Controls.Add(this.buttonNhan);
            this.Controls.Add(this.buttonTru);
            this.Controls.Add(this.buttonCong);
            this.Controls.Add(this.textBoxKQ);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Các phép toán số học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxKQ;
        private System.Windows.Forms.Button buttonCong;
        private System.Windows.Forms.Button buttonTru;
        private System.Windows.Forms.Button buttonNhan;
        private System.Windows.Forms.Button buttonChia;
        private System.Windows.Forms.Button buttonXoa;
    }
}

