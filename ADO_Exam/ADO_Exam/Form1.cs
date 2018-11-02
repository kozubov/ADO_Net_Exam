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
    public partial class Form1 : Form
    {
        private int panel_col = 4;
        private int pages = 1;
        private int one = 1;
        private int two = 2;
        private int pagesSearch = 1;
        private int oneSearch = 1;
        private int twoSearch = 2;
        private int SearchCount = 0;
        private string start = null;
        private List<Disc> cart = new List<Disc>();
        public Form1()
        {
            InitializeComponent();
            Text = "Music Store";
            Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //main buttons
            button_Options.Click += Button_Options_Click;
            button_Search.Click += Button_Search_Click;
            button_Cart.Click += Button_Cart_Click;
            button_Home.Click += Button_Home_Click;

            //search panel
            button_SearchClose.Click += Button_SearchClose_Click;
            // -- search by buttons
            button_SearchByTitle.Click += Button_SearchBy_Click;
            button_SearchBySinger.Click += Button_SearchBySinger_Click;
            button_SearchByGenre.Click += Button_SearchByGenre_Click;
            // -- textbox
            textBox_SearchInput.TextChanged += TextBox_SearchInput_TextChanged;

            //singers panels
            button_AddToCart.Click+= new EventHandler(List_Cart);
            button_AddToCart1.Click += new EventHandler(List_Cart);
            button_AddToCart2.Click += new EventHandler(List_Cart);
            button_AddToCart3.Click += new EventHandler(List_Cart);

            //navigations
            //-- first
            button_S2Left.Click += new EventHandler(Button_List);
            button_S2_1.Click += new EventHandler(Button_List);
            button_S2_2.Click += new EventHandler(Button_List);
            button_S2Right.Click += new EventHandler(Button_List);
            //-- second
            button6_Search_Left.Click += new EventHandler(Button_List);
            button8_Search_one.Click += new EventHandler(Button_List);
            button9_Search_two.Click += new EventHandler(Button_List);
            button7_Search_Right.Click += new EventHandler(Button_List);


        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            panel6_Second.Visible = false;
            pages = 1;
            one = 1;
            two = 2;
            Show_Tovar();
        }

        private void Button_SearchByGenre_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                MessageBox.Show("Fill the field", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            panel5_Search.Visible = false;
            pagesSearch = 1;
            oneSearch = 1;
            twoSearch = 2;
            SearchCount = 3;
            Search_Genre();
        }

        private void Button_SearchBySinger_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                MessageBox.Show("Fill the field", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            panel5_Search.Visible = false;
            pagesSearch = 1;
            oneSearch = 1;
            twoSearch = 2;
            SearchCount = 2;
            Search_Singer();
        }

        private void TextBox_SearchInput_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox_Search.Text))
            {

            }
            else
            {
                textBox_Search.Text = null;
            }
        }

        private void Button_SearchBy_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                MessageBox.Show("Заполните поле для поиска", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            panel5_Search.Visible = false;
            pagesSearch = 1;
            oneSearch = 1;
            twoSearch = 2;
            SearchCount = 1;
            Search_DiscTitle();
        }

        private void Button_SearchClose_Click(object sender, EventArgs e)
        {
            panel5_Search.Visible = false;
        }

        private void Button_Cart_Click(object sender, EventArgs e)
        {
            Cart Kor = new Cart(this, cart);
            if (Kor.ShowDialog() == DialogResult.OK)
            {
                Show_Tovar();
            }
        }

        private void List_Cart(object sender, EventArgs e)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                Button button = sender as Button;
                if (button.Name == button_AddToCart.Name)
                {
                    int id = Convert.ToInt32(label_Id1.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        cart.Add(disc);
                    }
                }
                else if (button.Name == button_AddToCart1.Name)
                {
                    int id = Convert.ToInt32(label_Id2.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        cart.Add(disc);
                    }
                }
                else if (button.Name == button_AddToCart2.Name)
                {
                    int id = Convert.ToInt32(label_Id3.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        cart.Add(disc);
                    }
                }
                else if (button.Name == button_AddToCart3.Name)
                {
                    int id = Convert.ToInt32(label_Id4.Text);
                    var disc = db.Disc.FirstOrDefault(z => z.Id == id);
                    if (disc != null)
                    {
                        cart.Add(disc);
                    }
                }
            }

            label_CartCounter.Text = cart.Count.ToString();
        }

        public void SetList(List<Disc> disc)
        {
            cart = disc;
            label_CartCounter.Text = cart.Count.ToString();
        }

        private void Button_List(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (button.Name == button6_Search_Left.Name)
            {
                two = one;
                one--;
                pages = one;
                button8_Search_one.Text = one.ToString();
                button9_Search_two.Text = two.ToString();
                Show_Tovar();
            }
            else if (button.Name == button8_Search_one.Name)
            {
                pages = one;
                button8_Search_one.Text = one.ToString();
                button9_Search_two.Text = two.ToString();
                Show_Tovar();
            }
            else if (button.Name == button9_Search_two.Name)
            {
                one = two;
                pages = one;
                button8_Search_one.Text = one.ToString();
                two++;
                button9_Search_two.Text = two.ToString();
                button6_Search_Left.Visible = true;
                Show_Tovar();
            }
            else if (button.Name == button7_Search_Right.Name)
            {
                one = two;
                pages = one;
                button8_Search_one.Text = one.ToString();
                two++;
                button9_Search_two.Text = two.ToString();
                button6_Search_Left.Visible = true;
                Show_Tovar();
            }
            else if (button.Name == button_S2Left.Name)
            {
                twoSearch = oneSearch;
                oneSearch--;
                pagesSearch = oneSearch;
                button_S2_1.Text = oneSearch.ToString();
                button_S2_2.Text = twoSearch.ToString();
                if (SearchCount == 1)
                {
                    Search_DiscTitle();
                }
                else if (SearchCount == 2)
                {
                    Search_Singer();
                }
                else if (SearchCount == 3)
                {
                    Search_Genre();
                }
            }
            else if (button.Name == button_S2_1.Name)
            {
                pagesSearch = oneSearch;
                button_S2_1.Text = oneSearch.ToString();
                button_S2_2.Text = twoSearch.ToString();
                if (SearchCount == 1)
                {
                    Search_DiscTitle();
                }
                else if (SearchCount == 2)
                {
                    Search_Singer();
                }
                else if (SearchCount == 3)
                {
                    Search_Genre();
                }
            }
            else if (button.Name == button_S2_2.Name)
            {
                oneSearch = twoSearch;
                pagesSearch = oneSearch;
                button8_Search_one.Text = one.ToString();
                twoSearch++;
                button_S2_2.Text = two.ToString();
                button_S2Left.Visible = true;
                if (SearchCount == 1)
                {
                    Search_DiscTitle();
                }
                else if (SearchCount == 2)
                {
                    Search_Singer();
                }
                else if (SearchCount == 3)
                {
                    Search_Genre();
                }
            }
            else if (button.Name == button_S2Right.Name)
            {
                oneSearch = twoSearch;
                pagesSearch = oneSearch;
                button8_Search_one.Text = one.ToString();
                twoSearch++;
                button_S2_2.Text = two.ToString();
                button_S2Left.Visible = true;
                if (SearchCount == 1)
                {
                    Search_DiscTitle();
                }
                else if (SearchCount == 2)
                {
                    Search_Singer();
                }
                else if (SearchCount == 3)
                {
                    Search_Genre();
                }
            }


            if (one == 1)
            {
                button6_Search_Left.Visible = false;
            }

            if (oneSearch == 1)
            {
                button_S2Left.Visible = false;
            }


        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            panel5_Search.Visible = true;
        }

        private void Button_Options_Click(object sender, EventArgs e)
        {
            AdminPass admin = new AdminPass();
            admin.ShowDialog();
        }

        private void Show_Tovar()
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            label_Hot1.Visible = false;
            label_Hot2.Visible = false;
            label_Hot3.Visible = false;
            label_Hot4.Visible = false;
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                int col_poz = 0;
                var disc = db.Disc.OrderBy(z => z.Id).Skip((pages - 1) * panel_col).Take(panel_col).ToList();
                if (disc.Count < 4)
                {
                    button9_Search_two.Visible = false;
                    button7_Search_Right.Visible = false;
                }
                else
                {
                    button9_Search_two.Visible = true;
                    button7_Search_Right.Visible = true;
                }
                foreach (var disc1 in disc)
                {
                    if (col_poz == 0)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot1.Visible = true;
                        }
                        panel1.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox1.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox1.Image = bitmap;

                        }
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer.Text = disc1.Singer;
                        label_Disc.Text = disc1.DiskTitle;
                        label_Publisher.Text = disc1.Publisher;
                        label_Tracks.Text = disc1.Tracks.ToString();
                        label_Genre.Text = disc1.Genre;
                        label_Year.Text = disc1.YearPublishing.ToString("d");
                        label_Price1.Text = disc1.SellPrice.ToString();
                        label_Id1.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 1)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot2.Visible = true;
                        }
                        panel2.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox2.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox2.Image = bitmap;
                        }
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer2.Text = disc1.Singer;
                        label_Disk2.Text = disc1.DiskTitle;
                        label_Publisher2.Text = disc1.Publisher;
                        label_Tracks2.Text = disc1.Tracks.ToString();
                        label_Genre2.Text = disc1.Genre;
                        label_Year2.Text = disc1.YearPublishing.ToString("d");
                        label_Price2.Text = disc1.SellPrice.ToString();
                        label_Id2.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 2)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot3.Visible = true;
                        }
                        panel3.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox3.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox3.Image = bitmap;
                        }
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer3.Text = disc1.Singer;
                        label_Disk3.Text = disc1.DiskTitle;
                        label_Publisher3.Text = disc1.Publisher;
                        label_Tracks3.Text = disc1.Tracks.ToString();
                        label_Genre3.Text = disc1.Genre;
                        label_Year3.Text = disc1.YearPublishing.ToString("d");
                        label_Price3.Text = disc1.SellPrice.ToString();
                        label_Id3.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 3)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot4.Visible = true;
                        }
                        panel4.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox4.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox4.Image = bitmap;
                        }
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer4.Text = disc1.Singer;
                        label_Disk4.Text = disc1.DiskTitle;
                        label_Publisher4.Text = disc1.Publisher;
                        label_Tracks4.Text = disc1.Tracks.ToString();
                        label_Genre4.Text = disc1.Genre;
                        label_Year4.Text = disc1.YearPublishing.ToString("d");
                        label_Price4.Text = disc1.SellPrice.ToString();
                        label_Id4.Text = disc1.Id.ToString();
                    }

                    col_poz++;
                }
            }
        }

        private void Search_Genre()
        {
            if (textBox_Search.Text != "")
            {
                start = textBox_Search.Text;
                textBox_Search.Text = "";
            }
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Disc.Where(z => z.Genre.StartsWith(start)).OrderBy(z => z.Id).Skip((pagesSearch - 1) * panel_col).Take(panel_col).ToList();
                Show_Search(disc);
            }
        }

        private void Show_Search(List<Disc> disc)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            label_Hot1.Visible = false;
            label_Hot2.Visible = false;
            label_Hot3.Visible = false;
            label_Hot4.Visible = false;
            panel6_first.Visible = true;
            int col_poz = 0;
            if (disc.Count < 4)
            {
                button_S2_2.Visible = false;
                button_S2Right.Visible = false;
            }
            else
            {
                button_S2_2.Visible = true;
                button_S2Right.Visible = true;
            }

            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                foreach (var disc1 in disc)
                {
                    if (col_poz == 0)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot1.Visible = true;
                        }
                        panel1.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox1.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox1.Image = bitmap;
                        }
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer.Text = disc1.Singer;
                        label_Disc.Text = disc1.DiskTitle;
                        label_Publisher.Text = disc1.Publisher;
                        label_Tracks.Text = disc1.Tracks.ToString();
                        label_Genre.Text = disc1.Genre;
                        label_Year.Text = disc1.YearPublishing.ToString("d");
                        label_Price1.Text = disc1.CostPrice.ToString();
                        label_Id1.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 1)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot2.Visible = true;
                        }
                        panel2.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox2.Image = bitmap;
                        }
                        catch (Exception e)
                        {
                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox2.Image = bitmap;
                        }
                        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer2.Text = disc1.Singer;
                        label_Disk2.Text = disc1.DiskTitle;
                        label_Publisher2.Text = disc1.Publisher;
                        label_Tracks2.Text = disc1.Tracks.ToString();
                        label_Genre2.Text = disc1.Genre;
                        label_Year2.Text = disc1.YearPublishing.ToString("d");
                        label_Price2.Text = disc1.CostPrice.ToString();
                        label_Id2.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 2)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot3.Visible = true;
                        }
                        panel3.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox3.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox3.Image = bitmap;
                        }
                        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer3.Text = disc1.Singer;
                        label_Disk3.Text = disc1.DiskTitle;
                        label_Publisher3.Text = disc1.Publisher;
                        label_Tracks3.Text = disc1.Tracks.ToString();
                        label_Genre3.Text = disc1.Genre;
                        label_Year3.Text = disc1.YearPublishing.ToString("d");
                        label_Price3.Text = disc1.CostPrice.ToString();
                        label_Id3.Text = disc1.Id.ToString();
                    }
                    else if (col_poz == 3)
                    {
                        var hit = db.Checkk.Where(z => z.IdDisc == disc1.Id).ToList();
                        if (hit.Count > 10)
                        {
                            label_Hot4.Visible = true;
                        }
                        panel4.Visible = true;
                        try
                        {
                            Bitmap bitmap = new Bitmap(disc1.Cover);
                            pictureBox4.Image = bitmap;
                        }
                        catch (Exception e)
                        {

                            Bitmap bitmap = new Bitmap(@"..\..\Covers\default.png");
                            pictureBox4.Image = bitmap;
                        }
                        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                        label_Singer4.Text = disc1.Singer;
                        label_Disk4.Text = disc1.DiskTitle;
                        label_Publisher4.Text = disc1.Publisher;
                        label_Tracks4.Text = disc1.Tracks.ToString();
                        label_Genre4.Text = disc1.Genre;
                        label_Year4.Text = disc1.YearPublishing.ToString("d");
                        label_Price4.Text = disc1.CostPrice.ToString();
                        label_Id4.Text = disc1.Id.ToString();
                    }

                    col_poz++;
                }
            }
        }

        private void Search_Singer()
        {
            if (textBox_Search.Text != "")
            {
                start = textBox_Search.Text;
                textBox_Search.Text = "";
            }
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Disc.Where(z => z.Singer.StartsWith(start)).OrderBy(z => z.Id).Skip((pagesSearch - 1) * panel_col).Take(panel_col).ToList();
                Show_Search(disc);
            }
        }

        private void Search_DiscTitle()
        {
            if (textBox_Search.Text != "")
            {
                start = textBox_Search.Text;
                textBox_Search.Text = "";
            }
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var disc = db.Disc.Where(z => z.DiskTitle.StartsWith(start)).OrderBy(z => z.Id).Skip((pagesSearch - 1) * panel_col).Take(panel_col).ToList();
                Show_Search(disc);
            }
        }
    }
}
