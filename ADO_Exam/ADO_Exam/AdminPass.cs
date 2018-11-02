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
    public partial class AdminPass : Form
    {
        public AdminPass()
        {
            InitializeComponent();

            textBox_AdminLogin.TextChanged += new EventHandler(TextChanged_Login_Password);
            textBox_AdminPassword.TextChanged += new EventHandler(TextChanged_Login_Password);
            button_AdminEnter.Click += Button_AdminEnter_Click;

            button_StoreInfo.Click += Button_StoreInfo_Click;
            button_BuyersInfo.Click += Button_BuyersInfo_Click;
            button_SellingInfo.Click += Button_SellingInfo_Click;
            button_ChangeAdminPass.Click += Button_ChangeAdminPass_Click;
        }

        private void Button_ChangeAdminPass_Click(object sender, EventArgs e)
        {
            Log_Pass logPas = new Log_Pass();
            logPas.ShowDialog();
        }

        private void Button_SellingInfo_Click(object sender, EventArgs e)
        {
            Check check = new Check();
            check.ShowDialog();
        }

        private void Button_BuyersInfo_Click(object sender, EventArgs e)
        {
            Buyers pokupatel = new Buyers();
            pokupatel.ShowDialog();
        }
    

        private void Button_StoreInfo_Click(object sender, EventArgs e)
        {
            Shop_Edit produkt = new Shop_Edit();
            produkt.ShowDialog();
        }

        private void Button_AdminEnter_Click(object sender, EventArgs e)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var Log_Pas = db.LoginPassword.Where(z =>
                    z.Login == textBox_AdminLogin.Text && z.Password == textBox_AdminPassword.Text).ToList();
                if (Log_Pas.Count == 0)
                {
                    textBox_AdminLogin.Text = null;
                    textBox_AdminPassword.Text = null;
                    label_WrongLoginPass.Visible = true;
                }
                else
                {
                    panel_Shield.Visible = false;
                }
            }
        }

        private void TextChanged_Login_Password(object sender, EventArgs a)
        {
            TextBox text = sender as TextBox;
            label_WrongLoginPass.Visible = false;
            if (text.Name == textBox_AdminLogin.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_AdminLogin.Text))
                {

                }
                else
                {
                    textBox_AdminLogin.Text = null;
                }
            }
            else if (text.Name == textBox_AdminPassword.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_AdminPassword.Text))
                {

                }
                else
                {
                    textBox_AdminPassword.Text = null;
                }
            }
        }
    }
}
