namespace PurchaseOrderForm
{
    partial class Purchase
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
            this.rbtn_adm = new System.Windows.Forms.RadioButton();
            this.rbtn_cmg = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_po = new System.Windows.Forms.TextBox();
            this.tbx_pr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_dept = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_supplier = new System.Windows.Forms.ComboBox();
            this.tbx_contact = new System.Windows.Forms.TextBox();
            this.tbx_phone = new System.Windows.Forms.TextBox();
            this.tbx_fax = new System.Windows.Forms.TextBox();
            this.tbx_mobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_tower = new System.Windows.Forms.ComboBox();
            this.tbx_unit = new System.Windows.Forms.TextBox();
            this.tbx_comment = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmb_check = new System.Windows.Forms.ComboBox();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_dp = new System.Windows.Forms.RadioButton();
            this.rbtn_check = new System.Windows.Forms.RadioButton();
            this.rbtn_nonvat = new System.Windows.Forms.RadioButton();
            this.rbtn_vat = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbx_prepare = new System.Windows.Forms.TextBox();
            this.tbx_request = new System.Windows.Forms.TextBox();
            this.tbx_approve = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbx_net = new System.Windows.Forms.TextBox();
            this.tbx_vat = new System.Windows.Forms.TextBox();
            this.tbx_vat_inclusive = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.tbx_dp = new System.Windows.Forms.TextBox();
            this.btn_dp = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_adm
            // 
            this.rbtn_adm.AutoSize = true;
            this.rbtn_adm.Location = new System.Drawing.Point(7, 20);
            this.rbtn_adm.Name = "rbtn_adm";
            this.rbtn_adm.Size = new System.Drawing.Size(54, 17);
            this.rbtn_adm.TabIndex = 0;
            this.rbtn_adm.TabStop = true;
            this.rbtn_adm.Text = "Admin";
            this.rbtn_adm.UseVisualStyleBackColor = true;
            this.rbtn_adm.CheckedChanged += new System.EventHandler(this.rbtn_adm_CheckedChanged);
            // 
            // rbtn_cmg
            // 
            this.rbtn_cmg.AutoSize = true;
            this.rbtn_cmg.Location = new System.Drawing.Point(68, 20);
            this.rbtn_cmg.Name = "rbtn_cmg";
            this.rbtn_cmg.Size = new System.Drawing.Size(49, 17);
            this.rbtn_cmg.TabIndex = 1;
            this.rbtn_cmg.TabStop = true;
            this.rbtn_cmg.Text = "CMG";
            this.rbtn_cmg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_cmg);
            this.groupBox1.Controls.Add(this.rbtn_adm);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "P.O. No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "P.R. No";
            // 
            // tbx_po
            // 
            this.tbx_po.Location = new System.Drawing.Point(381, 19);
            this.tbx_po.Name = "tbx_po";
            this.tbx_po.Size = new System.Drawing.Size(100, 20);
            this.tbx_po.TabIndex = 3;
            // 
            // tbx_pr
            // 
            this.tbx_pr.Location = new System.Drawing.Point(381, 42);
            this.tbx_pr.Name = "tbx_pr";
            this.tbx_pr.Size = new System.Drawing.Size(100, 20);
            this.tbx_pr.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Department";
            // 
            // cmb_dept
            // 
            this.cmb_dept.FormattingEnabled = true;
            this.cmb_dept.Location = new System.Drawing.Point(172, 39);
            this.cmb_dept.Name = "cmb_dept";
            this.cmb_dept.Size = new System.Drawing.Size(121, 21);
            this.cmb_dept.TabIndex = 6;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(730, 38);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(84, 20);
            this.date.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmb_dept);
            this.groupBox2.Controls.Add(this.tbx_po);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbx_pr);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(855, 68);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cmb_supplier
            // 
            this.cmb_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_supplier.FormattingEnabled = true;
            this.cmb_supplier.Location = new System.Drawing.Point(98, 13);
            this.cmb_supplier.Name = "cmb_supplier";
            this.cmb_supplier.Size = new System.Drawing.Size(191, 21);
            this.cmb_supplier.TabIndex = 10;
            // 
            // tbx_contact
            // 
            this.tbx_contact.Location = new System.Drawing.Point(98, 41);
            this.tbx_contact.Name = "tbx_contact";
            this.tbx_contact.Size = new System.Drawing.Size(191, 20);
            this.tbx_contact.TabIndex = 11;
            // 
            // tbx_phone
            // 
            this.tbx_phone.Location = new System.Drawing.Point(98, 68);
            this.tbx_phone.Name = "tbx_phone";
            this.tbx_phone.Size = new System.Drawing.Size(191, 20);
            this.tbx_phone.TabIndex = 12;
            // 
            // tbx_fax
            // 
            this.tbx_fax.Location = new System.Drawing.Point(98, 95);
            this.tbx_fax.Name = "tbx_fax";
            this.tbx_fax.Size = new System.Drawing.Size(191, 20);
            this.tbx_fax.TabIndex = 13;
            // 
            // tbx_mobile
            // 
            this.tbx_mobile.Location = new System.Drawing.Point(98, 122);
            this.tbx_mobile.Name = "tbx_mobile";
            this.tbx_mobile.Size = new System.Drawing.Size(191, 20);
            this.tbx_mobile.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contact Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Mobile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmb_supplier);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbx_contact);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbx_phone);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbx_fax);
            this.groupBox3.Controls.Add(this.tbx_mobile);
            this.groupBox3.Location = new System.Drawing.Point(7, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 151);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Comments/Special Instructions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tower";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(449, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Unit";
            // 
            // cmb_tower
            // 
            this.cmb_tower.FormattingEnabled = true;
            this.cmb_tower.Location = new System.Drawing.Point(370, 32);
            this.cmb_tower.Name = "cmb_tower";
            this.cmb_tower.Size = new System.Drawing.Size(63, 21);
            this.cmb_tower.TabIndex = 24;
            // 
            // tbx_unit
            // 
            this.tbx_unit.Location = new System.Drawing.Point(481, 32);
            this.tbx_unit.Name = "tbx_unit";
            this.tbx_unit.Size = new System.Drawing.Size(63, 20);
            this.tbx_unit.TabIndex = 25;
            // 
            // tbx_comment
            // 
            this.tbx_comment.Location = new System.Drawing.Point(316, 86);
            this.tbx_comment.Multiline = true;
            this.tbx_comment.Name = "tbx_comment";
            this.tbx_comment.Size = new System.Drawing.Size(248, 75);
            this.tbx_comment.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.rbtn_nonvat);
            this.groupBox4.Controls.Add(this.rbtn_vat);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.tbx_comment);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbx_unit);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.cmb_tower);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(12, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(855, 177);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbx_dp);
            this.groupBox5.Controls.Add(this.cmb_check);
            this.groupBox5.Controls.Add(this.rbtn_cash);
            this.groupBox5.Controls.Add(this.rbtn_dp);
            this.groupBox5.Controls.Add(this.rbtn_check);
            this.groupBox5.Location = new System.Drawing.Point(592, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(249, 92);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            // 
            // cmb_check
            // 
            this.cmb_check.FormattingEnabled = true;
            this.cmb_check.Location = new System.Drawing.Point(109, 64);
            this.cmb_check.Name = "cmb_check";
            this.cmb_check.Size = new System.Drawing.Size(134, 21);
            this.cmb_check.TabIndex = 32;
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Location = new System.Drawing.Point(6, 19);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(49, 17);
            this.rbtn_cash.TabIndex = 29;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "Cash";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            // 
            // rbtn_dp
            // 
            this.rbtn_dp.AutoSize = true;
            this.rbtn_dp.Location = new System.Drawing.Point(6, 42);
            this.rbtn_dp.Name = "rbtn_dp";
            this.rbtn_dp.Size = new System.Drawing.Size(93, 17);
            this.rbtn_dp.TabIndex = 31;
            this.rbtn_dp.TabStop = true;
            this.rbtn_dp.Text = "Downpayment";
            this.rbtn_dp.UseVisualStyleBackColor = true;
            // 
            // rbtn_check
            // 
            this.rbtn_check.AutoSize = true;
            this.rbtn_check.Location = new System.Drawing.Point(6, 65);
            this.rbtn_check.Name = "rbtn_check";
            this.rbtn_check.Size = new System.Drawing.Size(56, 17);
            this.rbtn_check.TabIndex = 30;
            this.rbtn_check.TabStop = true;
            this.rbtn_check.Text = "Check";
            this.rbtn_check.UseVisualStyleBackColor = true;
            // 
            // rbtn_nonvat
            // 
            this.rbtn_nonvat.AutoSize = true;
            this.rbtn_nonvat.Location = new System.Drawing.Point(659, 31);
            this.rbtn_nonvat.Name = "rbtn_nonvat";
            this.rbtn_nonvat.Size = new System.Drawing.Size(63, 17);
            this.rbtn_nonvat.TabIndex = 28;
            this.rbtn_nonvat.TabStop = true;
            this.rbtn_nonvat.Text = "Non-vat";
            this.rbtn_nonvat.UseVisualStyleBackColor = true;
            // 
            // rbtn_vat
            // 
            this.rbtn_vat.AutoSize = true;
            this.rbtn_vat.Location = new System.Drawing.Point(592, 31);
            this.rbtn_vat.Name = "rbtn_vat";
            this.rbtn_vat.Size = new System.Drawing.Size(61, 17);
            this.rbtn_vat.TabIndex = 27;
            this.rbtn_vat.TabStop = true;
            this.rbtn_vat.Text = "Vatable";
            this.rbtn_vat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(855, 210);
            this.dataGridView1.TabIndex = 28;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(19, 269);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(100, 269);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 30;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(181, 269);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 31;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 526);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Prepared by";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(178, 526);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Requested by";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(331, 526);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Approved by";
            // 
            // tbx_prepare
            // 
            this.tbx_prepare.Location = new System.Drawing.Point(28, 545);
            this.tbx_prepare.Name = "tbx_prepare";
            this.tbx_prepare.Size = new System.Drawing.Size(147, 20);
            this.tbx_prepare.TabIndex = 35;
            // 
            // tbx_request
            // 
            this.tbx_request.Location = new System.Drawing.Point(181, 545);
            this.tbx_request.Name = "tbx_request";
            this.tbx_request.Size = new System.Drawing.Size(147, 20);
            this.tbx_request.TabIndex = 36;
            // 
            // tbx_approve
            // 
            this.tbx_approve.Location = new System.Drawing.Point(334, 545);
            this.tbx_approve.Name = "tbx_approve";
            this.tbx_approve.Size = new System.Drawing.Size(150, 20);
            this.tbx_approve.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(615, 526);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Net Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(615, 551);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Vat";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(615, 580);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Vat Inclusive";
            // 
            // tbx_net
            // 
            this.tbx_net.Location = new System.Drawing.Point(720, 523);
            this.tbx_net.Name = "tbx_net";
            this.tbx_net.Size = new System.Drawing.Size(147, 20);
            this.tbx_net.TabIndex = 41;
            // 
            // tbx_vat
            // 
            this.tbx_vat.Location = new System.Drawing.Point(720, 548);
            this.tbx_vat.Name = "tbx_vat";
            this.tbx_vat.Size = new System.Drawing.Size(147, 20);
            this.tbx_vat.TabIndex = 42;
            // 
            // tbx_vat_inclusive
            // 
            this.tbx_vat_inclusive.Location = new System.Drawing.Point(720, 577);
            this.tbx_vat_inclusive.Name = "tbx_vat_inclusive";
            this.tbx_vat_inclusive.Size = new System.Drawing.Size(147, 20);
            this.tbx_vat_inclusive.TabIndex = 43;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 626);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 44;
            this.btn_back.Text = "< Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(433, 626);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 45;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(797, 626);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 46;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            // 
            // tbx_dp
            // 
            this.tbx_dp.Location = new System.Drawing.Point(109, 41);
            this.tbx_dp.Name = "tbx_dp";
            this.tbx_dp.Size = new System.Drawing.Size(134, 20);
            this.tbx_dp.TabIndex = 33;
            // 
            // btn_dp
            // 
            this.btn_dp.Location = new System.Drawing.Point(610, 269);
            this.btn_dp.Name = "btn_dp";
            this.btn_dp.Size = new System.Drawing.Size(93, 23);
            this.btn_dp.TabIndex = 47;
            this.btn_dp.Text = "Downpayment";
            this.btn_dp.UseVisualStyleBackColor = true;
            this.btn_dp.Click += new System.EventHandler(this.btn_dp_Click);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btn_dp);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbx_vat_inclusive);
            this.Controls.Add(this.tbx_vat);
            this.Controls.Add(this.tbx_net);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbx_approve);
            this.Controls.Add(this.tbx_request);
            this.Controls.Add(this.tbx_prepare);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_adm;
        private System.Windows.Forms.RadioButton rbtn_cmg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_po;
        private System.Windows.Forms.TextBox tbx_pr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_dept;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_supplier;
        private System.Windows.Forms.TextBox tbx_contact;
        private System.Windows.Forms.TextBox tbx_phone;
        private System.Windows.Forms.TextBox tbx_fax;
        private System.Windows.Forms.TextBox tbx_mobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_tower;
        private System.Windows.Forms.TextBox tbx_unit;
        private System.Windows.Forms.TextBox tbx_comment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmb_check;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.RadioButton rbtn_dp;
        private System.Windows.Forms.RadioButton rbtn_check;
        private System.Windows.Forms.RadioButton rbtn_nonvat;
        private System.Windows.Forms.RadioButton rbtn_vat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbx_prepare;
        private System.Windows.Forms.TextBox tbx_request;
        private System.Windows.Forms.TextBox tbx_approve;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbx_net;
        private System.Windows.Forms.TextBox tbx_vat;
        private System.Windows.Forms.TextBox tbx_vat_inclusive;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.TextBox tbx_dp;
        private System.Windows.Forms.Button btn_dp;
    }
}