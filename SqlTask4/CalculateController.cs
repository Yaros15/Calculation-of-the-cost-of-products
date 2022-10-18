using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class CalculateController
    {
        private CalculateDao calculateDao = new CalculateDao();

        public void calculateTheCost() {
            double summ = 0;
            string name;
            Console.WriteLine("Введите id изделия для получения его суммы: ");
            int productId = Int32.Parse(Console.ReadLine());
            List<Product_Detail> products = calculateDao.productDetail(productId);

            foreach (var product in products) {
                name = product.getName();
                int detail_material = product.getDetailMaterialId();
                int amount = product.getNumberOfParts();

                Detail_Material detail = calculateDao.detailMaterial(detail_material);
                double weight = detail.getMaterialСonsumptionInGram();
                int material_alloy = detail.getMaterial_alloy_id();

                double pricePerKG = calculateDao.materialAlloy(material_alloy);

                summ += amount * (weight * (pricePerKG / 1000));
            }

            Console.WriteLine(summ);
        }

    }
}
