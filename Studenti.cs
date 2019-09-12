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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var unos = new StudentiUnos();
            unos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var popis = new StudentiPopis();
            popis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var _db = new DotNet3Context();
            var studenti = _db.Studenti.Where(x => x.PunoIme == null);

            foreach (var student in studenti)
            {
                student.PunoIme = student.Ime + " " + student.Prezime;
            }
            _db.SaveChanges();
            _db.Dispose();
        }
    }
}
