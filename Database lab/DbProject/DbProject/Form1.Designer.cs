namespace DbProject
{
    partial class STForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.inbutton = new System.Windows.Forms.Button();
            this.StudentRecord = new System.Windows.Forms.DataGridView();
            this.upbutton = new System.Windows.Forms.Button();
            this.delbutton = new System.Windows.Forms.Button();
            this.resbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtRegno = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(423, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtStudentName.Location = new System.Drawing.Point(612, 62);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(266, 28);
            this.txtStudentName.TabIndex = 1;
            // 
            // inbutton
            // 
            this.inbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.inbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inbutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inbutton.Location = new System.Drawing.Point(164, 279);
            this.inbutton.Name = "inbutton";
            this.inbutton.Size = new System.Drawing.Size(96, 45);
            this.inbutton.TabIndex = 2;
            this.inbutton.Text = "Insert";
            this.inbutton.UseVisualStyleBackColor = false;
            this.inbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRecord
            // 
            this.StudentRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.StudentRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecord.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.StudentRecord.Location = new System.Drawing.Point(34, 347);
            this.StudentRecord.Name = "StudentRecord";
            this.StudentRecord.RowHeadersWidth = 51;
            this.StudentRecord.RowTemplate.Height = 24;
            this.StudentRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecord.Size = new System.Drawing.Size(903, 257);
            this.StudentRecord.TabIndex = 3;
            this.StudentRecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataR);
            // 
            // upbutton
            // 
            this.upbutton.BackColor = System.Drawing.Color.Blue;
            this.upbutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.upbutton.Location = new System.Drawing.Point(384, 279);
            this.upbutton.Name = "upbutton";
            this.upbutton.Size = new System.Drawing.Size(96, 45);
            this.upbutton.TabIndex = 4;
            this.upbutton.Text = "Update";
            this.upbutton.UseVisualStyleBackColor = false;
            this.upbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // delbutton
            // 
            this.delbutton.BackColor = System.Drawing.Color.Red;
            this.delbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delbutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delbutton.Location = new System.Drawing.Point(612, 279);
            this.delbutton.Name = "delbutton";
            this.delbutton.Size = new System.Drawing.Size(96, 45);
            this.delbutton.TabIndex = 5;
            this.delbutton.Text = "Delete";
            this.delbutton.UseVisualStyleBackColor = false;
            this.delbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // resbutton
            // 
            this.resbutton.BackColor = System.Drawing.Color.Olive;
            this.resbutton.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resbutton.Location = new System.Drawing.Point(813, 279);
            this.resbutton.Name = "resbutton";
            this.resbutton.Size = new System.Drawing.Size(96, 45);
            this.resbutton.TabIndex = 6;
            this.resbutton.Text = "Reset";
            this.resbutton.UseVisualStyleBackColor = false;
            this.resbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(351, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reg.NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(360, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adress";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(664, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(664, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "F.Name";
            // 
            // txtAdress
            // 
            this.txtAdress.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtAdress.Location = new System.Drawing.Point(447, 193);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(194, 22);
            this.txtAdress.TabIndex = 11;
            // 
            // txtRegno
            // 
            this.txtRegno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegno.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtRegno.Location = new System.Drawing.Point(447, 128);
            this.txtRegno.Name = "txtRegno";
            this.txtRegno.Size = new System.Drawing.Size(194, 28);
            this.txtRegno.TabIndex = 12;
            this.txtRegno.TextChanged += new System.EventHandler(this.txtRegno_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtPhone.Location = new System.Drawing.Point(743, 193);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(194, 22);
            this.txtPhone.TabIndex = 13;
            this.txtPhone.Text = "+92";
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtFatherName.Location = new System.Drawing.Point(743, 128);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(194, 28);
            this.txtFatherName.TabIndex = 14;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Image = global::DbProject.Properties.Resources.r2;
            this.pictureBox5.Location = new System.Drawing.Point(764, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 36);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Image = global::DbProject.Properties.Resources.d2;
            this.pictureBox4.Location = new System.Drawing.Point(564, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 36);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Image = global::DbProject.Properties.Resources.u1;
            this.pictureBox3.Location = new System.Drawing.Point(335, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 36);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Image = global::DbProject.Properties.Resources._in;
            this.pictureBox2.Location = new System.Drawing.Point(114, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DbProject.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(49, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 221);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // STForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(995, 616);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRegno);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resbutton);
            this.Controls.Add(this.delbutton);
            this.Controls.Add(this.upbutton);
            this.Controls.Add(this.StudentRecord);
            this.Controls.Add(this.inbutton);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button inbutton;
        private System.Windows.Forms.DataGridView StudentRecord;
        private System.Windows.Forms.Button upbutton;
        private System.Windows.Forms.Button delbutton;
        private System.Windows.Forms.Button resbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtRegno;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

