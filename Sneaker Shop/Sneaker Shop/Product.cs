using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Shop.product
{
    public class Product
    {
        protected string name;
        protected int price;
        protected Bitmap _image;

        public Bitmap getImage() { return _image; }
        public string getName() { return this.name; }
        public int getPrice() { return this.price; }

    }
}


