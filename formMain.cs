/* 
 * Author: Dhruv Patel
 * Date: August 13, 2021
 * Title: Final Project for NETD class.
 * Description: final Project consists of MdiParent and MdiChild which helps to open several form at once. 
 *              In this Project, I have added Contact Tacer Form and Average Cases Form as well as Text 
 *              Editor is also been added and there's a use of Menu Strip also.
 * */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDhruvP
{

    
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

        }

        //public void LayoutMdi(MdiLayout value);


        #region "Menu Strip Events"

        #region "File Menu"

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor frm = new FormEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();

            //FormEditor frm = new FormEditor();
            //FormEditor.ActiveForm.Activate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Title = "Open File Dialog";
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor frm = new FormEditor();
            if (!string.IsNullOrEmpty(Text))
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|DOCX Files (*.docx)|*.docx|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, Text);
                    Text = saveFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Oops! Error Occurred.");
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files (*.csv)|*.csv|DOCX Files (*.docx)|*.docx|Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, this.Text);
                    this.Text = saveFileDialog.FileName;
                }
            }
            else
            {
                MessageBox.Show("Oops! Error Occurred.");
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The changes you have made to this file have not been saved. Are You sure you want to exit without saving?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The changes you have made to this file have not been saved. Are You sure you want to exit without saving?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion


        #region "Edit Menu"
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region "Window Menu"

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void openContactTracerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContactTracer frm = new FormContactTracer();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        private void openAverageCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAverageCases frm = new FormAverageCases();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }


        private void openAwesomenessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAwesomeness frm = new FormAwesomeness();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }
        #endregion


        #region "Help Menu"
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NETD-2202\r\n Final Project\r\n Dhruv Patel", "About");
        }













        #endregion

        #endregion

        private void formMain_Load(object sender, EventArgs e)
        {
            FormEditor frm = new FormEditor();
            frm.MdiParent = this;
            frm.Show();
            frm.Focus();
        }

        
    }
}
