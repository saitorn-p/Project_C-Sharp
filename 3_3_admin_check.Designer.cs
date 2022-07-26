namespace Project_C_Sharp
{
    partial class Form11
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataorder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_money = new System.Windows.Forms.Button();
            this.update_product = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.beforeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.receiptBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataorder
            // 
            this.dataorder.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Code Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataorder.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Source Code Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataorder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataorder.EnableHeadersVisualStyles = false;
            this.dataorder.Location = new System.Drawing.Point(76, 125);
            this.dataorder.Name = "dataorder";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Moji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataorder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataorder.RowHeadersWidth = 62;
            this.dataorder.RowTemplate.Height = 28;
            this.dataorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataorder.Size = new System.Drawing.Size(822, 225);
            this.dataorder.TabIndex = 0;
            this.dataorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataorder_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "ORDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "UPDATE ";
            // 
            // update_money
            // 
            this.update_money.BackColor = System.Drawing.SystemColors.Info;
            this.update_money.Font = new System.Drawing.Font("Moji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_money.Location = new System.Drawing.Point(173, 496);
            this.update_money.Name = "update_money";
            this.update_money.Size = new System.Drawing.Size(274, 47);
            this.update_money.TabIndex = 6;
            this.update_money.Text = "อัพเดตสถานะการชำระเงิน";
            this.update_money.UseVisualStyleBackColor = false;
            this.update_money.Click += new System.EventHandler(this.update_money_Click);
            // 
            // update_product
            // 
            this.update_product.BackColor = System.Drawing.SystemColors.Info;
            this.update_product.Font = new System.Drawing.Font("Moji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_product.Location = new System.Drawing.Point(535, 496);
            this.update_product.Name = "update_product";
            this.update_product.Size = new System.Drawing.Size(274, 47);
            this.update_product.TabIndex = 7;
            this.update_product.Text = "อัพเดตสถานะสินค้า";
            this.update_product.UseVisualStyleBackColor = false;
            this.update_product.Click += new System.EventHandler(this.update_product_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Linen;
            this.logoutBtn.Font = new System.Drawing.Font("Source Code Pro", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(797, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(169, 47);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // beforeBtn
            // 
            this.beforeBtn.BackColor = System.Drawing.Color.OldLace;
            this.beforeBtn.BackgroundImage = global::Project_C_Sharp.Properties.Resources.งานนำเสนอสนุก_ๆ_แฟนคลับ_ความชอบหลัก_ลัทธิดิจิทัล_สีชมพูและสีม่วง__3_;
            this.beforeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beforeBtn.Location = new System.Drawing.Point(12, 12);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.Size = new System.Drawing.Size(128, 68);
            this.beforeBtn.TabIndex = 23;
            this.beforeBtn.UseVisualStyleBackColor = false;
            this.beforeBtn.Click += new System.EventHandler(this.beforeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_C_Sharp.Properties.Resources.กรอบ_login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(111, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 320);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "RECEIPT";
            // 
            // receiptBtn
            // 
            this.receiptBtn.BackColor = System.Drawing.SystemColors.Info;
            this.receiptBtn.Font = new System.Drawing.Font("Moji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBtn.Location = new System.Drawing.Point(361, 602);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(274, 47);
            this.receiptBtn.TabIndex = 27;
            this.receiptBtn.Text = "พิมพ์ใบเสร็จ";
            this.receiptBtn.UseVisualStyleBackColor = false;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.beforeBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.update_product);
            this.Controls.Add(this.update_money);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "การสั่งซื้อ";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_money;
        private System.Windows.Forms.Button update_product;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button beforeBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button receiptBtn;
    }
}