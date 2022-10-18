using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class Detail_Material
    {

        private int detail_id;
        private int material_alloy_id;
        private double materialСonsumptionInGram;

        public int getDetail_id()
        {
            return detail_id;
        }
        public void setDetail_id(int detail_id)
        {
            this.detail_id = detail_id;
        }

        public int getMaterial_alloy_id()
        {
            return material_alloy_id;
        }
        public void setMaterial_alloy_id(int material_alloy_id)
        {
            this.material_alloy_id = material_alloy_id;
        }

        public double getMaterialСonsumptionInGram()
        {
            return materialСonsumptionInGram;
        }
        public void setMaterialСonsumptionInGram(double materialСonsumptionInGram)
        {
            this.materialСonsumptionInGram = materialСonsumptionInGram;
        }
    }
}
