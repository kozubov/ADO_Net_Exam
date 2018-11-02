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
    public partial class Cart : Form
    {
        private Form1 form = null;
        private List<Disc> Kor_disc = null;
        public Cart(Form1 form1, List<Disc> disc)
        {
            InitializeComponent();
            form = form1;
            Kor_disc = disc;
           
            listBox_Cart.SelectedIndexChanged += ListBox_Cart_SelectedIndexChanged;
            button_CartDelete.Click += Button_CartDelete_Click;
            button_CartOk.Click += Button_CartOk_Click;
            Show_Cart();
        }

        private void Button_CartOk_Click(object sender, EventArgs e)
        {
            if (Kor_disc.Count == 0)
            {
                MessageBox.Show("Your cart is empty", "Caution", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            Customer user = new Customer(Kor_disc);
            if (user.ShowDialog() == DialogResult.OK)
            {
                Kor_disc.Clear();
                form.SetList(Kor_disc);
                Close();
            }
        }

        private void Button_CartDelete_Click(object sender, EventArgs e)
        {
            int index = listBox_Cart.SelectedIndex;
            Kor_disc.RemoveAt(index);
            Show_Cart();
        }

        private void ListBox_Cart_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_CartDelete.Visible = true;
        }

        private void Show_Cart()
        {
            button_CartDelete.Visible = false;
            decimal sum = 0;
            listBox_Cart.Items.Clear();
            foreach (var VARIABLE in Kor_disc)
            {
                sum += VARIABLE.SellPrice;
                listBox_Cart.Items.Add(
                    $"Disc: {VARIABLE.DiskTitle} by {VARIABLE.Singer}, Cost: {VARIABLE.SellPrice} USD");
            }

            label_TotalCart.Text = sum.ToString();
        }
    }
}
