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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();
            SoundPlayer simpleSound = new SoundPlayer(@"files\SSS.wav");
            simpleSound.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
