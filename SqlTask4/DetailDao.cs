using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask4
{
    class DetailDao
    {

        private string createDetail = "INSERT INTO detail_material(detail_id, material_alloy_id, materialСonsumptionInGram) VALUES ( @de_id, @ma_al_id, @ma_co_gr,)";

        DBEngine db = new DBEngine();

        public int createDetails(Detail_Material detail_Material) {

            db.openConnection();
            MySqlCommand command = new MySqlCommand(createDetail, db.getConnection());
            command.Parameters.Add("@de_id", MySqlDbType.Int32).Value = detail_Material.getDetail_id();
            command.Parameters.Add("@ma_al_id", MySqlDbType.Int32).Value = detail_Material.getMaterial_alloy_id();
            command.Parameters.Add("@ma_co_gr", MySqlDbType.Double).Value = detail_Material.getMaterialСonsumptionInGram();
            int addDetail_Material = command.ExecuteNonQuery();
            return addDetail_Material;

        }

    }
}
