using eShopYellow.ua.DataModel;
using eShopYellow.ua.GUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eShopYellow.ua
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 10, y = 10;
            Model1 db = new Model1();
            foreach (var item in db.ProductInfoList)
            {
                this.Controls.Add(new ProductControl(item.Name, item.Price, item.ImageUrl)
                { Location = new Point(x, y) });
                x += 210;

                if (x /210 >= 3)
                {
                    y += 190;
                    x = 10;
                }
            }
        }
    }
}
