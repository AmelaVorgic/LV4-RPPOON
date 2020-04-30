using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV4RPPOON
{
    class DiscountedItem : RentableDecorator
    {
        private readonly double discountPercentage;
        public DiscountedItem(IRentable rentable, double percentage) : base(rentable)
        {
            this.discountPercentage = percentage;
        }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() - base.CalculatePrice() * (this.discountPercentage / 100);
        }
        public override String Description
        {
            get
            {
                return "Item on discount: " + base.Description + " now at " + discountPercentage + "% off!";
            }
        }
    }
}