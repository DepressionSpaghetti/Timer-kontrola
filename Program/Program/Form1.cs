using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            lbl2.Text = DateTime.Now.ToShortTimeString();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
