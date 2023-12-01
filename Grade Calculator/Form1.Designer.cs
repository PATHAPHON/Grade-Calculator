namespace Grade_Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arrayIndex1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbinputidscore = new System.Windows.Forms.TextBox();
            this.tbinputidname = new System.Windows.Forms.TextBox();
            this.tbinputid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.textboxscoremin = new System.Windows.Forms.TextBox();
            this.textboxscoremax = new System.Windows.Forms.TextBox();
            this.textboxnamemin = new System.Windows.Forms.TextBox();
            this.textboxnamemax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxidmin = new System.Windows.Forms.TextBox();
            this.textboxidmax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arrayIndex1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbinputidscore);
            this.groupBox1.Controls.Add(this.tbinputidname);
            this.groupBox1.Controls.Add(this.tbinputid);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "กรอกข้อมูล";
            // 
            // arrayIndex1
            // 
            this.arrayIndex1.Location = new System.Drawing.Point(137, 125);
            this.arrayIndex1.Name = "arrayIndex1";
            this.arrayIndex1.Size = new System.Drawing.Size(75, 23);
            this.arrayIndex1.TabIndex = 6;
            this.arrayIndex1.Text = "บันทึก";
            this.arrayIndex1.UseVisualStyleBackColor = true;
            this.arrayIndex1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "คะแนน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ชื่อนามสกุล";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "รหัสนักศึกษา";
            // 
            // tbinputidscore
            // 
            this.tbinputidscore.Location = new System.Drawing.Point(127, 99);
            this.tbinputidscore.Name = "tbinputidscore";
            this.tbinputidscore.Size = new System.Drawing.Size(100, 20);
            this.tbinputidscore.TabIndex = 2;
            // 
            // tbinputidname
            // 
            this.tbinputidname.Location = new System.Drawing.Point(127, 73);
            this.tbinputidname.Name = "tbinputidname";
            this.tbinputidname.Size = new System.Drawing.Size(100, 20);
            this.tbinputidname.TabIndex = 1;
            // 
            // tbinputid
            // 
            this.tbinputid.Location = new System.Drawing.Point(127, 47);
            this.tbinputid.Name = "tbinputid";
            this.tbinputid.Size = new System.Drawing.Size(100, 20);
            this.tbinputid.TabIndex = 0;
            this.tbinputid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.textboxscoremin);
            this.groupBox2.Controls.Add(this.textboxscoremax);
            this.groupBox2.Controls.Add(this.textboxnamemin);
            this.groupBox2.Controls.Add(this.textboxnamemax);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textboxidmin);
            this.groupBox2.Controls.Add(this.textboxidmax);
            this.groupBox2.Location = new System.Drawing.Point(330, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "กรอกข้อมูล";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(343, 124);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(343, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(237, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(126, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "คะแนนเฉลี่ย";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "คะแนน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ชื่อนามสกุล";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "รหัสนักศึกษา";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(329, 121);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 19;
            this.total.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textboxscoremin
            // 
            this.textboxscoremin.Location = new System.Drawing.Point(329, 92);
            this.textboxscoremin.Name = "textboxscoremin";
            this.textboxscoremin.Size = new System.Drawing.Size(100, 20);
            this.textboxscoremin.TabIndex = 17;
            // 
            // textboxscoremax
            // 
            this.textboxscoremax.Location = new System.Drawing.Point(329, 66);
            this.textboxscoremax.Name = "textboxscoremax";
            this.textboxscoremax.Size = new System.Drawing.Size(100, 20);
            this.textboxscoremax.TabIndex = 16;
            // 
            // textboxnamemin
            // 
            this.textboxnamemin.Location = new System.Drawing.Point(221, 92);
            this.textboxnamemin.Name = "textboxnamemin";
            this.textboxnamemin.Size = new System.Drawing.Size(100, 20);
            this.textboxnamemin.TabIndex = 14;
            // 
            // textboxnamemax
            // 
            this.textboxnamemax.Location = new System.Drawing.Point(221, 66);
            this.textboxnamemax.Name = "textboxnamemax";
            this.textboxnamemax.Size = new System.Drawing.Size(100, 20);
            this.textboxnamemax.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "คะแนนสุงสุด";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "คะแนนตำสุด";
            // 
            // textboxidmin
            // 
            this.textboxidmin.Location = new System.Drawing.Point(115, 92);
            this.textboxidmin.Name = "textboxidmin";
            this.textboxidmin.Size = new System.Drawing.Size(100, 20);
            this.textboxidmin.TabIndex = 8;
            // 
            // textboxidmax
            // 
            this.textboxidmax.Location = new System.Drawing.Point(115, 66);
            this.textboxidmax.Name = "textboxidmax";
            this.textboxidmax.Size = new System.Drawing.Size(100, 20);
            this.textboxidmax.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(100, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(152, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "ปฐพล สร้อยเสนา 663450041-0";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(100, 237);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "อานนท์ แก้วกงพาน 663450180-6";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(100, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "ชูเกียรติ คำมณีจันทร์ 663450174-1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(100, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 34;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button arrayIndex1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbinputidscore;
        private System.Windows.Forms.TextBox tbinputidname;
        private System.Windows.Forms.TextBox tbinputid;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox textboxscoremin;
        private System.Windows.Forms.TextBox textboxscoremax;
        private System.Windows.Forms.TextBox textboxnamemin;
        private System.Windows.Forms.TextBox textboxnamemax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxidmin;
        private System.Windows.Forms.TextBox textboxidmax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}

