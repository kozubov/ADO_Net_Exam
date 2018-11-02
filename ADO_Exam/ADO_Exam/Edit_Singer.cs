using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Exam
{
    public partial class Edit_Singer : Form
    {
        int col = 0;
        DateTime date;
        decimal seb_pr = 0;
        decimal pr = 0;
        private Disc disc_disc;
        public Edit_Singer(Disc disc)
        {
            InitializeComponent();
            disc_disc = disc;

            textBox_AlbumEdit.TextChanged += new EventHandler(textBox);
            textBox_SingerEdit.TextChanged += new EventHandler(textBox);
            textBox_PublisherEdit.TextChanged += new EventHandler(textBox);
            textBox_TracksEdit.TextChanged += new EventHandler(textBox);
            textBox_GenreEdit.TextChanged += new EventHandler(textBox);
            textBox_DateOfPubEdit.TextChanged += new EventHandler(textBox);
            textBox_IncomePriceEdit.TextChanged += new EventHandler(textBox);
            textBox_SellPriceEdit.TextChanged += new EventHandler(textBox);

            button_EditCover.Click += Button_EditCover_Click;
            button_EditSave.Click += Button_EditSave_Click;

            Show_Disc(disc);

        }

        private void Button_EditSave_Click(object sender, EventArgs e)
        {
            if (textBox_AlbumEdit.Text == "" || textBox_SingerEdit.Text == "" || textBox_PublisherEdit.Text == "" ||
                textBox_TracksEdit.Text == "" || textBox_GenreEdit.Text == "" || textBox_DateOfPubEdit.Text == "" ||
                textBox_IncomePriceEdit.Text == "" || textBox_SellPriceEdit.Text == "")
            {
                MessageBox.Show("Fill all fields!", "Caution", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                col = Convert.ToInt32(textBox_TracksEdit.Text);
                date = Convert.ToDateTime(textBox_DateOfPubEdit.Text);
                seb_pr = Convert.ToDecimal(textBox_IncomePriceEdit.Text);
                pr = Convert.ToDecimal(textBox_SellPriceEdit.Text);
                Edit_database();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some fields fills wrong!", "Caution", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void Button_EditCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG file (*.png)|*.png|JPG file(*.jpg)|*.jpg|JPEG file(*.jpeg)|*.jpeg|All file(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1_imgEdit.Text = $"..\\..\\Covers\\{Path.GetFileName(openFile.FileName)}";
            }
        }

        private void Edit_database()
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Disc.FirstOrDefault(z => z.Id == disc_disc.Id);
                disc.Singer = textBox_SingerEdit.Text;
                disc.Tracks = col;
                disc.CostPrice = seb_pr;
                disc.DiskTitle = textBox_AlbumEdit.Text;
                disc.Genre = textBox_GenreEdit.Text;
                disc.Publisher = textBox_PublisherEdit.Text;
                disc.Cover = textBox1_imgEdit.Text;
                disc.SellPrice = pr;
                disc.YearPublishing = date;
                db.Disc.AddOrUpdate(disc);
                db.SaveChanges();
            }
            DialogResult = DialogResult.OK;
        }

        private void Show_Disc(Disc disc)
        {
            textBox_TracksEdit.Text = disc.Tracks.ToString();
            textBox_SingerEdit.Text = disc.Singer;
            textBox_GenreEdit.Text = disc.Genre;
            textBox_PublisherEdit.Text = disc.Publisher;
            textBox_AlbumEdit.Text = disc.DiskTitle;
            textBox_SellPriceEdit.Text = disc.SellPrice.ToString();
            textBox_IncomePriceEdit.Text = disc.CostPrice.ToString();
            textBox_DateOfPubEdit.Text = disc.YearPublishing.ToString("d");
            textBox1_imgEdit.Text = disc.Cover;
        }

        private void textBox(object sender, EventArgs a)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == textBox_TracksEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_TracksEdit.Text))
                {

                }
                else
                {
                    textBox_TracksEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_SingerEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_SingerEdit.Text))
                {

                }
                else
                {
                    textBox_SingerEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_GenreEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_GenreEdit.Text))
                {

                }
                else
                {
                    textBox_GenreEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_PublisherEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_PublisherEdit.Text))
                {

                }
                else
                {
                    textBox_PublisherEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_AlbumEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_AlbumEdit.Text))
                {

                }
                else
                {
                    textBox_AlbumEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_SellPriceEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_SellPriceEdit.Text))
                {

                }
                else
                {
                    textBox_SellPriceEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_IncomePriceEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_IncomePriceEdit.Text))
                {

                }
                else
                {
                    textBox_IncomePriceEdit.Text = null;
                }
            }
            else if (textBox.Name == textBox_DateOfPubEdit.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_DateOfPubEdit.Text))
                {

                }
                else
                {
                    textBox_DateOfPubEdit.Text = null;
                }
            }
        }
    }
}
