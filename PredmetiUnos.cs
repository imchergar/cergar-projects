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
    public partial class PredmetiUnos : Form
    {
        public PredmetiUnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _db = new DotNet3Context();
            _db.Predmeti.Add(new Predmet()
            {
                Naziv = textBox1.Text
            });
            _db.SaveChanges();
            _db.Dispose();

            Close();
        }
    }
}
