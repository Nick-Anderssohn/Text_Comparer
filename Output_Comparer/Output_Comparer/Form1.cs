using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Output_Comparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string text1 = RemoveAllWhiteSpace(txt1.Text);
            string text2 = RemoveAllWhiteSpace(txt2.Text);
            if (text1 == text2)
            {
                txtResult.Text = "They are the same!";
            }
            else
            {
                txtResult.Text = "They are different!";
            }
        }

        private string RemoveAllWhiteSpace(string editMe)
        {
            string newString = "";

            for (int i = 0; i < editMe.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(editMe[i].ToString()))
                {
                    newString += editMe[i];
                }
            }
            return newString;
        }
    }
}
