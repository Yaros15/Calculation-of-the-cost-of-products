using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class CalculateDao
    {

        private string selectProduct_Detail = "SELECT product.productName, detail_material.id, product_detail.numberOfParts " +
            "FROM product_detail JOIN product ON product.id = product_detail.product_id " +
            "JOIN detail_material ON detail_material.id = product_detail.detail_material_id " +
            "WHERE product_detail.product_id = @p_id";
        private string selectDetail_Material = "SELECT detail_material.material_alloy_id, detail_material.materialСonsumptionInGram " +
            "FROM detail_material JOIN material_alloy ON material_alloy.id = detail_material.material_alloy_id " +
            "WHERE detail_material.id = @d_m_id";
        private string selectMaterial_alloy = "SELECT pricePerKG FROM material_alloy WHERE id = @id";

        private DBEngine db = new DBEngine();
         
        

        public List<Product_Detail> productDetail(int product_id)
        {
            List<Product_Detail> products_Details = new List<Product_Detail>();
            Product_Detail product_Detail;

            db.openConnection();
            MySqlCommand command = new MySqlCommand(selectProduct_Detail, db.getConnection());
            command.Parameters.Add("@p_id", MySqlDbType.Int32).Value = product_id;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                product_Detail = new Product_Detail();
                product_Detail.setName(reader.GetString(0));
                product_Detail.setDetailMaterialId(reader.GetInt32(1));
                product_Detail.setNumberOfParts(reader.GetInt32(2));

                products_Details.Add(product_Detail);
            }
            reader.Close();
            return products_Details;
        }

        public Detail_Material detailMaterial(int detail_Material_Id)
        {
            Detail_Material detail_Material = new Detail_Material();
            db.openConnection();
            MySqlCommand command = new MySqlCommand(selectDetail_Material, db.getConnection());
            command.Parameters.Add("@d_m_id", MySqlDbType.Int32).Value = detail_Material_Id;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                detail_Material.setMaterial_alloy_id(reader.GetInt32(0));
                detail_Material.setMaterialСonsumptionInGram(reader.GetDouble(1));
            }
            reader.Close();
            return detail_Material;
           
        }

        public double materialAlloy(int materialAlloyId)
        {
            double pricePerKG = 0;
            MySqlCommand command = new MySqlCommand(selectMaterial_alloy, db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = materialAlloyId;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pricePerKG = reader.GetDouble(0);
            }
            reader.Close();  
            return pricePerKG;
        }

    }
}
