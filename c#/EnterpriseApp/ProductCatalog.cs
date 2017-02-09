using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DataAccess;

namespace BusinessObjs
{
    public class Product : CRUD
    {
        public string nameProd { get; set; }
        public float costProd { get; set; }
        public string DescProd { get; set; }
        public int numProd { get; set; }
        public string imageURL { get; set; }
        public int idBuildSheet_item { get; set; }
        public int idProd { get; set; }

        public Product() { }

        public Product(DataRow dr) 
        {
            this.idProd = int.Parse(dr["ProdId"].ToString());
            this.nameProd = dr["nameProd"].ToString();
            this.numProd = int.Parse(dr["numProd"].ToString());
            this.DescProd = dr["descProd"].ToString();
            this.costProd = float.Parse(dr["costProd"].ToString());
            this.imageURL = dr["imageUrl"].ToString();
            this.idBuildSheet_item = int.Parse(dr["BSId"].ToString());
        }

        public List<Object> getAllProducts()
        {
            List<Object> listProd = new List<Object>();
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();

            ds = dc.getDataSet("usp_SelectProductsAll", null);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Product prod = new Product(dr);
                listProd.Add(prod);
            }

            return listProd;
        }

        public Product retrieve(int id)
        {
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@ProdId", idProd);

            ds = dc.getDataSet("usp_SelectProduct", SqlParams);

            DataRow dr = ds.Tables[0].Rows[0];

            Product prod = new Product(dr);

            return prod;
        }

        #region CRUD Members

        public void insert()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[7];
            SQLParameters[0] = new SqlParameter("@ProdId", idProd);
            SQLParameters[1] = new SqlParameter("@nameProd", nameProd);
            SQLParameters[2] = new SqlParameter("@numProd", numProd);
            SQLParameters[3] = new SqlParameter("@descProd", DescProd);
            SQLParameters[4] = new SqlParameter("@costProd", costProd);
            SQLParameters[5] = new SqlParameter("@imageUrl", imageURL);
            SQLParameters[6] = new SqlParameter("@BSId", idBuildSheet_item);

            int rowAffected = dc.insertItems("usp_InsertProduct", CommandType.StoredProcedure, SQLParameters);
        }

        public void update()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[7];
            SQLParameters[0] = new SqlParameter("@ProdId", idProd);
            SQLParameters[1] = new SqlParameter("@nameProd", nameProd);
            SQLParameters[2] = new SqlParameter("@numProd", numProd);
            SQLParameters[3] = new SqlParameter("@descProd", DescProd);
            SQLParameters[4] = new SqlParameter("@costProd", costProd);
            SQLParameters[5] = new SqlParameter("@imageUrl", imageURL);
            SQLParameters[6] = new SqlParameter("@BSId", idBuildSheet_item);

            int rowAffected = dc.insertItems("usp_UpdateProduct", CommandType.StoredProcedure, SQLParameters);
        }

        public void delete()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[1];
            SQLParameters[0] = new SqlParameter("@ProdID", idProd);

            int rowAffected = dc.insertItems("usp_DeleteProduct", CommandType.StoredProcedure, SQLParameters);
        }

        #endregion
    }
}
