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
    public partial class Check : Form
    {
        private DateTime data = DateTime.Now;
        public Check()
        {
            InitializeComponent();
            button_SellingTotal.Click += Button_SellingTotal_Click;
            button_SellingDay.Click += Button_SellingDay_Click;
            button_SellingMonth.Click += Button_SellingMonth_Click;
            button_SellingYear.Click += Button_SellingYear_Click;
        }

        private void Button_SellingYear_Click(object sender, EventArgs e)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Year == data.Year).ToList();
                Show(disc);
            }
        }

        private void Button_SellingMonth_Click(object sender, EventArgs e)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Month == data.Month).ToList();
                Show(disc);
            }
        }

        private void Button_SellingDay_Click(object sender, EventArgs e)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Checkk.Where(z => z.DataSale.Day == data.Day).ToList();
                Show(disc);
            }
        }

        private void Button_SellingTotal_Click(object sender, EventArgs e)
        {
            Show_Home();
        }

        private void Show_Home()
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var discs = db.Checkk.Select(z => z).ToList();
                Show(discs);
            }
        }

        private void Show(List<Checkk> discs)
        {
            listView1_Check.Items.Clear();
            string[] row = new string[7];
            foreach (var VARIABLE in discs)
            {
                row[0] = VARIABLE.Id.ToString();
                row[1] = VARIABLE.DataSale.ToString("d");
                row[2] = VARIABLE.Disc.DiskTitle;
                row[3] = VARIABLE.Disc.Singer;
                row[4] = VARIABLE.Buyer.FirstName;
                row[5] = VARIABLE.Buyer.LastName;
                row[6] = VARIABLE.Summ.ToString();
                ListViewItem itm = new ListViewItem(row);
                listView1_Check.Items.Add(itm);
            }
        }
    }
}
