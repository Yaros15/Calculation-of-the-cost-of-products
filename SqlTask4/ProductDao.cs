using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class ProductDao
    {
        private string updateChangesInTheNumberOfParts = "UPDATE product_detail SET numberOfParts= @n_o_p WHERE product_id = @p_id AND detail_material_id = @d_m_id";
        private string RemovingPartsFromTheProduct = "DELETE * FROM product_detail WHERE product_id = @p_id AND detail_material_id = @d_m_id";

        private DBEngine db = new DBEngine();
        

        public int updateDetailInProduct(Product_Detail product_Detail) {

            db.openConnection();
            MySqlCommand command = new MySqlCommand(updateChangesInTheNumberOfParts, db.getConnection());
            command.Parameters.Add("@n_o_p", MySqlDbType.Int32).Value = product_Detail.getNumberOfParts();
            command.Parameters.Add("@p_id", MySqlDbType.Int32).Value = product_Detail.getProductId();
            command.Parameters.Add("@d_m_id", MySqlDbType.Int32).Value = product_Detail.getDetailMaterialId();
            int updateDetail = command.ExecuteNonQuery();
            return updateDetail;

        }

        public int deleteDetailFromTheProduct(int product_id, int detail_material_id) {

            db.openConnection();
            MySqlCommand command = new MySqlCommand(RemovingPartsFromTheProduct, db.getConnection());
            command.Parameters.Add("@p_id", MySqlDbType.Int32).Value = product_id;
            command.Parameters.Add("@d_m_id", MySqlDbType.Int32).Value = detail_material_id;
            int deletingDetail = command.ExecuteNonQuery();
            return deletingDetail;

        }

    }
}
