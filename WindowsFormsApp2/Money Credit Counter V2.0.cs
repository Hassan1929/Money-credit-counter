using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Declare counter integers for reflecting the number of times that coin has been selected. 
        int counter = 0;
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;
        int counter6 = 0;
        int counter7 = 0;
        int counter8 = 0;

        // Declare double to store value total coins value in pences
        Double total = 0;
        // Declare double to store value total coins value in pounds and pences
        Double totalp = 0;
        // Declare double to store value total number of credits per total cost
        Double credit = 0;

        public Form1()
        {
            InitializeComponent();

            // Place form in the centre of screen
            CenterToScreen();
        }
                
        private void button_click(object sender, EventArgs e)
        {
            // set Value of coin
            button2.Text = "1";

            // Calculate the total value of coin selected and display in total textbox in pences
            total = Double.Parse(textBox3.Text);            
            textBox3.Text = (total + Double.Parse(button2.Text)).ToString();

            // Calculate the total value of coin selected and display in total textbox in pounds and pences
            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button2.Text) / 100).ToString();

            // To check the total price and number of credits 
            credit = Double.Parse(textBox1.Text);

            if (total == credit)
            {
                counter8++;
                textBox2.Text = counter8.ToString();
            }

            // counter to calculate the number of times that coin has been selected. 
            counter++;
            label18.Text = counter.ToString();
                        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "2";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button4.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button4.Text) / 100).ToString();

            counter1++;
            label19.Text = counter1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "5";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button6.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button6.Text) / 100).ToString();

            counter2++;
            label20.Text = counter2.ToString();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "10";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button8.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button8.Text) / 100).ToString();

            counter3++;
            label22.Text = counter3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "25";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button3.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button3.Text) / 100).ToString();

            counter4++;
            label21.Text = counter4.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "50";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button5.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button5.Text) / 100).ToString();

            counter5++;
            label23.Text = counter5.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "100";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button7.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button7.Text) / 100).ToString();

            counter6++;
            label24.Text = counter6.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "200";
            total = Double.Parse(textBox3.Text);
            textBox3.Text = (total + Double.Parse(button9.Text)).ToString();

            totalp = Double.Parse(textBox4.Text);
            textBox4.Text = (totalp + Double.Parse(button9.Text) / 100).ToString();

            counter7++;
            label25.Text = counter7.ToString();
        }

        private void click_event(object sender, MouseEventArgs e)
        {
            //Displat message if cost of credit is not entered
            if (textBox1.Text == "0")
            { MessageBox.Show("Please set the cost of a Credit!"); }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // to reset the Form and clear all fields
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
