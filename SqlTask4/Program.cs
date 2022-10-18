using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class Program
    {
        static string actionOption = "Введите цифры действия, которое хотите совершить с базой данных: " +
            "1 - добавить деталь; 2 - изменить количество деталей; 3 - удалить детали из изделия;" +
            "4 - получить стоимость изделия; 5 - выход.";

        static void Main(string[] args)
        {
            DBEngine db = new DBEngine();
            DetailController detailController = new DetailController();
            ProductController productController = new ProductController();
            CalculateController calculateController = new CalculateController();

            while (true)
            {
                Console.WriteLine(actionOption);
                string variant = Console.ReadLine();

                if (variant.Equals("1"))
                {
                    detailController.createDetails();
                }
                if (variant.Equals("2"))
                {
                    productController.updateDetailInProduct();
                }
                if (variant.Equals("3"))
                {
                    productController.deleteDetailFromTheProduct();
                }
                if (variant.Equals("4"))
                {
                    calculateController.calculateTheCost();
                }
                if (variant.Equals("5")) { break; }
            }

            db.closeConnection();
        }
    }
}
