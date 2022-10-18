using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class ProductController
    {

        private ProductDao productDao;

        public void updateDetailInProduct() {

            Product_Detail product_Detail = new Product_Detail();
            productDao = new ProductDao();
            Console.WriteLine("Введите id изделия: ");
            product_Detail.setProductId(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Введите id детали: ");
            product_Detail.setDetailMaterialId(Int32.Parse(Console.ReadLine()));
            Console.WriteLine("Введите количество деталей: ");
            product_Detail.setNumberOfParts (Int32.Parse(Console.ReadLine()));
            int result = productDao.updateDetailInProduct(product_Detail);
            Console.WriteLine("Изменено деталей: {0}", result);

        }

        public void deleteDetailFromTheProduct() {

            productDao = new ProductDao();
            Console.WriteLine("Введите id изделия: ");
            int productId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите id удаляемой детали: ");
            int detailId = Int32.Parse(Console.ReadLine());
            int result = productDao.deleteDetailFromTheProduct(productId, detailId);
            Console.WriteLine("Удалено деталий: {0}", result);

        }

    }
}
