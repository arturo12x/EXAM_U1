using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_U1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TXT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == (char)Keys.Back);
        }

        private void TXT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == (char)Keys.Back);
        }

        private void TXT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == (char)Keys.Back);
        }

        private void TXT4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == (char)Keys.Back);
        }

        private void TXT5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(e.KeyChar == (char)Keys.Space || e.KeyChar == '-' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == (char)Keys.Back);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TXTN1, TXTN2, TXTN3, TXTN4, TXTN5, TXTOPER,TXTTOTAL, ERROR;
            int total, numlines;




            TXTOPER = "0";
            TXTTOTAL = "0";
            ERROR = "";
            TXT1.BackColor = Color.White;
            TXT2.BackColor = Color.White;
            TXT3.BackColor = Color.White;
            TXT4.BackColor = Color.White;
            TXT5.BackColor = Color.White;
            TXTN1 = TXT1.Text;
            TXTN2 = TXT2.Text;
            TXTN3 = TXT3.Text;
            TXTN4 = TXT4.Text;
            TXTN5 = TXT5.Text;


            //VALIDACIONES
            if (string.IsNullOrWhiteSpace(TXTN1))
            {
                ERROR += "| YOU CAN'T LEAVE EMPTY THE TEXTBOX1 |";
                TXT1.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(TXTN2))
            {
                ERROR += "| YOU CAN'T LEAVE EMPTY THE TEXTBOX2 |";
                TXT2.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(TXTN3))
            {
                ERROR += "| YOU CAN'T LEAVE EMPTY THE TEXTBOX3 |";
                TXT3.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(TXTN4))
            {
                ERROR += " | YOU CAN'T LEAVE EMPTY THE TEXTBOX4 |";
                TXT4.BackColor = Color.DarkRed;

            }
            if (string.IsNullOrWhiteSpace(TXTN5))
            {
                ERROR += " | YOU CAN'T LEAVE EMPTY THE TEXTBOX5 |";
                TXT5.BackColor = Color.DarkRed;

            }
            if (ERROR != "")
            {
                MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            TXTOPER = CB1.Text;

            if(CB1.SelectedIndex==0){
                total = 0;
                total = Convert.ToInt32(TXTN1) + Convert.ToInt32(TXTN2) + Convert.ToInt32(TXTN3) + Convert.ToInt32(TXTN4) + Convert.ToInt32(TXTN5);
                TXTTOTAL = total.ToString();
            }
            if (CB1.SelectedIndex == 1)
            {
                total = 0;
                total = Convert.ToInt32(TXTN1) - Convert.ToInt32(TXTN2) - Convert.ToInt32(TXTN3) - Convert.ToInt32(TXTN4) - Convert.ToInt32(TXTN5);
                TXTTOTAL = total.ToString();
            }

            
       

            DGV1.Rows.Add(TXTN1, TXTN2, TXTN3, TXTN4, TXTN5,TXTOPER,TXTTOTAL);
  

           numlines= DGV1.RowCount;
           textBox6.Text = numlines.ToString();
           TXTNUMBER.Enabled = true;
           CB2.Enabled = true;
   
           button3.Enabled = true;
           label7.Enabled = true;
           label8.Enabled = true;
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            CB1.SelectedIndex = 0;
            CB2.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number="0";
            string COLOR1 = CB2.Text;
            string TXTNUMBER1 = "", ERROR = "";

            TXTNUMBER1=TXTNUMBER.Text;

            if (string.IsNullOrWhiteSpace(TXTNUMBER1))
            {
                ERROR += "| YOU CAN'T LEAVE EMPTY THE TEXTBOXNUMBER |";
                TXTNUMBER.BackColor = Color.DarkRed;
            }


            if (ERROR != "")
            {
                MessageBox.Show(ERROR, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TXTNUMBER.Text == "ONE")
            {
                number = "1";
            }

            if (TXTNUMBER.Text == "TWO")
            {
                number = "2";
            }
            if (TXTNUMBER.Text == "THREE")
            {
                number = "3";
            }

            if(COLOR1=="RED"){

            }





                 foreach (DataGridViewRow row1 in DGV1.Rows)
            {
                string CHECAR0 = "";
                string CHECAR1 = "";
                string CHECAR2 = "";
                string CHECAR3 = "";
                string CHECAR4 = "";

                CHECAR0 = Convert.ToString(DGV1[0, row1.Index].Value);
                CHECAR1 = Convert.ToString(DGV1[1, row1.Index].Value);
                CHECAR2 = Convert.ToString(DGV1[2, row1.Index].Value);
                CHECAR3 = Convert.ToString(DGV1[3, row1.Index].Value);
                CHECAR4 = Convert.ToString(DGV1[4, row1.Index].Value);
              
                if (CHECAR0 == number)
                {

                    DGV1[0, row1.Index].Style.BackColor = Color.FromName(COLOR1);
                  
                }
                if (CHECAR1 == number)
                {

                    DGV1[1, row1.Index].Style.BackColor = Color.FromName(COLOR1);

                }
                if (CHECAR2 == number)
                {

                    DGV1[2, row1.Index].Style.BackColor = Color.FromName(COLOR1);

                }
                if (CHECAR3 == number)
                {

                    DGV1[3, row1.Index].Style.BackColor = Color.FromName(COLOR1);

                }
                if (CHECAR4 == number)
                {

                    DGV1[4, row1.Index].Style.BackColor = Color.FromName(COLOR1);

                }
                     





                     /////////


   
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXT1.Text = "";
            TXT2.Text = "";
            TXT3.Text = "";
            TXT3.Text = "";
            TXT4.Text = "";
            TXT5.Text = "";
            CB1.SelectedIndex = 0;
            textBox6.Text = "0";
            TXTNUMBER.Text = "";
            CB2.SelectedIndex = 0;

            this.DGV1.Rows.Clear();
            TXT1.BackColor = Color.White;
            TXT2.BackColor = Color.White;
            TXT3.BackColor = Color.White;
            TXT4.BackColor = Color.White;
            TXT5.BackColor = Color.White;
            TXTNUMBER.Enabled = false;
            CB2.Enabled = false;

            button3.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
        }

        private void TXTNUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space || e.KeyChar == 'O' || e.KeyChar == 'N' || e.KeyChar == 'E' || e.KeyChar == 'T' || e.KeyChar == 'W' || e.KeyChar == 'E' || e.KeyChar == 'H' || e.KeyChar == 'R' ||  e.KeyChar == (char)Keys.Back);
        }

        private void TXTNUMBER_TextChanged(object sender, EventArgs e)
        {

        }
        }



    }

