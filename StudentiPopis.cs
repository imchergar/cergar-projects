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
    public partial class StudentiPopis : Form
    {
        public StudentiPopis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentiPopis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dotNet3DataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dotNet3DataSet1.Students);

        }
    }
}
