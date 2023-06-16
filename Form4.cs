using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numismatics
{
    public partial class Form4 : Form
    {
        public int price;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Price.Text))
                price = Convert.ToInt32(Price.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
