using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Shop.product
{
    internal class PG3NASA : Product
    {
        public PG3NASA()
        {
            this.name = "Nike PG 3 NASA";
            this._image = Properties.Resources.PG3NASA;
            this.price = 6300;
        }
    }
}
