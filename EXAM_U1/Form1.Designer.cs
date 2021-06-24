namespace EXAM_U1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.TXT2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.N1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TXTNUMBER = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CB2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // TXT1
            // 
            this.TXT1.Location = new System.Drawing.Point(12, 29);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(100, 20);
            this.TXT1.TabIndex = 1;
            this.TXT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT1_KeyPress);
            // 
            // TXT2
            // 
            this.TXT2.Location = new System.Drawing.Point(139, 29);
            this.TXT2.Name = "TXT2";
            this.TXT2.Size = new System.Drawing.Size(100, 20);
            this.TXT2.TabIndex = 3;
            this.TXT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "N2";
            // 
            // TXT3
            // 
            this.TXT3.Location = new System.Drawing.Point(274, 29);
            this.TXT3.Name = "TXT3";
            this.TXT3.Size = new System.Drawing.Size(100, 20);
            this.TXT3.TabIndex = 5;
            this.TXT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "N3";
            // 
            // TXT4
            // 
            this.TXT4.Location = new System.Drawing.Point(401, 29);
            this.TXT4.Name = "TXT4";
            this.TXT4.Size = new System.Drawing.Size(100, 20);
            this.TXT4.TabIndex = 7;
            this.TXT4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT4_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "N4";
            // 
            // TXT5
            // 
            this.TXT5.Location = new System.Drawing.Point(523, 29);
            this.TXT5.Name = "TXT5";
            this.TXT5.Size = new System.Drawing.Size(100, 20);
            this.TXT5.TabIndex = 9;
            this.TXT5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT5_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "N5";
            // 
            // CB1
            // 
            this.CB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "ADD",
            "SUBSTRACT"});
            this.CB1.Location = new System.Drawing.Point(649, 29);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(121, 21);
            this.CB1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N1,
            this.N2,
            this.N3,
            this.N4,
            this.N5,
            this.OPER,
            this.TOTAL});
            this.DGV1.Location = new System.Drawing.Point(81, 86);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(742, 497);
            this.DGV1.TabIndex = 12;
            // 
            // N1
            // 
            this.N1.HeaderText = "N1";
            this.N1.Name = "N1";
            // 
            // N2
            // 
            this.N2.HeaderText = "N2";
            this.N2.Name = "N2";
            // 
            // N3
            // 
            this.N3.HeaderText = "N3";
            this.N3.Name = "N3";
            // 
            // N4
            // 
            this.N4.HeaderText = "N4";
            this.N4.Name = "N4";
            // 
            // N5
            // 
            this.N5.HeaderText = "N5";
            this.N5.Name = "N5";
            // 
            // OPER
            // 
            this.OPER.HeaderText = "OPER";
            this.OPER.Name = "OPER";
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "LINES NO.";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(96, 626);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 20);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "0";
            // 
            // TXTNUMBER
            // 
            this.TXTNUMBER.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXTNUMBER.Enabled = false;
            this.TXTNUMBER.Location = new System.Drawing.Point(991, 76);
            this.TXTNUMBER.Name = "TXTNUMBER";
            this.TXTNUMBER.Size = new System.Drawing.Size(121, 20);
            this.TXTNUMBER.TabIndex = 16;
            this.TXTNUMBER.TextChanged += new System.EventHandler(this.TXTNUMBER_TextChanged);
            this.TXTNUMBER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNUMBER_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(988, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NUMBER (LETTER)";
            // 
            // CB2
            // 
            this.CB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB2.Enabled = false;
            this.CB2.FormattingEnabled = true;
            this.CB2.Items.AddRange(new object[] {
            "Red",
            "Blue"});
            this.CB2.Location = new System.Drawing.Point(991, 139);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(121, 21);
            this.CB2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(988, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "COLOUR";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(344, 45);
            this.button2.TabIndex = 19;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(1174, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 121);
            this.button3.TabIndex = 20;
            this.button3.Text = "COLOUR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 894);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CB2);
            this.Controls.Add(this.TXTNUMBER);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB1);
            this.Controls.Add(this.TXT5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXT4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.TextBox TXT2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N2;
        private System.Windows.Forms.DataGridViewTextBoxColumn N3;
        private System.Windows.Forms.DataGridViewTextBoxColumn N4;
        private System.Windows.Forms.DataGridViewTextBoxColumn N5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox TXTNUMBER;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CB2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

