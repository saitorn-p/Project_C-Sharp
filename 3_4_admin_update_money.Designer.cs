namespace Project_C_Sharp
{
    partial class Form17
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
            this.dataorder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checking = new System.Windows.Forms.RadioButton();
            this.not_paid = new System.Windows.Forms.RadioButton();
            this.finished = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tbupdate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.beforeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataorder.Location = new System.Drawing.Point(134, 156);
            this.dataorder.Name = "dataorder";
            this.dataorder.RowHeadersWidth = 62;
            this.dataorder.RowTemplate.Height = 28;
            this.dataorder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataorder.Size = new System.Drawing.Size(730, 258);
            this.dataorder.TabIndex = 25;
            this.dataorder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataorder_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(756, 60);
            this.label1.TabIndex = 26;
            this.label1.Text = "UPDATE PAYMENT STATUS εїз ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.checking);
            this.groupBox1.Controls.Add(this.not_paid);
            this.groupBox1.Controls.Add(this.finished);
            this.groupBox1.Font = new System.Drawing.Font("Moji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(92, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 223);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เลือกสถานะ";
            // 
            // checking
            // 
            this.checking.AutoSize = true;
            this.checking.Location = new System.Drawing.Point(42, 54);
            this.checking.Name = "checking";
            this.checking.Size = new System.Drawing.Size(93, 42);
            this.checking.TabIndex = 4;
            this.checking.TabStop = true;
            this.checking.Text = "ยกเลิก";
            this.checking.UseVisualStyleBackColor = true;
            this.checking.CheckedChanged += new System.EventHandler(this.checking_CheckedChanged_1);
            // 
            // not_paid
            // 
            this.not_paid.AutoSize = true;
            this.not_paid.Location = new System.Drawing.Point(42, 102);
            this.not_paid.Name = "not_paid";
            this.not_paid.Size = new System.Drawing.Size(150, 42);
            this.not_paid.TabIndex = 2;
            this.not_paid.TabStop = true;
            this.not_paid.Text = "ยังไม่ชำระเงิน\r\n";
            this.not_paid.UseVisualStyleBackColor = true;
            this.not_paid.CheckedChanged += new System.EventHandler(this.not_paid_CheckedChanged);
            // 
            // finished
            // 
            this.finished.AutoSize = true;
            this.finished.Location = new System.Drawing.Point(42, 150);
            this.finished.Name = "finished";
            this.finished.Size = new System.Drawing.Size(214, 42);
            this.finished.TabIndex = 1;
            this.finished.TabStop = true;
            this.finished.Text = "ชำระเงินเรียบร้อยแล้ว";
            this.finished.UseVisualStyleBackColor = true;
            this.finished.CheckedChanged += new System.EventHandler(this.finished_CheckedChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.updateBtn.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(559, 564);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(295, 54);
            this.updateBtn.TabIndex = 32;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // tbupdate
            // 
            this.tbupdate.Font = new System.Drawing.Font("Moji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbupdate.Location = new System.Drawing.Point(519, 472);
            this.tbupdate.Name = "tbupdate";
            this.tbupdate.Size = new System.Drawing.Size(371, 53);
            this.tbupdate.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(980, 35);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // beforeBtn
            // 
            this.beforeBtn.BackColor = System.Drawing.Color.LightPink;
            this.beforeBtn.BackgroundImage = global::Project_C_Sharp.Properties.Resources.งานนำเสนอสนุก_ๆ_แฟนคลับ_ความชอบหลัก_ลัทธิดิจิทัล_สีชมพูและสีม่วง__3_;
            this.beforeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beforeBtn.Location = new System.Drawing.Point(12, 41);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.Size = new System.Drawing.Size(128, 68);
            this.beforeBtn.TabIndex = 24;
            this.beforeBtn.UseVisualStyleBackColor = false;
            this.beforeBtn.Click += new System.EventHandler(this.beforeBtn_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(978, 694);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.tbupdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataorder);
            this.Controls.Add(this.beforeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "อัพเดตสถานะการชำระเงิน";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataorder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beforeBtn;
        private System.Windows.Forms.DataGridView dataorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton not_paid;
        private System.Windows.Forms.RadioButton finished;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TextBox tbupdate;
        private System.Windows.Forms.RadioButton checking;
    }
}