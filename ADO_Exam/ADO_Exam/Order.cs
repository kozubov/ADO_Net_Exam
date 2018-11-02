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
    public partial class Order : Form
    {
        public Order(List<Disc> discs, string lastName, string firstName)
        {
            InitializeComponent();
            button_OrderOK.Click += Button_OrderOK_Click;
            Checkout(discs, lastName, firstName);
        }

        private void Button_OrderOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Checkout(List<Disc> discs, string lastName, string firstName)
        {
            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var user = db.Buyer.Where(z => z.LastName == lastName && z.FirstName == firstName).ToList();
                if (user.Count != 0)
                {
                    foreach (Buyer VARIABLE in user)
                    {
                        int col = VARIABLE.Quantity;
                        col += discs.Count;
                        VARIABLE.Quantity = col;
                        db.Buyer.AddOrUpdate(VARIABLE);
                        db.SaveChanges();
                    }
                }
                else
                {
                    Buyer buyer = new Buyer { Quantity = discs.Count, LastName = lastName, FirstName = firstName };
                    db.Buyer.Add(buyer);
                    db.SaveChanges();
                }
            }

            using (MusicStoreEntities1 db = new MusicStoreEntities1())
            {
                var user = db.Buyer.Where(z => z.LastName == lastName && z.FirstName == firstName).ToList();
                foreach (var VARIABLE in user)
                {
                    var sumPrise = db.Checkk.Where(z => z.IdBuyer == VARIABLE.Id).Select(z => z.Summ).ToList();
                    decimal sum = 0;
                    foreach (decimal VAR in sumPrise)
                    {
                        sum += VAR;
                    }

                    if (sum > 1000)
                    {
                        decimal s = 0;
                        decimal nous = 0;
                        panel_OrderDiscount.Visible = true;
                        foreach (var V in discs)
                        {
                            decimal pr = 0;
                            s += V.SellPrice;
                            pr = (V.SellPrice - 15);
                            nous = nous + (V.SellPrice - 15);
                            Checkk checkk = new Checkk
                            {
                                DataSale = DateTime.Now.Date,
                                IdDisc = V.Id,
                                IdBuyer = VARIABLE.Id,
                                Summ = pr
                            };
                            db.Checkk.Add(checkk);
                        }

                        db.SaveChanges();
                        label_TotalDiscount.Text = s.ToString();
                        label_ToPayDiscount.Text = nous.ToString();
                    }
                    else
                    {
                        decimal s = 0;
                        panel_OrderDefault.Visible = true;
                        foreach (var V in discs)
                        {
                            s += V.SellPrice;
                            Checkk checkk = new Checkk
                            {
                                DataSale = DateTime.Now.Date,
                                IdDisc = V.Id,
                                IdBuyer = VARIABLE.Id,
                                Summ = V.SellPrice
                            };
                            db.Checkk.Add(checkk);
                        }
                        db.SaveChanges();
                        label_TotalDefault.Text = s.ToString();
                    }
                }
            }
        }
    }
}
