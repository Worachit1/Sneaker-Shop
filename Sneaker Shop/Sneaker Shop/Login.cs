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
    public partial class Login : Form
    {
        private Member _member;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string lastname = tbLastName.Text;
            string mail = tbMail.Text; 
            string phone = tbPhone.Text;
            string sneaker = cbbSneakers.Text;
            int iAge = 0;
            try
            {
                string age = tbAge.Text;
                iAge = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do somthing if have some exception
                MessageBox.Show("คุณใส่ข้อมูลไม่ถูกต้อง");
                return;
            }
            _member = new Member(name, lastname, mail, phone, iAge , sneaker);
            this.DialogResult = DialogResult.OK;

            tbName.Text = "";
            tbLastName.Text = "";
            tbMail.Text = "";
            tbPhone.Text = "";
            tbAge.Text = "";
        }
        public Member getMem() { return _member; }
    }
}
