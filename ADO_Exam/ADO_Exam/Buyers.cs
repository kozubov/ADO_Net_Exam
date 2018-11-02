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
    public partial class Buyers : Form
    {
        public Buyers()
        {
            InitializeComponent();
            button_BuyersOk.Click += Button_BuyersOk_Click;
            Show_Table();
        }

        private void Button_BuyersOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Show_Table()
        {
            listView1_Buyers.Items.Clear();
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Buyer.Select(z => z).ToList();
                string[] row = new string[4];
                foreach (var VARIABLE in disc)
                {
                    row[0] = VARIABLE.Id.ToString();
                    row[1] = VARIABLE.FirstName;
                    row[2] = VARIABLE.LastName;
                    row[3] = VARIABLE.Quantity.ToString();
                    ListViewItem itm = new ListViewItem(row);
                    listView1_Buyers.Items.Add(itm);
                }
            }
        }
    }
}
