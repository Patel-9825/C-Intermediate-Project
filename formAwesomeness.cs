using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDhruvP
{
    public partial class FormAwesomeness : Form
    {
        public FormAwesomeness()
        {
            InitializeComponent();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes, Dhruv is awesome, aren't they!");
            Close();
        }

        private void buttonLeftNo_Click(object sender, EventArgs e)
        {
            buttonLeftNo.Visible = false;
            buttonRightNo.Visible = true;
        }

        private void buttonRightNo_Click(object sender, EventArgs e)
        {
            buttonRightNo.Visible = false;
            buttonLeftNo.Visible = true;
        }
    }
}
