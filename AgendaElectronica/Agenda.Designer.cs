namespace AgendaElectronica
{
    partial class Agenda
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
            panel1 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            lblname = new Label();
            txtname = new TextBox();
            lbllastname = new Label();
            cmbgender = new ComboBox();
            txtlastname = new TextBox();
            lblgender = new Label();
            lblbirthdate = new Label();
            mskbirthdate = new MaskedTextBox();
            panel4 = new Panel();
            lbladdress = new Label();
            txtaddress = new TextBox();
            txtmail = new TextBox();
            lblstatus = new Label();
            lblmail = new Label();
            cmbstatus = new ComboBox();
            mskphone = new MaskedTextBox();
            lblphone = new Label();
            btnsave = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 539);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(751, 303);
            panel3.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(658, 16);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(560, 17);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 17;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 233);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 17);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(296, 16);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnsave);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(751, 224);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblname);
            panel5.Controls.Add(txtname);
            panel5.Controls.Add(lbllastname);
            panel5.Controls.Add(cmbgender);
            panel5.Controls.Add(txtlastname);
            panel5.Controls.Add(lblgender);
            panel5.Controls.Add(lblbirthdate);
            panel5.Controls.Add(mskbirthdate);
            panel5.Location = new Point(14, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 176);
            panel5.TabIndex = 21;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(52, 10);
            lblname.Name = "lblname";
            lblname.Size = new Size(39, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Name";
            // 
            // txtname
            // 
            txtname.Location = new Point(130, 7);
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Name";
            txtname.Size = new Size(121, 23);
            txtname.TabIndex = 1;
            // 
            // lbllastname
            // 
            lbllastname.AutoSize = true;
            lbllastname.Location = new Point(52, 54);
            lbllastname.Name = "lbllastname";
            lbllastname.Size = new Size(63, 15);
            lbllastname.TabIndex = 2;
            lbllastname.Text = "Last Name";
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Items.AddRange(new object[] { "Male", "Female", "Nonbinary", "Others" });
            cmbgender.Location = new Point(130, 130);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(121, 23);
            cmbgender.TabIndex = 7;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(130, 51);
            txtlastname.Name = "txtlastname";
            txtlastname.PlaceholderText = "Last Name";
            txtlastname.Size = new Size(121, 23);
            txtlastname.TabIndex = 3;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Location = new Point(52, 133);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(45, 15);
            lblgender.TabIndex = 6;
            lblgender.Text = "Gender";
            // 
            // lblbirthdate
            // 
            lblbirthdate.AutoSize = true;
            lblbirthdate.Location = new Point(52, 95);
            lblbirthdate.Name = "lblbirthdate";
            lblbirthdate.Size = new Size(59, 15);
            lblbirthdate.TabIndex = 4;
            lblbirthdate.Text = "Birth Date";
            // 
            // mskbirthdate
            // 
            mskbirthdate.Location = new Point(130, 95);
            mskbirthdate.Mask = "00/00/0000";
            mskbirthdate.Name = "mskbirthdate";
            mskbirthdate.Size = new Size(121, 23);
            mskbirthdate.TabIndex = 5;
            mskbirthdate.ValidatingType = typeof(DateTime);
            // 
            // panel4
            // 
            panel4.Controls.Add(lbladdress);
            panel4.Controls.Add(txtaddress);
            panel4.Controls.Add(txtmail);
            panel4.Controls.Add(lblstatus);
            panel4.Controls.Add(lblmail);
            panel4.Controls.Add(cmbstatus);
            panel4.Controls.Add(mskphone);
            panel4.Controls.Add(lblphone);
            panel4.Location = new Point(418, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 176);
            panel4.TabIndex = 20;
            // 
            // lbladdress
            // 
            lbladdress.AutoSize = true;
            lbladdress.Location = new Point(44, 15);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(49, 15);
            lbladdress.TabIndex = 8;
            lbladdress.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(122, 12);
            txtaddress.Name = "txtaddress";
            txtaddress.PlaceholderText = "Address";
            txtaddress.Size = new Size(136, 23);
            txtaddress.TabIndex = 9;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(122, 129);
            txtmail.Name = "txtmail";
            txtmail.PlaceholderText = "Alexander@gmail.com";
            txtmail.Size = new Size(136, 23);
            txtmail.TabIndex = 15;
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Location = new Point(44, 51);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(39, 15);
            lblstatus.TabIndex = 10;
            lblstatus.Text = "Status";
            // 
            // lblmail
            // 
            lblmail.AutoSize = true;
            lblmail.Location = new Point(44, 132);
            lblmail.Name = "lblmail";
            lblmail.Size = new Size(30, 15);
            lblmail.TabIndex = 14;
            lblmail.Text = "Mail";
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "Single", "Married" });
            cmbstatus.Location = new Point(122, 48);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(136, 23);
            cmbstatus.TabIndex = 11;
            cmbstatus.Text = " ";
            // 
            // mskphone
            // 
            mskphone.Location = new Point(122, 94);
            mskphone.Mask = "(999) 000-0000";
            mskphone.Name = "mskphone";
            mskphone.Size = new Size(136, 23);
            mskphone.TabIndex = 13;
            // 
            // lblphone
            // 
            lblphone.AutoSize = true;
            lblphone.Location = new Point(44, 97);
            lblphone.Name = "lblphone";
            lblphone.Size = new Size(41, 15);
            lblphone.TabIndex = 12;
            lblphone.Text = "Phone";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(324, 189);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 23);
            btnsave.TabIndex = 19;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(781, 563);
            Controls.Add(panel1);
            MaximumSize = new Size(797, 602);
            MinimumSize = new Size(797, 602);
            Name = "Agenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            Load += Agenda_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtname;
        private Label lblname;
        private MaskedTextBox mskbirthdate;
        private Label lblbirthdate;
        private TextBox txtlastname;
        private Label lbllastname;
        private TextBox txtaddress;
        private Label lbladdress;
        private ComboBox cmbgender;
        private Label lblgender;
        private Label lblstatus;
        private TextBox txtmail;
        private Label lblmail;
        private MaskedTextBox mskphone;
        private Label lblphone;
        private ComboBox cmbstatus;
        private TextBox textBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Panel panel5;
        private Panel panel4;
        private Button btnsave;
    }
}
