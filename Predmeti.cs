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
    public partial class Predmeti : Form
    {
        public Predmeti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var unos = new PredmetiUnos();
            unos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var unosStudenta = new PredmetiUnosStudenta();
            unosStudenta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var predmetiStudenti = new PredmetiStudenti();
            predmetiStudenti.Show();
        }
    }
}
