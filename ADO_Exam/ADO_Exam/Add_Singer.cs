using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Exam
{
    public partial class Add_Singer : Form
    {
        int col = 0;
        DateTime date;
        decimal seb_pr = 0;
        decimal pr = 0;
        public Add_Singer()
        {
            InitializeComponent();
            textBox_AlbumAdd.TextChanged += new EventHandler(textBox);
            textBox_SingerAdd.TextChanged += new EventHandler(textBox);
            textBox_PublisherAdd.TextChanged += new EventHandler(textBox);
            textBox_TracksAdd.TextChanged += new EventHandler(textBox);
            textBox_GenreAdd.TextChanged += new EventHandler(textBox);
            textBox_DateOfPubAdd.TextChanged += new EventHandler(textBox);
            textBox_IncomePriceAdd.TextChanged += new EventHandler(textBox);
            textBox_SellPriceAdd.TextChanged += new EventHandler(textBox);

            button_AddCover.Click += Button_AddCover_Click;
            button_AddDisk.Click += Button_AddDisk_Click;
        }

        private void Button_AddDisk_Click(object sender, EventArgs e)
        {
            if (textBox_AlbumAdd.Text == "" || textBox_SingerAdd.Text == "" || textBox_PublisherAdd.Text == "" ||
                textBox_TracksAdd.Text == "" || textBox_GenreAdd.Text == "" || textBox_DateOfPubAdd.Text == "" ||
                textBox_IncomePriceAdd.Text == "" || textBox_SellPriceAdd.Text == "")
            {
                MessageBox.Show("Fill all fields!", "Caution", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                col = Convert.ToInt32(textBox_TracksAdd.Text);
                date = Convert.ToDateTime(textBox_DateOfPubAdd.Text);
                seb_pr = Convert.ToDecimal(textBox_IncomePriceAdd.Text);
                pr = Convert.ToDecimal(textBox_SellPriceAdd.Text);
                Add_database();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Some fields are fill wrong!", "Caution", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        private void Button_AddCover_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG file (*.png)|*.png|JPG file(*.jpg)|*.jpg|JPEG file(*.jpeg)|*.jpeg|All file(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1_img.Text = $"..\\..\\Covers\\{Path.GetFileName(openFile.FileName)}";
            }
        }

        private void Add_database()
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                Disc disc = new Disc
                {
                    Singer = textBox_SingerAdd.Text,
                    Tracks = col,
                    CostPrice = seb_pr,
                    DiskTitle = textBox_AlbumAdd.Text,
                    Genre = textBox_GenreAdd.Text,
                    Publisher = textBox_PublisherAdd.Text,
                    Cover = textBox1_img.Text,
                    SellPrice = pr,
                    YearPublishing = date
                };
                db.Disc.Add(disc);
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void Button1_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "PNG file (*.png)|*.png|JPG file(*.jpg)|*.jpg|JPEG file(*.jpeg)|*.jpeg|All file(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1_img.Text = $"..\\..\\Covers\\{Path.GetFileName(openFile.FileName)}";
            }
        }

        private void textBox(object sender, EventArgs a)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Name == textBox_TracksAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_TracksAdd.Text))
                {

                }
                else
                {
                    textBox_TracksAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_SingerAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_SingerAdd.Text))
                {

                }
                else
                {
                    textBox_SingerAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_GenreAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_GenreAdd.Text))
                {

                }
                else
                {
                    textBox_GenreAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_PublisherAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_PublisherAdd.Text))
                {

                }
                else
                {
                    textBox_PublisherAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_AlbumAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_AlbumAdd.Text))
                {

                }
                else
                {
                    textBox_AlbumAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_SellPriceAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_SellPriceAdd.Text))
                {

                }
                else
                {
                    textBox_SellPriceAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_IncomePriceAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_IncomePriceAdd.Text))
                {

                }
                else
                {
                    textBox_IncomePriceAdd.Text = null;
                }
            }
            else if (textBox.Name == textBox_DateOfPubAdd.Name)
            {
                if (!String.IsNullOrWhiteSpace(textBox_DateOfPubAdd.Text))
                {

                }
                else
                {
                    textBox_DateOfPubAdd.Text = null;
                }
            }
        }
    }
}
