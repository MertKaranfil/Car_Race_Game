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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            progressBar1.Value = saniye;
            if (saniye==100)
            {
                timer1.Stop();
            Form1 frm1 = new Form1();
            frm1.Show();
            Visible = false;  
            }
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.ForeColor = Color.Red;
        }
    }
}
