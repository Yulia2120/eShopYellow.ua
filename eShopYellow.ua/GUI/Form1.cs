using eShopYellow.ua.DataModel;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butBrouse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opf = new OpenFileDialog()
            { Filter = "Choose Image(*.JPG; *.PNG;*.GIF)|*.jpg; *.png; *.gif" })
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pBoxImage.Image = Image.FromFile(opf.FileName);
                    ProductInfo obj = productInfoBindingSource.Current as ProductInfo;
                    if (obj != null)
                        obj.ImageUrl = opf.FileName;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                productInfoBindingSource.DataSource = db.ProductInfoList.ToList();
            }
            ProductInfo obj = productInfoBindingSource.Current as ProductInfo;
            if (obj != null)
                pBoxImage.Image = Image.FromFile(obj.ImageUrl);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            pBoxImage.Image = null;
            productInfoBindingSource.Add(new ProductInfo());
            productInfoBindingSource.MoveLast();
            txtBoxName.Focus();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            txtBoxDes.Enabled = true;
            txtBoxName.Focus();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            productInfoBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (Model1 db = new Model1())
                {
                    ProductInfo obj = productInfoBindingSource.Current as ProductInfo;
                    if (obj != null)
                    {
                        if (db.Entry<ProductInfo>(obj).State == System.Data.Entity.EntityState.Detached)
                            db.Set<ProductInfo>().Attach(obj);
                        db.Entry<ProductInfo>(obj).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        productInfoBindingSource.RemoveCurrent();
                        pBoxImage.Image = null;
                    }
                }
            }
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductInfo obj = productInfoBindingSource.Current as ProductInfo;
            if (obj != null)
                pBoxImage.Image = Image.FromFile(obj.ImageUrl);
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            using (Model1 db = new Model1())
            {
                ProductInfo obj = productInfoBindingSource.Current as ProductInfo;
                if (obj != null)
                {
                    if (db.Entry<ProductInfo>(obj).State == System.Data.Entity.EntityState.Detached)
                        db.Set<ProductInfo>().Attach(obj);
                    if (obj.Id == 0)
                        db.Entry<ProductInfo>(obj).State = System.Data.Entity.EntityState.Added;
                    else
                        db.Entry<ProductInfo>(obj).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    dataGridView.Refresh();



                }
            }
        }
    }
}
