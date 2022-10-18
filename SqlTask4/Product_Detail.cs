using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class Product_Detail
    {

        private string name;
        private int productId;
        private int detailMaterialId;
        private int numberOfParts;

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getProductId()
        {
            return productId;
        }
        public void setProductId(int productId)
        {
            this.productId = productId;
        }

        public int getDetailMaterialId()
        {
            return detailMaterialId;
        }
        public void setDetailMaterialId(int detailMaterialId)
        {
            this.detailMaterialId = detailMaterialId;
        }

        public int getNumberOfParts()
        {
            return numberOfParts;
        }
        public void setNumberOfParts(int numberOfParts)
        {
            this.numberOfParts = numberOfParts;
        }

    }
}
