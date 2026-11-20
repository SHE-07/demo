using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo27Test
{
    public partial class ProductControl : UserControl
    {
        public int prodId;
        public string Cat;
        public string Photo;
        public string ProdName;
        public string Proiz;
        public string Sostav;
        public decimal Price;
        public void SetLabels()
        {
            labelCat.Text = Cat;
            labelProzName.Text = $"{Proiz} | {ProdName}";
        }
        public ProductControl()
        {
            InitializeComponent();
        }
    }
}
