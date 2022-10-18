using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class initTables
    {
        private string createTableAlloy = "CREATE TABLE alloy (id INT PRIMARY KEY AUTO_INCREMENT, alloyAdmixture VARCHAR(30)";
        private string createTableMaterial = "CREATE TABLE material (id INT PRIMARY KEY AUTO_INCREMENT, materialName VARCHAR(30)";
        private string createTableMaterial_Alloy = "CREATE TABLE material_alloy (id INT PRIMARY KEY AUTO_INCREMENT, " +
            "id_material INT FOREIGN KEY (`id_material`) REFERENCES `material`(`id`), id_alloy INT FOREIGN KEY (`id_material`) REFERENCES `material`(`id`), pricePerKG DECIMAL";
        private string createTableDetail = "CREATE TABLE detail (id INT PRIMARY KEY AUTO_INCREMENT, partName VARCHAR(30)";
        private string createTableDetail_Material = "CREATE TABLE detail_material (id INT PRIMARY KEY AUTO_INCREMENT, " +
            "detail_id INT FOREIGN KEY (`detail_id`) REFERENCES `detail`(`id`), material_alloy_id INT FOREIGN KEY (`material_alloy_id`) REFERENCES `material_alloy`(`id`), materialСonsumptionInGram INT";
        private string createTableProduct = "CREATE TABLE product (id INT PRIMARY KEY AUTO_INCREMENT, productName VARCHAR(30)";
        private string createTableProduct_Detail = "CREATE TABLE product_detail (id INT PRIMARY KEY AUTO_INCREMENT, " +
            "product_id INT FOREIGN KEY (`product_id`) REFERENCES `product`(`id`), detail_material_id INT FOREIGN KEY (`detail_material_id`) REFERENCES `detail_material`(`id`), numberOfParts INT";

        `
        private string insertTableAlloy = "INSERT INTO `alloy`(`alloyAdmixture`) " +
            "VALUES (легированная), (углеродистая)";
        private string insertTableMaterial = "INSERT INTO `material`(`materialName`) " +
            "VALUES (сталь), (алюминий)";
        private string insertTableMaterial_Alloy = "INSERT INTO `material_alloy`(`id_material`, `id_alloy`, `pricePerKG`) " +
            "VALUES (1, 1, 2000), (1, 2, 3000), (2, NULL, 1000)";
        private string insertTableDetail = "INSERT INTO `detail`(`partName`) VALUES (круг), (лист), (пруток), (проволока)";
        private string insertTableDetail_Material = "INSERT INTO `detail_material`(`detail_id`, `material_alloy_id`, `materialСonsumptionInGram`) " +
            "VALUES ( 1, 1, 700), ( 1, 2, 600), ( 2, 2, 800), ( 3, 2, 400), ( 4, 3, 300)";
        private string insertTableProduct = "INSERT INTO `product`(`productName`) VALUES (двигатель), (капсула)";
        private string insertTableProduct_Detail = "INSERT INTO `product_detail`(`product_id`, `detail_material_id`, `numberOfParts`) " +
            "VALUES ( 1, 1, 3), ( 1, 3, 4), ( 1, 5, 8), ( 2, 3, 10), ( 2, 2, 3), ( 2, 4, 10)";

    }
}
