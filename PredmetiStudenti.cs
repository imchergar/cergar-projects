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
    public partial class PredmetiStudenti : Form
    {
        public PredmetiStudenti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PredmetiStudenti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNet3DataSet2.StudentPredmeti' table. You can move, or remove it, as needed.
            this.studentPredmetiTableAdapter.Fill(this.dotNet3DataSet2.StudentPredmeti);

        }
    }
}
