namespace stajornek10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            lbl1zar1 = new Label();
            lbl1zar2 = new Label();
            label3 = new Label();
            lbl1toplam = new Label();
            btn1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn2 = new Button();
            lbl2toplam = new Label();
            label6 = new Label();
            lbl2zar2 = new Label();
            lbl2zar1 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblkazanan = new Label();
            btntekrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "1. Zar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(188, 31);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "2. Zar:";
            // 
            // lbl1zar1
            // 
            lbl1zar1.AutoSize = true;
            lbl1zar1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1zar1.ForeColor = Color.White;
            lbl1zar1.Location = new Point(108, 31);
            lbl1zar1.Name = "lbl1zar1";
            lbl1zar1.Size = new Size(24, 25);
            lbl1zar1.TabIndex = 2;
            lbl1zar1.Text = "0";
            // 
            // lbl1zar2
            // 
            lbl1zar2.AutoSize = true;
            lbl1zar2.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1zar2.ForeColor = Color.White;
            lbl1zar2.Location = new Point(274, 31);
            lbl1zar2.Name = "lbl1zar2";
            lbl1zar2.Size = new Size(24, 25);
            lbl1zar2.TabIndex = 3;
            lbl1zar2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 4;
            label3.Text = "Toplam Puan:";
            // 
            // lbl1toplam
            // 
            lbl1toplam.AutoSize = true;
            lbl1toplam.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1toplam.ForeColor = Color.White;
            lbl1toplam.Location = new Point(224, 86);
            lbl1toplam.Name = "lbl1toplam";
            lbl1toplam.Size = new Size(24, 25);
            lbl1toplam.TabIndex = 5;
            lbl1toplam.Text = "0";
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gainsboro;
            btn1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(102, 136);
            btn1.Name = "btn1";
            btn1.Size = new Size(146, 39);
            btn1.TabIndex = 6;
            btn1.Text = "Başla";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn1);
            groupBox1.Controls.Add(lbl1toplam);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl1zar2);
            groupBox1.Controls.Add(lbl1zar1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(122, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 195);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "1. Oyuncu";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn2);
            groupBox2.Controls.Add(lbl2toplam);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lbl2zar2);
            groupBox2.Controls.Add(lbl2zar1);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(785, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 195);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "1. Oyuncu";
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gainsboro;
            btn2.Enabled = false;
            btn2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(102, 136);
            btn2.Name = "btn2";
            btn2.Size = new Size(146, 39);
            btn2.TabIndex = 6;
            btn2.Text = "Başla";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // lbl2toplam
            // 
            lbl2toplam.AutoSize = true;
            lbl2toplam.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2toplam.ForeColor = Color.White;
            lbl2toplam.Location = new Point(224, 86);
            lbl2toplam.Name = "lbl2toplam";
            lbl2toplam.Size = new Size(24, 25);
            lbl2toplam.TabIndex = 5;
            lbl2toplam.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 86);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 4;
            label6.Text = "Toplam Puan:";
            // 
            // lbl2zar2
            // 
            lbl2zar2.AutoSize = true;
            lbl2zar2.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2zar2.ForeColor = Color.White;
            lbl2zar2.Location = new Point(274, 31);
            lbl2zar2.Name = "lbl2zar2";
            lbl2zar2.Size = new Size(24, 25);
            lbl2zar2.TabIndex = 3;
            lbl2zar2.Text = "0";
            // 
            // lbl2zar1
            // 
            lbl2zar1.AutoSize = true;
            lbl2zar1.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2zar1.ForeColor = Color.White;
            lbl2zar1.Location = new Point(108, 31);
            lbl2zar1.Name = "lbl2zar1";
            lbl2zar1.Size = new Size(24, 25);
            lbl2zar1.TabIndex = 2;
            lbl2zar1.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(188, 31);
            label9.Name = "label9";
            label9.Size = new Size(80, 25);
            label9.TabIndex = 1;
            label9.Text = "2. Zar:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Schoolbook", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(22, 31);
            label10.Name = "label10";
            label10.Size = new Size(80, 25);
            label10.TabIndex = 0;
            label10.Text = "1. Zar:";
            // 
            // lblkazanan
            // 
            lblkazanan.AutoSize = true;
            lblkazanan.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblkazanan.Location = new Point(456, 377);
            lblkazanan.Name = "lblkazanan";
            lblkazanan.Size = new Size(0, 60);
            lblkazanan.TabIndex = 9;
            // 
            // btntekrar
            // 
            btntekrar.BackColor = Color.Black;
            btntekrar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btntekrar.ForeColor = Color.WhiteSmoke;
            btntekrar.Location = new Point(456, 520);
            btntekrar.Name = "btntekrar";
            btntekrar.Size = new Size(369, 72);
            btntekrar.TabIndex = 7;
            btntekrar.Text = "Tekrar Oyna";
            btntekrar.UseVisualStyleBackColor = false;
            btntekrar.Visible = false;
            btntekrar.Click += btntekrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1259, 631);
            Controls.Add(btntekrar);
            Controls.Add(lblkazanan);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl1zar1;
        private Label lbl1zar2;
        private Label label3;
        private Label lbl1toplam;
        private Button btn1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn2;
        private Label lbl2toplam;
        private Label label6;
        private Label lbl2zar2;
        private Label lbl2zar1;
        private Label label9;
        private Label label10;
        private Label lblkazanan;
        private Button btntekrar;
    }
}