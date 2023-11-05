using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_формами_3
{
    public partial class CandyShop : Form
    {
        public CandyShop()
        {
            InitializeComponent();
        }
        public double price;
        public double quantity;
        public double free_quantity;
        public double discount = 0;
        public double total;
        public double package;
        private void Marsianka_CheckedChanged(object sender, EventArgs e)
        {
            price = 52.0;
        }

        private void STEP_CheckedChanged(object sender, EventArgs e)
        {
            price = 43.5;
        }

        private void Twix_CheckedChanged(object sender, EventArgs e)
        {
            price = 69.9;
        }

        private void Snickers_CheckedChanged(object sender, EventArgs e)
        {
            price = 69.9;
        }

        private void Yarche_CheckedChanged(object sender, EventArgs e)
        {
            price = 39.9;
        }

        private void Arbuzik_CheckedChanged(object sender, EventArgs e)
        {
            price = 46.5;
        }

        private void Attache_CheckedChanged(object sender, EventArgs e)
        {
            price = 46.0;
        }

        private void Packaging_CheckedChanged(object sender, EventArgs e)
        {
            package = 5.0;
        }

        private void ChGarden_CheckedChanged(object sender, EventArgs e)
        {
            discount += 0.15;
        }

        private void BirthDay_CheckedChanged(object sender, EventArgs e)
        {
            discount += 0.1;
        }

        private void Sunday_CheckedChanged(object sender, EventArgs e)
        {
            discount += 0.05;
        }

        private void Sat_Fri_CheckedChanged(object sender, EventArgs e)
        {
            free_quantity = 100.0;
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Total_cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Сalculation_Click(object sender, EventArgs e)
        {
            quantity = Convert.ToDouble(Quantity.Text);
            total = quantity/100 * price * (1.0 - discount) + package;
            Total_cost.Text = Convert.ToString(total);
            Total_quantity.Text = Convert.ToString(quantity + free_quantity) + " гр.";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            quantity = 0;
            package = 0.0;
            total = 0.00;
            free_quantity = 0;
            discount = 0;
            Total_cost.Text = "0,00";
            Total_quantity.Text = Convert.ToString(quantity) + " гр.";
            Quantity.Text = Convert.ToString(quantity);
            Packaging.Checked = false;
            Sunday.Checked = false;
            BirthDay.Checked = false;
            Sat_Fri.Checked = false;
            ChGarden.Checked = false;
            STEP.Checked = false;
            Marsianka.Checked = false;
            Yarche.Checked = false;
            Twix.Checked = false;
            Snickers.Checked = false;
            Attache.Checked = false;
            Arbuzik.Checked = false;
        }
    }
}
