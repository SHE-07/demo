using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Demo27Test
{
    public partial class MainForm : Form
    {
        string conDb = "host = localhost ; port = 5432; username = postgres; password = 0; database = demo27;";
        public void OutProd()
        {
            NpgsqlConnection con = new NpgsqlConnection(conDb);
            con.Open();
            string sql = @"SELECT products.id, cat.cat, photo, product_name, proiz.proiz, sostav, price
	FROM public.products
	join public.cat ON cat.id = products.cat_fk
	join public.proiz ON proiz.id = products.proiz_fk";
            NpgsqlCommand cmd = new NpgsqlCommand(sql,con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                ProductControl product = new ProductControl();
                product.Cat = reader.GetString(1);
                product.ProdName = reader.GetString(3);
                product.Proiz = reader.GetString(4);
                product.SetLabels();
                flowLayoutPanel1.Controls.Add(product);
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutProd();
        }
    }
}
