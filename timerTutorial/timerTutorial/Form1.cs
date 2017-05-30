using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerTutorial
{
    public partial class Form1 : Form
    {
        Form2 FR2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FR2.Visible = true;
            
        }
    }
}
