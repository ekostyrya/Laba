using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelleryClass
{
    public class Jewellery
    {
        double _Weight;
        public double Weight
        {
            get
            {
                return _Weight;
            }
        }

        double _Price;
        public double Price
        {
            get
            {
                return _Price;
            }
        }

        string _Model;
        public string Model
        {
            get
            {
                return _Model;
            }
        }


        public Jewellery(double weight, double price, string model)
        {
            if (weight <= 0)
                throw new ArgumentOutOfRangeException("weight");
            if (price <= 0)
                throw new ArgumentOutOfRangeException("price");
            if (model == "")
                throw new ArgumentNullException("model");
            this._Model = model ;
            this._Price = price;
            this._Weight = weight;
        }
    }

    public class Purchases
    {
       Jewellery[] Rings;

       public Jewellery[] Golden_rings
        {
            get
            {
                return Rings;
            }
        }

        public int Count()
        {
            return this.Rings.Count();
        }

        public Purchases(params Jewellery[] rings)
        {
            if (rings.Count() == 0)
                throw new ArgumentNullException("rings");
            this.Rings = rings;
        }


    }

    public class PurchasesCounter
    {
        Purchases JewelleryBox;

        public PurchasesCounter(Purchases box)
        {
            this.JewelleryBox = box;
        }

        public double GetTotalPrice()
        {
            double Price = 0;
            for (int i = 0; i < JewelleryBox.Count(); i++)
                Price += JewelleryBox.Golden_rings[i].Price * JewelleryBox.Golden_rings[i].Weight;
            return Price;
        }

        public double GetTotalWeight()
        {
            double Weight = 0;
            for (int i = 0; i < JewelleryBox.Count(); i++)
                Weight += JewelleryBox.Golden_rings[i].Weight;
            return Weight;
        }
    }
}


