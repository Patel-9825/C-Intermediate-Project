/* 
 * Author: Dhruv Patel
 * Date: July 29, 2021
 * Title: Lab 5 for NETD class.
 * Description: This lab is based on text editor which is made with putting all basic components which are used in Menu bar of any editor.
 *              Every menu item has click event defined and coding is done based on different events and performs different tasks.
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
    public partial class FormEditor : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        public FormEditor()
        {
            InitializeComponent();
        }
       

        

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMain.Text.Length > 0)
            {
                //toolStripEditMenuCut.Enabled = true;
                //toolStripEditMenuCopy.Enabled = true;
            }
            else
            {
               // toolStripEditMenuCut.Enabled = false;
               //toolStripEditMenuCopy.Enabled = false;
            }
        }
    }
}
