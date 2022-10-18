using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class DetailController
    {
        DetailDao detailDao = new DetailDao();

        public void createDetails() {
            Detail_Material detail_Material = new Detail_Material();

            Console.WriteLine("Введите id фигуру детали:");
            detail_Material.setDetail_id(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите id материала детали:");
            detail_Material.setMaterial_alloy_id(int.Parse(Console.ReadLine()));
            Console.WriteLine("Введите вес детали в граммах:");
            detail_Material.setMaterialСonsumptionInGram(int.Parse(Console.ReadLine()));

            int result = detailDao.createDetails(detail_Material);
            Console.WriteLine("Добавлено деталей: {0}", result);
            }

    }
}
