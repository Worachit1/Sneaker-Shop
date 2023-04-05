using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sneaker_Shop
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string pay = this.tbPay.Text;
            string price = this.tbPrice.Text;

            double Pay = Convert.ToDouble(pay);
            double Price = Convert.ToDouble(price);
            if(Pay>=Price)
            {
                double Change = Pay - Price;
                tbChange.Text = Change.ToString();
                MessageBox.Show("ชำระเงินสำเร็จ");

            }
            else
            {
                Exception ex;
                MessageBox.Show("จำนวนเงินไม่เพียงพอไม่สามารถซื้อได้");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string price;
        private void Pay_Load(object sender, EventArgs e)
        {
            tbPrice.Text=price;
        }
    }
}
