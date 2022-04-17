using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer;

namespace Cards
{
    public partial class Form1 : Form
    {
        public BOLayer.Color ChosenColor { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            ChosenColor = BOLayer.Color.Red;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChosenColor = BOLayer.Color.Blue;
            this.Close();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            ChosenColor = BOLayer.Color.Yellow;
            this.Close();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            ChosenColor = BOLayer.Color.Green;
            this.Close();
        }
    }
}
