using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace car_race
{
    public partial class Form1 : Form
    {
        Random turbo = new Random();
        Random movement = new Random();
        Int32 x, y, z;
        Int32 a, b, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = movement.Next(3, 10);
            pictureBox1.Left += x;
            

            if ((pictureBox1.Location.X) > (pictureBox2.Location.X) && (pictureBox1.Location.X) > (pictureBox3.Location.X))
            {
                label1.Text = "1st car ahead";
                if (pictureBox1.Location.X > 780)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    label1.Text = "1st car won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    brake1.Enabled = false;
                    brake2.Enabled = false;
                    brake3.Enabled = false;
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = turbo.Next(3, 10);
            pictureBox1.Left += a;
            progressBar1.Value = 0;
            button2.Enabled = false;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = turbo.Next(3, 10);
            pictureBox2.Left += b;
            progressBar2.Value = 0;
            button3.Enabled = false;
            button1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = turbo.Next(3, 10);
            pictureBox3.Left += c;
            progressBar3.Value = 0;
            button4.Enabled = false;
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer3.Stop();
            timer3.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.DarkViolet;
            progressBar2.ForeColor = Color.DarkViolet;
            progressBar3.ForeColor = Color.DarkViolet;
        }

        private void restartbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            y = movement.Next(3, 10);
            pictureBox2.Left += y;
             if ((pictureBox2.Location.X) > (pictureBox1.Location.X) && (pictureBox2.Location.X) > (pictureBox3.Location.X))
            {
                label1.Text = "2th car ahead";
                if (pictureBox2.Location.X > 780)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    label1.Text = "2th car won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    brake1.Enabled = false;
                    brake2.Enabled = false;
                    brake3.Enabled = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            z = movement.Next(3, 10);
            pictureBox3.Left += z;
             if ((pictureBox3.Location.X) > (pictureBox1.Location.X) && (pictureBox3.Location.X) > (pictureBox2.Location.X))
            {
                label1.Text = "3rd car ahead";
                if (pictureBox3.Location.X > 780)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    label1.Text = "3rd car won";
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    brake1.Enabled = false;
                    brake2.Enabled = false;
                    brake3.Enabled = false;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Q)
            {
                timer1.Stop();
                timer1.Start();
            }
            else if (e.KeyCode==Keys.W)
            {
                timer2.Stop();
                timer2.Start();

            }
            else if (e.KeyCode==Keys.E)
            {
                timer3.Stop();
                timer3.Start();
            }
        }

        private void brake1_Click(object sender, EventArgs e)
        {

        }

        private void brake1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void brake2_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void brake3_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }

        private void brake3_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Start();
        }

        private void brake2_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }

        private void brake1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

       

    }
}

        
       

        

        

        


    

