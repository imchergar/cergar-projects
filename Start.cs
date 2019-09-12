using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet3
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var studenti = new Studenti();
            studenti.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var predmeti = new Predmeti();
            predmeti.Show();
        }
    }
}
