using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Exam
{
    public partial class Log_Pass : Form
    {
        public Log_Pass()
        {
            InitializeComponent();
            textBox_Login.TextChanged += new EventHandler(TextChanged_Login_Password);
            textBox_Password.TextChanged += new EventHandler(TextChanged_Login_Password);
            button_LoginEnter.Click += Button_LoginEnter_Click;
            Show_Log();

        }

        private void Button_LoginEnter_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text == "" || textBox_Password.Text == "")
            {
                MessageBox.Show("Fill all fields", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var log = db.LoginPassword.FirstOrDefault(z => z.Id == 1);
                log.Login = textBox_Login.Text;
                log.Password = textBox_Password.Text;
                db.LoginPassword.AddOrUpdate(log);
                db.SaveChanges();
            }

            MessageBox.Show("Admin data has changed!", "Message", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void Show_Log()
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var log = db.LoginPassword.FirstOrDefault(z => z.Id == 1);
                textBox_Login.Text = log.Login;
                textBox_Password.Text = log.Password;
            }
        }

        private void TextChanged_Login_Password(object sender, EventArgs a)
        {
            TextBox text = sender as TextBox;
            if (text.Name == textBox_Login.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_Login.Text))
                {

                }
                else
                {
                    textBox_Login.Text = null;
                }
            }
            else if (text.Name == textBox_Password.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_Password.Text))
                {

                }
                else
                {
                    textBox_Password.Text = null;
                }
            }
        }
    }
}
