namespace WinForms_3
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
            this.gBox_benzin = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_benzinSonMebleg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mebleg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_litr = new System.Windows.Forms.TextBox();
            this.gBox_tip = new System.Windows.Forms.GroupBox();
            this.rBtn_mebleg = new System.Windows.Forms.RadioButton();
            this.rBtn_litr = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_benzin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBox_benzin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox_kafe = new System.Windows.Forms.GroupBox();
            this.gBox_kafeSonMebleg = new System.Windows.Forms.GroupBox();
            this.lbl_kafeSonMebleg = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kolaSay = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cBox_kola = new System.Windows.Forms.CheckBox();
            this.txt_kartofSay = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cBox_kartof = new System.Windows.Forms.CheckBox();
            this.txt_hamburgerSay = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cBox_hamburger = new System.Windows.Forms.CheckBox();
            this.txt_hotdoqSay = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_hotdoq = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_yekunMebleg = new System.Windows.Forms.Label();
            this.gBox_benzin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBox_tip.SuspendLayout();
            this.gBox_kafe.SuspendLayout();
            this.gBox_kafeSonMebleg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_benzin
            // 
            this.gBox_benzin.Controls.Add(this.groupBox1);
            this.gBox_benzin.Controls.Add(this.label5);
            this.gBox_benzin.Controls.Add(this.txt_mebleg);
            this.gBox_benzin.Controls.Add(this.label4);
            this.gBox_benzin.Controls.Add(this.txt_litr);
            this.gBox_benzin.Controls.Add(this.gBox_tip);
            this.gBox_benzin.Controls.Add(this.label3);
            this.gBox_benzin.Controls.Add(this.txt_benzin);
            this.gBox_benzin.Controls.Add(this.label2);
            this.gBox_benzin.Controls.Add(this.cBox_benzin);
            this.gBox_benzin.Controls.Add(this.label1);
            this.gBox_benzin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBox_benzin.Location = new System.Drawing.Point(12, 12);
            this.gBox_benzin.Name = "gBox_benzin";
            this.gBox_benzin.Size = new System.Drawing.Size(278, 295);
            this.gBox_benzin.TabIndex = 0;
            this.gBox_benzin.TabStop = false;
            this.gBox_benzin.Text = "Benzin";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_benzinSonMebleg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 84);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son Mebleg";
            // 
            // lbl_benzinSonMebleg
            // 
            this.lbl_benzinSonMebleg.AutoSize = true;
            this.lbl_benzinSonMebleg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_benzinSonMebleg.Location = new System.Drawing.Point(94, 16);
            this.lbl_benzinSonMebleg.Name = "lbl_benzinSonMebleg";
            this.lbl_benzinSonMebleg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_benzinSonMebleg.Size = new System.Drawing.Size(90, 65);
            this.lbl_benzinSonMebleg.TabIndex = 1;
            this.lbl_benzinSonMebleg.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(220, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "AZN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(239, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "AZN";
            // 
            // txt_mebleg
            // 
            this.txt_mebleg.Location = new System.Drawing.Point(140, 163);
            this.txt_mebleg.Name = "txt_mebleg";
            this.txt_mebleg.ReadOnly = true;
            this.txt_mebleg.Size = new System.Drawing.Size(93, 23);
            this.txt_mebleg.TabIndex = 9;
            this.txt_mebleg.Text = "0";
            this.txt_mebleg.TextChanged += new System.EventHandler(this.txt_mebleg_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(239, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Litr";
            // 
            // txt_litr
            // 
            this.txt_litr.Location = new System.Drawing.Point(140, 135);
            this.txt_litr.Name = "txt_litr";
            this.txt_litr.Size = new System.Drawing.Size(93, 23);
            this.txt_litr.TabIndex = 7;
            this.txt_litr.Text = "0";
            this.txt_litr.TextChanged += new System.EventHandler(this.txt_litr_TextChanged);
            // 
            // gBox_tip
            // 
            this.gBox_tip.Controls.Add(this.rBtn_mebleg);
            this.gBox_tip.Controls.Add(this.rBtn_litr);
            this.gBox_tip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gBox_tip.Location = new System.Drawing.Point(6, 117);
            this.gBox_tip.Name = "gBox_tip";
            this.gBox_tip.Size = new System.Drawing.Size(128, 81);
            this.gBox_tip.TabIndex = 6;
            this.gBox_tip.TabStop = false;
            // 
            // rBtn_mebleg
            // 
            this.rBtn_mebleg.AutoSize = true;
            this.rBtn_mebleg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtn_mebleg.Location = new System.Drawing.Point(6, 47);
            this.rBtn_mebleg.Name = "rBtn_mebleg";
            this.rBtn_mebleg.Size = new System.Drawing.Size(83, 19);
            this.rBtn_mebleg.TabIndex = 1;
            this.rBtn_mebleg.Text = "Mebleg ile";
            this.rBtn_mebleg.UseVisualStyleBackColor = false;
            // 
            // rBtn_litr
            // 
            this.rBtn_litr.AutoSize = true;
            this.rBtn_litr.Checked = true;
            this.rBtn_litr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rBtn_litr.Location = new System.Drawing.Point(6, 22);
            this.rBtn_litr.Name = "rBtn_litr";
            this.rBtn_litr.Size = new System.Drawing.Size(60, 19);
            this.rBtn_litr.TabIndex = 0;
            this.rBtn_litr.TabStop = true;
            this.rBtn_litr.Text = "Litr ile";
            this.rBtn_litr.UseVisualStyleBackColor = false;
            this.rBtn_litr.CheckedChanged += new System.EventHandler(this.rBtn_litr_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(239, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "AZN";
            // 
            // txt_benzin
            // 
            this.txt_benzin.Location = new System.Drawing.Point(78, 79);
            this.txt_benzin.Name = "txt_benzin";
            this.txt_benzin.ReadOnly = true;
            this.txt_benzin.Size = new System.Drawing.Size(155, 23);
            this.txt_benzin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qiymet";
            // 
            // cBox_benzin
            // 
            this.cBox_benzin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_benzin.FormattingEnabled = true;
            this.cBox_benzin.Location = new System.Drawing.Point(78, 33);
            this.cBox_benzin.Name = "cBox_benzin";
            this.cBox_benzin.Size = new System.Drawing.Size(194, 23);
            this.cBox_benzin.TabIndex = 2;
            this.cBox_benzin.SelectedIndexChanged += new System.EventHandler(this.cBox_benzin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Benzin";
            // 
            // gBox_kafe
            // 
            this.gBox_kafe.Controls.Add(this.gBox_kafeSonMebleg);
            this.gBox_kafe.Controls.Add(this.txt_kolaSay);
            this.gBox_kafe.Controls.Add(this.textBox4);
            this.gBox_kafe.Controls.Add(this.cBox_kola);
            this.gBox_kafe.Controls.Add(this.txt_kartofSay);
            this.gBox_kafe.Controls.Add(this.textBox3);
            this.gBox_kafe.Controls.Add(this.cBox_kartof);
            this.gBox_kafe.Controls.Add(this.txt_hamburgerSay);
            this.gBox_kafe.Controls.Add(this.textBox2);
            this.gBox_kafe.Controls.Add(this.cBox_hamburger);
            this.gBox_kafe.Controls.Add(this.txt_hotdoqSay);
            this.gBox_kafe.Controls.Add(this.textBox1);
            this.gBox_kafe.Controls.Add(this.label8);
            this.gBox_kafe.Controls.Add(this.label7);
            this.gBox_kafe.Controls.Add(this.cBox_hotdoq);
            this.gBox_kafe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gBox_kafe.Location = new System.Drawing.Point(296, 12);
            this.gBox_kafe.Name = "gBox_kafe";
            this.gBox_kafe.Size = new System.Drawing.Size(278, 295);
            this.gBox_kafe.TabIndex = 1;
            this.gBox_kafe.TabStop = false;
            this.gBox_kafe.Text = "Mini-Kafe";
            // 
            // gBox_kafeSonMebleg
            // 
            this.gBox_kafeSonMebleg.Controls.Add(this.lbl_kafeSonMebleg);
            this.gBox_kafeSonMebleg.Controls.Add(this.label10);
            this.gBox_kafeSonMebleg.Location = new System.Drawing.Point(6, 205);
            this.gBox_kafeSonMebleg.Name = "gBox_kafeSonMebleg";
            this.gBox_kafeSonMebleg.Size = new System.Drawing.Size(259, 84);
            this.gBox_kafeSonMebleg.TabIndex = 12;
            this.gBox_kafeSonMebleg.TabStop = false;
            this.gBox_kafeSonMebleg.Text = "Son Mebleg";
            // 
            // lbl_kafeSonMebleg
            // 
            this.lbl_kafeSonMebleg.AutoSize = true;
            this.lbl_kafeSonMebleg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_kafeSonMebleg.Location = new System.Drawing.Point(94, 16);
            this.lbl_kafeSonMebleg.Name = "lbl_kafeSonMebleg";
            this.lbl_kafeSonMebleg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_kafeSonMebleg.Size = new System.Drawing.Size(90, 65);
            this.lbl_kafeSonMebleg.TabIndex = 1;
            this.lbl_kafeSonMebleg.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(220, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "AZN";
            // 
            // txt_kolaSay
            // 
            this.txt_kolaSay.Location = new System.Drawing.Point(194, 134);
            this.txt_kolaSay.Mask = "00";
            this.txt_kolaSay.Name = "txt_kolaSay";
            this.txt_kolaSay.ReadOnly = true;
            this.txt_kolaSay.Size = new System.Drawing.Size(53, 23);
            this.txt_kolaSay.TabIndex = 13;
            this.txt_kolaSay.ValidatingType = typeof(int);
            this.txt_kolaSay.TextChanged += new System.EventHandler(this.sayTextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(53, 23);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "4.40";
            // 
            // cBox_kola
            // 
            this.cBox_kola.AutoSize = true;
            this.cBox_kola.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_kola.Location = new System.Drawing.Point(6, 134);
            this.cBox_kola.Name = "cBox_kola";
            this.cBox_kola.Size = new System.Drawing.Size(89, 21);
            this.cBox_kola.TabIndex = 11;
            this.cBox_kola.Text = "Koka-Kola";
            this.cBox_kola.UseVisualStyleBackColor = true;
            this.cBox_kola.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // txt_kartofSay
            // 
            this.txt_kartofSay.Location = new System.Drawing.Point(194, 105);
            this.txt_kartofSay.Mask = "00";
            this.txt_kartofSay.Name = "txt_kartofSay";
            this.txt_kartofSay.ReadOnly = true;
            this.txt_kartofSay.Size = new System.Drawing.Size(53, 23);
            this.txt_kartofSay.TabIndex = 10;
            this.txt_kartofSay.ValidatingType = typeof(int);
            this.txt_kartofSay.TextChanged += new System.EventHandler(this.sayTextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(53, 23);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "7.20";
            // 
            // cBox_kartof
            // 
            this.cBox_kartof.AutoSize = true;
            this.cBox_kartof.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_kartof.Location = new System.Drawing.Point(6, 105);
            this.cBox_kartof.Name = "cBox_kartof";
            this.cBox_kartof.Size = new System.Drawing.Size(85, 21);
            this.cBox_kartof.TabIndex = 8;
            this.cBox_kartof.Text = "Kartof-Fri";
            this.cBox_kartof.UseVisualStyleBackColor = true;
            this.cBox_kartof.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // txt_hamburgerSay
            // 
            this.txt_hamburgerSay.Location = new System.Drawing.Point(194, 76);
            this.txt_hamburgerSay.Mask = "00";
            this.txt_hamburgerSay.Name = "txt_hamburgerSay";
            this.txt_hamburgerSay.ReadOnly = true;
            this.txt_hamburgerSay.Size = new System.Drawing.Size(53, 23);
            this.txt_hamburgerSay.TabIndex = 7;
            this.txt_hamburgerSay.ValidatingType = typeof(int);
            this.txt_hamburgerSay.TextChanged += new System.EventHandler(this.sayTextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(53, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "5.40";
            // 
            // cBox_hamburger
            // 
            this.cBox_hamburger.AutoSize = true;
            this.cBox_hamburger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_hamburger.Location = new System.Drawing.Point(6, 76);
            this.cBox_hamburger.Name = "cBox_hamburger";
            this.cBox_hamburger.Size = new System.Drawing.Size(97, 21);
            this.cBox_hamburger.TabIndex = 5;
            this.cBox_hamburger.Text = "Hamburger";
            this.cBox_hamburger.UseVisualStyleBackColor = true;
            this.cBox_hamburger.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // txt_hotdoqSay
            // 
            this.txt_hotdoqSay.Location = new System.Drawing.Point(194, 45);
            this.txt_hotdoqSay.Mask = "00";
            this.txt_hotdoqSay.Name = "txt_hotdoqSay";
            this.txt_hotdoqSay.ReadOnly = true;
            this.txt_hotdoqSay.Size = new System.Drawing.Size(53, 23);
            this.txt_hotdoqSay.TabIndex = 4;
            this.txt_hotdoqSay.ValidatingType = typeof(int);
            this.txt_hotdoqSay.TextChanged += new System.EventHandler(this.sayTextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(53, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "4.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(206, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Say";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(116, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Qiymet";
            // 
            // cBox_hotdoq
            // 
            this.cBox_hotdoq.AutoSize = true;
            this.cBox_hotdoq.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cBox_hotdoq.Location = new System.Drawing.Point(6, 45);
            this.cBox_hotdoq.Name = "cBox_hotdoq";
            this.cBox_hotdoq.Size = new System.Drawing.Size(80, 21);
            this.cBox_hotdoq.TabIndex = 0;
            this.cBox_hotdoq.Text = "Hot-Doq";
            this.cBox_hotdoq.UseVisualStyleBackColor = true;
            this.cBox_hotdoq.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pay);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbl_yekunMebleg);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yekun Mebleg";
            // 
            // btn_pay
            // 
            this.btn_pay.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pay.Location = new System.Drawing.Point(140, 24);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(147, 78);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Ode";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WinForms_3.Properties.Resources.money_emoji;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(26, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 80);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(510, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "AZN";
            // 
            // lbl_yekunMebleg
            // 
            this.lbl_yekunMebleg.AutoSize = true;
            this.lbl_yekunMebleg.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_yekunMebleg.Location = new System.Drawing.Point(383, 16);
            this.lbl_yekunMebleg.Name = "lbl_yekunMebleg";
            this.lbl_yekunMebleg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_yekunMebleg.Size = new System.Drawing.Size(121, 86);
            this.lbl_yekunMebleg.TabIndex = 2;
            this.lbl_yekunMebleg.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gBox_kafe);
            this.Controls.Add(this.gBox_benzin);
            this.Name = "Form1";
            this.Text = "BestOil";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox_benzin.ResumeLayout(false);
            this.gBox_benzin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBox_tip.ResumeLayout(false);
            this.gBox_tip.PerformLayout();
            this.gBox_kafe.ResumeLayout(false);
            this.gBox_kafe.PerformLayout();
            this.gBox_kafeSonMebleg.ResumeLayout(false);
            this.gBox_kafeSonMebleg.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gBox_benzin;
        private Label label1;
        private ComboBox cBox_benzin;
        private GroupBox gBox_tip;
        private RadioButton rBtn_mebleg;
        private RadioButton rBtn_litr;
        private Label label3;
        private TextBox txt_benzin;
        private Label label2;
        private Label label4;
        private TextBox txt_litr;
        private Label label5;
        private TextBox txt_mebleg;
        private GroupBox groupBox1;
        private Label lbl_benzinSonMebleg;
        private Label label6;
        private GroupBox gBox_kafe;
        private Label label8;
        private Label label7;
        private CheckBox cBox_hotdoq;
        private MaskedTextBox txt_hotdoqSay;
        private TextBox textBox1;
        private MaskedTextBox txt_kolaSay;
        private TextBox textBox4;
        private CheckBox cBox_kola;
        private MaskedTextBox txt_kartofSay;
        private TextBox textBox3;
        private CheckBox cBox_kartof;
        private MaskedTextBox txt_hamburgerSay;
        private TextBox textBox2;
        private CheckBox cBox_hamburger;
        private GroupBox gBox_kafeSonMebleg;
        private Label lbl_kafeSonMebleg;
        private Label label10;
        private GroupBox groupBox2;
        private Label label11;
        private Label lbl_yekunMebleg;
        private Panel panel1;
        private Button btn_pay;
    }
}