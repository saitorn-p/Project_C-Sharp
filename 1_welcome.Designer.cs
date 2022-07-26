namespace Project_C_Sharp
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
            this.welcome = new System.Windows.Forms.Label();
            this.pre_order = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sellerBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Source Code Pro Semibold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(279, 36);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(456, 120);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "WELCOME";
            // 
            // pre_order
            // 
            this.pre_order.AutoSize = true;
            this.pre_order.BackColor = System.Drawing.Color.White;
            this.pre_order.Font = new System.Drawing.Font("Source Code Pro", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre_order.Location = new System.Drawing.Point(122, 210);
            this.pre_order.Name = "pre_order";
            this.pre_order.Size = new System.Drawing.Size(718, 55);
            this.pre_order.TabIndex = 2;
            this.pre_order.Text = "🏞˚➶ pre-order photo frame";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.sellerBtn);
            this.groupBox1.Controls.Add(this.customerBtn);
            this.groupBox1.Font = new System.Drawing.Font("Moji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(132, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 266);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ꔛ˚ กรุณาเลือกผู้ใช้ * ✿ ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Project_C_Sharp.Properties.Resources.ลูกศร;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(559, 180);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 59);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // sellerBtn
            // 
            this.sellerBtn.BackColor = System.Drawing.Color.Thistle;
            this.sellerBtn.ForeColor = System.Drawing.Color.Black;
            this.sellerBtn.Location = new System.Drawing.Point(181, 167);
            this.sellerBtn.Name = "sellerBtn";
            this.sellerBtn.Size = new System.Drawing.Size(357, 61);
            this.sellerBtn.TabIndex = 1;
            this.sellerBtn.Text = "ผู้ขาย";
            this.sellerBtn.UseVisualStyleBackColor = false;
            this.sellerBtn.Click += new System.EventHandler(this.sellerBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.Color.Thistle;
            this.customerBtn.ForeColor = System.Drawing.Color.Black;
            this.customerBtn.Location = new System.Drawing.Point(181, 75);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(357, 61);
            this.customerBtn.TabIndex = 0;
            this.customerBtn.Text = "ผู้ซื้อ";
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Project_C_Sharp.Properties.Resources.กรอบ_welcome1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pre_order);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "กรุณาเลือกผู้ใช้งาน";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label pre_order;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sellerBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

