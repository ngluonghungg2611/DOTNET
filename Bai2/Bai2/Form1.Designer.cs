
namespace Bai2
{
    partial class Form1
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
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.buttonGiai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNghiem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập hệ số b: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập hệ số c: ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(275, 53);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(237, 26);
            this.textBoxb.TabIndex = 1;
            this.textBoxb.TextChanged += new System.EventHandler(this.textBoxb_TextChanged);
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(275, 106);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(237, 26);
            this.textBoxc.TabIndex = 1;
            this.textBoxc.TextChanged += new System.EventHandler(this.textBoxc_TextChanged);
            // 
            // buttonGiai
            // 
            this.buttonGiai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiai.Location = new System.Drawing.Point(81, 167);
            this.buttonGiai.Name = "buttonGiai";
            this.buttonGiai.Size = new System.Drawing.Size(287, 37);
            this.buttonGiai.TabIndex = 2;
            this.buttonGiai.Text = "Giải";
            this.buttonGiai.UseVisualStyleBackColor = true;
            this.buttonGiai.Click += new System.EventHandler(this.buttonGiai_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(392, 167);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(120, 37);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nghiệm là: ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNghiem
            // 
            this.textBoxNghiem.Location = new System.Drawing.Point(275, 241);
            this.textBoxNghiem.Name = "textBoxNghiem";
            this.textBoxNghiem.Size = new System.Drawing.Size(237, 26);
            this.textBoxNghiem.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonGiai);
            this.Controls.Add(this.textBoxNghiem);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc nhất bx + c = 0 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.Button buttonGiai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNghiem;
    }
}

