namespace Project_C_Sharp
{
    partial class Form18
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
            this.beforeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataorder = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checking = new System.Windows.Forms.RadioButton();
            this.preparing = new System.Windows.Forms.RadioButton();
            this.finished = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbupdate = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTracking = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // beforeBtn
            // 
            this.beforeBtn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.beforeBtn.BackgroundImage = global::Project_C_Sharp.Properties.Resources.งานนำเสนอสนุก_ๆ_แฟนคลับ_ความชอบหลัก_ลัทธิดิจิทัล_สีชมพูและสีม่วง__3_;
            this.beforeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beforeBtn.Location = new System.Drawing.Point(8, 42);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.Size = new System.Drawing.Size(128, 68);
            this.beforeBtn.TabIndex = 25;
            this.beforeBtn.UseVisualStyleBackColor = false;
            this.beforeBtn.Click += new System.EventHandler(this.beforeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 60);
            this.label1.TabIndex = 27;
            this.label1.Text = "UPDATE PRODUCT STATUS εїз";
            // 
            // dataorder
            // 
            this.dataorder.BackgroundColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataorder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataorder.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataorder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataorder.EnableHeadersVisualStyles = false;
            this.dataorder.Location = new System.Drawing.Point(125, 172);
            this.dataorder.Name = "dataorder";
            this.dataorder.RowHeadersWidth = 62;
            this.dataorder.RowTemplate.Height = 28;
            this.dataorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataorder.Size = new System.Drawing.Size(730, 258);
            this.dataorder.TabIndex = 28;
            this.dataorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataorder_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.checking);
            this.groupBox1.Controls.Add(this.preparing);
            this.groupBox1.Controls.Add(this.finished);
            this.groupBox1.Font = new System.Drawing.Font("Moji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 223);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกสถานะ";
            // 
            // checking
            // 
            this.checking.AutoSize = true;
            this.checking.Location = new System.Drawing.Point(42, 54);
            this.checking.Name = "checking";
            this.checking.Size = new System.Drawing.Size(147, 42);
            this.checking.TabIndex = 4;
            this.checking.TabStop = true;
            this.checking.Text = "กำลังรอสินค้า";
            this.checking.UseVisualStyleBackColor = true;
            this.checking.CheckedChanged += new System.EventHandler(this.checking_CheckedChanged);
            // 
            // preparing
            // 
            this.preparing.AutoSize = true;
            this.preparing.Location = new System.Drawing.Point(42, 102);
            this.preparing.Name = "preparing";
            this.preparing.Size = new System.Drawing.Size(203, 42);
            this.preparing.TabIndex = 2;
            this.preparing.TabStop = true;
            this.preparing.Text = "กำลังเตรียมการจัดส่ง";
            this.preparing.UseVisualStyleBackColor = true;
            this.preparing.CheckedChanged += new System.EventHandler(this.preparing_CheckedChanged);
            // 
            // finished
            // 
            this.finished.AutoSize = true;
            this.finished.Location = new System.Drawing.Point(42, 150);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(231, 42);
            this.finished.TabIndex = 1;
            this.finished.TabStop = true;
            this.finished.Text = "จัดส่งสินค้าเรียบร้อยแล้ว";
            this.finished.UseVisualStyleBackColor = true;
            this.finished.CheckedChanged += new System.EventHandler(this.finished_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 35);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // tbupdate
            // 
            this.tbupdate.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbupdate.Location = new System.Drawing.Point(512, 466);
            this.tbupdate.Name = "tbupdate";
            this.tbupdate.Size = new System.Drawing.Size(371, 53);
            this.tbupdate.TabIndex = 33;

            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.updateBtn.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(560, 620);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(295, 54);
            this.updateBtn.TabIndex = 34;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Code Pro", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 553);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tracking :";
            // 
            // tbTracking
            // 
            this.tbTracking.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbTracking.Location = new System.Drawing.Point(629, 542);
            this.tbTracking.Name = "tbTracking";
            this.tbTracking.Size = new System.Drawing.Size(288, 53);
            this.tbTracking.TabIndex = 36;
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.tbTracking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tbupdate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataorder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beforeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "อัพเดตสถานะสินค้า";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beforeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataorder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton checking;
        private System.Windows.Forms.RadioButton preparing;
        private System.Windows.Forms.RadioButton finished;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbupdate;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTracking;
    }
}