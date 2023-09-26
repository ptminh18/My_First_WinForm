using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void MyForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void frmBT5_FormClosing(object sender, EventArgs e)
        {

            DialogResult r;
            r = MessageBox.Show("Are you really want to exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
                Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is " + textBox1.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(textBox2.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "Enter your name please");
            else
                errorProvider1.Clear();
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            Control ctr1 = (Control)sender;
            int nam_sinh;
            if (int.TryParse(textBox2.Text, out nam_sinh) == false)
                errorProvider2.SetError(textBox2, "Must be Number");
            //if (ctr1.Text.Length > 0 && !Char.IsDigit(ctr1.Text[ctr1.Text.Length - 11]))
            //    this.errorProvider2.SetError(ctr1, "This is invalid number");
            //else
            //    this.errorProvider2.Clear();
        }
    }
}
