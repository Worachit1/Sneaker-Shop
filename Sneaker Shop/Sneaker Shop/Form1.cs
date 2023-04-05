using Sneaker_Shop.product;
namespace Sneaker_Shop
{
    public partial class Form1 : Form
    {
        List<Member> member = new List<Member>();
        List<Product> product;
        Product selectedProduct;
        public Form1()
        {
            InitializeComponent();
            product = new List<Product>();
            product.Add(new AJonexOffWhite());
            product.Add(new PG3NASA());
            product.Add(new AZPegasus39());
            product.Add(new WhyNotZ4());
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();

            if (login.DialogResult == DialogResult.OK)
            {
                Member newmember = login.getMem();
                //Add new Player to List
                this.member.Add(newmember);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = member;
                //Add list to Datagrid view
                login.Close();
            }
        }
        // AJonexOffWhite
        private void button5_Click(object sender, EventArgs e)
        {
            selectedProduct = product[0];
            this.pictureBox1.Image = selectedProduct.getImage();
            this.tbNamePD.Text = selectedProduct.getName();
            this.tbPricePD.Text = selectedProduct.getPrice().ToString();
        }
        // PG3NASA
        private void button8_Click(object sender, EventArgs e)
        {
            selectedProduct = product[1];
            this.pictureBox1.Image = selectedProduct.getImage();
            this.tbNamePD.Text = selectedProduct.getName();
            this.tbPricePD.Text = selectedProduct.getPrice().ToString();
        }
        // AZPegasus39
        private void button6_Click(object sender, EventArgs e)
        {
            selectedProduct = product[2];
            this.pictureBox1.Image = selectedProduct.getImage();
            this.tbNamePD.Text = selectedProduct.getName();
            this.tbPricePD.Text = selectedProduct.getPrice().ToString();
        }
        // WhyNotZ4
        private void button7_Click(object sender, EventArgs e)
        {
            selectedProduct = product[3];
            this.pictureBox1.Image = selectedProduct.getImage();
            this.tbNamePD.Text = selectedProduct.getName();
            this.tbPricePD.Text = selectedProduct.getPrice().ToString();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            string readfile = File.ReadAllText(filename);
            tbOpen.Text = readfile;
        
    }
 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Save data form list to CSV file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Member item in member)
                    {
                        writer.WriteLine(String.Format("ชื่อ {0}  นามสกุล {1}  เบอร์โทร {2} รองเท้าที่เลือก {3}",
                        item.Name,
                        item.Lastname,
                        item.Phone,
                        item.Sneaker));
                        
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.price=tbPricePD.Text;
            pay.Show();
            
        }
    }
    
}