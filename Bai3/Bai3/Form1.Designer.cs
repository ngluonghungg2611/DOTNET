
namespace Bai3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.textBoxb = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.buttonGiai = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNghiem1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNghiem2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập hệ số a: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập hệ số b: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập hệ số c: ";
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(261, 106);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(241, 26);
            this.textBoxa.TabIndex = 1;
            this.textBoxa.TextChanged += new System.EventHandler(this.textBoxa_TextChanged);
            // 
            // textBoxb
            // 
            this.textBoxb.Location = new System.Drawing.Point(261, 158);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new System.Drawing.Size(241, 26);
            this.textBoxb.TabIndex = 1;
            this.textBoxb.TextChanged += new System.EventHandler(this.textBoxb_TextChanged);
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(261, 209);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(241, 26);
            this.textBoxc.TabIndex = 1;
            this.textBoxc.TextChanged += new System.EventHandler(this.textBoxc_TextChanged);
            // 
            // buttonGiai
            // 
            this.buttonGiai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGiai.Location = new System.Drawing.Point(70, 273);
            this.buttonGiai.Name = "buttonGiai";
            this.buttonGiai.Size = new System.Drawing.Size(284, 50);
            this.buttonGiai.TabIndex = 2;
            this.buttonGiai.Text = "Giải";
            this.buttonGiai.UseVisualStyleBackColor = true;
            this.buttonGiai.Click += new System.EventHandler(this.buttonGiai_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(400, 273);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(102, 50);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nghiệm thứ 1: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxNghiem1
            // 
            this.textBoxNghiem1.Location = new System.Drawing.Point(261, 397);
            this.textBoxNghiem1.Name = "textBoxNghiem1";
            this.textBoxNghiem1.Size = new System.Drawing.Size(241, 26);
            this.textBoxNghiem1.TabIndex = 1;
            this.textBoxNghiem1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nghiệm thứ 2: ";
            // 
            // textBoxNghiem2
            // 
            this.textBoxNghiem2.Location = new System.Drawing.Point(261, 450);
            this.textBoxNghiem2.Name = "textBoxNghiem2";
            this.textBoxNghiem2.Size = new System.Drawing.Size(241, 26);
            this.textBoxNghiem2.TabIndex = 1;
            this.textBoxNghiem2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(613, 530);
            this.ControlBox = false;
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonGiai);
            this.Controls.Add(this.textBoxNghiem2);
            this.Controls.Add(this.textBoxNghiem1);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxb);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Giải phương trình bậc 2: ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.TextBox textBoxb;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.Button buttonGiai;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNghiem1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNghiem2;
    }
}

