namespace Sneaker_Shop
{
    partial class Login
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSneakers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(93, 53);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 27);
            this.tbName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "บันทึก";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(93, 102);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(125, 27);
            this.tbLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "นามสกุล";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(93, 152);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(125, 27);
            this.tbMail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "อีเมล";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(93, 198);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(125, 27);
            this.tbPhone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "เบอร์โทร";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(93, 245);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(125, 27);
            this.tbAge.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "อายุ";
            // 
            // cbbSneakers
            // 
            this.cbbSneakers.FormattingEnabled = true;
            this.cbbSneakers.Items.AddRange(new object[] {
            "Air Jordan1 x Off White",
            "Nike PG 3 NASA",
            "Nike Air Zoom Pegasus 39",
            "Nike Jordan Why Noy zero.4 PF"});
            this.cbbSneakers.Location = new System.Drawing.Point(252, 75);
            this.cbbSneakers.Name = "cbbSneakers";
            this.cbbSneakers.Size = new System.Drawing.Size(234, 28);
            this.cbbSneakers.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(252, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "เลือกสินค้า";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 325);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbbSneakers);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "ผู้ซื้อ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Button button1;
        private TextBox tbLastName;
        private Label label2;
        private TextBox tbMail;
        private Label label3;
        private TextBox tbPhone;
        private Label label4;
        private TextBox tbAge;
        private Label label5;
        private ComboBox cbbSneakers;
        private Label label8;
    }
}