using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Exam
{
    public partial class Customer : Form
    {
        private string lastName;
        private string firstName;
        private List<Disc> list = null;
        public Customer(List<Disc> discs)
        {
            InitializeComponent();
            list = discs;
            textBox_BuyerFName.TextChanged += TextBox_BuyerFName_TextChanged;
            textBox_BuyerLName.TextChanged += TextBox_BuyerLName_TextChanged;
            button_BuyerOk.Click += Button_BuyerOk_Click;
        }

        private void Button_BuyerOk_Click(object sender, EventArgs e)
        {
            if (textBox_BuyerFName.Text == "" || textBox_BuyerLName.Text == "")
            {
                MessageBox.Show("Fill all fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Order F = new Order(list, lastName, firstName);
            if (F.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void TextBox_BuyerLName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_BuyerLName.Text))
            {
                lastName = textBox_BuyerLName.Text;
            }
            else
            {
                textBox_BuyerLName.Text = null;
            }
        }

        private void TextBox_BuyerFName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_BuyerFName.Text))
            {
                firstName = textBox_BuyerFName.Text;
            }
            else
            {
                textBox_BuyerFName.Text = null;
            }
        }
    }
}
