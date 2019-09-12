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
    public partial class PredmetiUnosStudenta : Form
    {
        public PredmetiUnosStudenta()
        {
            InitializeComponent();
        }

        private void PredmetiUnosStudenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNet3DataSet3.Predmets' table. You can move, or remove it, as needed.
            this.predmetsTableAdapter.Fill(this.dotNet3DataSet3.Predmets);
            // TODO: This line of code loads data into the 'dotNet3DataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dotNet3DataSet1.Students);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var _db = new DotNet3Context();
            _db.StudentPredmet.Add(new StudentPredmet()
            {
                PredmetId = int.Parse(listBox2.SelectedValue.ToString()),
                StudentId = int.Parse(listBox1.SelectedValue.ToString())
            });
            _db.SaveChanges();
            _db.Dispose();

            Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
