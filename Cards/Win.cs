using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Win : Form
    {
        public Win(int Winner)
        {
            InitializeComponent();
            label1.Text = $"Winner is : \r\nPlayer {Winner+1}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
