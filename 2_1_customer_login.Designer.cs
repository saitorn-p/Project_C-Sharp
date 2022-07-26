namespace Project_C_Sharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.loginBnt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBnt = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.beforeBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.show_password = new System.Windows.Forms.CheckBox();
            this.password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(181, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 53);
            this.label2.TabIndex = 4;
            this.label2.Text = "เบอร์โทรศัพท์";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(181, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "รหัสผ่าน";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(409, 275);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(370, 38);
            this.phone.TabIndex = 6;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // loginBnt
            // 
            this.loginBnt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.loginBnt.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.loginBnt.Location = new System.Drawing.Point(296, 421);
            this.loginBnt.Name = "loginBnt";
            this.loginBnt.Size = new System.Drawing.Size(346, 60);
            this.loginBnt.TabIndex = 8;
            this.loginBnt.Text = "ลงชื่อเข้าใช้";
            this.loginBnt.UseVisualStyleBackColor = false;
            this.loginBnt.Click += new System.EventHandler(this.loginBnt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(200, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 53);
            this.label4.TabIndex = 9;
            this.label4.Text = "หรือ";
            // 
            // registerBnt
            // 
            this.registerBnt.BackColor = System.Drawing.Color.Wheat;
            this.registerBnt.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.registerBnt.Location = new System.Drawing.Point(296, 559);
            this.registerBnt.Name = "registerBnt";
            this.registerBnt.Size = new System.Drawing.Size(346, 59);
            this.registerBnt.TabIndex = 10;
            this.registerBnt.Text = "ลงทะเบียน";
            this.registerBnt.UseVisualStyleBackColor = false;
            this.registerBnt.Click += new System.EventHandler(this.registerBnt_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Red;
            this.resetBtn.Font = new System.Drawing.Font("Moji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(689, 448);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(202, 52);
            this.resetBtn.TabIndex = 12;
            this.resetBtn.Text = "ลืมรหัสผ่าน";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // beforeBtn
            // 
            this.beforeBtn.BackColor = System.Drawing.SystemColors.Info;
            this.beforeBtn.BackgroundImage = global::Project_C_Sharp.Properties.Resources.งานนำเสนอสนุก_ๆ_แฟนคลับ_ความชอบหลัก_ลัทธิดิจิทัล_สีชมพูและสีม่วง__3_;
            this.beforeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beforeBtn.Location = new System.Drawing.Point(12, 65);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.Size = new System.Drawing.Size(128, 68);
            this.beforeBtn.TabIndex = 11;
            this.beforeBtn.UseVisualStyleBackColor = false;
            this.beforeBtn.Click += new System.EventHandler(this.beforeBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Project_C_Sharp.Properties.Resources.กรอบ_login;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(56, 161);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(851, 371);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Pink;
            this.pictureBox2.Location = new System.Drawing.Point(0, 644);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(980, 50);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // show_password
            // 
            this.show_password.AutoSize = true;
            this.show_password.BackColor = System.Drawing.Color.White;
            this.show_password.Font = new System.Drawing.Font("Moji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.show_password.Location = new System.Drawing.Point(723, 394);
            this.show_password.Name = "show_password";
            this.show_password.Size = new System.Drawing.Size(126, 34);
            this.show_password.TabIndex = 13;
            this.show_password.Text = "แสดงรหัสผ่าน";
            this.show_password.UseVisualStyleBackColor = false;
            this.show_password.CheckedChanged += new System.EventHandler(this.show_password_CheckedChanged);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(409, 350);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '✿';
            this.password.Size = new System.Drawing.Size(370, 38);
            this.password.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.password);
            this.Controls.Add(this.show_password);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.beforeBtn);
            this.Controls.Add(this.registerBnt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBnt);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Button loginBnt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerBnt;
        private System.Windows.Forms.Button beforeBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.CheckBox show_password;
        private System.Windows.Forms.TextBox password;
    }
}