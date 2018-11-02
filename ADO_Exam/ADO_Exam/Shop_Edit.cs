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
    public partial class Shop_Edit : Form
    {
        private List<Disc> list = new List<Disc>();
        public Shop_Edit()
        {
            InitializeComponent();
            button_DeleteSinger.Click += Button_DeleteSinger_Click;
            button_EditSinger.Click += Button_EditSinger_Click;
            button_AddSinger.Click += Button_AddSinger_Click;
            listView1_Disc.SelectedIndexChanged += ListView1_Disc_SelectedIndexChanged; 
            Show_Table();
        }

        private void ListView1_Disc_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_DeleteSinger.Visible = true;
            button_EditSinger.Visible = true;
        }

        private void Button_AddSinger_Click(object sender, EventArgs e)
        {
            Add_Singer disc = new Add_Singer();
            if (disc.ShowDialog() == DialogResult.OK)
            {
                Show_Table();
            }
        }

        private void Button_EditSinger_Click(object sender, EventArgs e)
        {
            Disc disc = list[listView1_Disc.FocusedItem.Index];
            Edit_Singer edit = new Edit_Singer(disc);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                Show_Table();
            }
        }

        private void Button_DeleteSinger_Click(object sender, EventArgs e)
        {
            int index = listView1_Disc.FocusedItem.Index;
            Disc disc = list[index];
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var find = db.Disc.FirstOrDefault(z => z.Id == disc.Id);
                db.Disc.Remove(find);
                db.SaveChanges();
            }
            Show_Table();
        }

        private void Show_Table()
        {
            button_EditSinger.Visible = false;
            button_DeleteSinger.Visible = false;
            listView1_Disc.Items.Clear();
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Disc.Select(z => z).ToList();
                list = disc;
                string[] row = new string[10];
                foreach (var VARIABLE in list)
                {
                    row[0] = VARIABLE.Id.ToString();
                    row[1] = VARIABLE.Cover;
                    row[2] = VARIABLE.DiskTitle;
                    row[3] = VARIABLE.Singer;
                    row[4] = VARIABLE.Publisher;
                    row[5] = VARIABLE.Tracks.ToString();
                    row[6] = VARIABLE.Genre;
                    row[7] = VARIABLE.YearPublishing.ToString("d");
                    row[8] = VARIABLE.CostPrice.ToString();
                    row[9] = VARIABLE.SellPrice.ToString();
                    ListViewItem itm = new ListViewItem(row);
                    listView1_Disc.Items.Add(itm);
                }
            }
        }
    }
}
