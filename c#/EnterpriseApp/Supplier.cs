using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccess;
using System.Data.SqlClient;

namespace BusinessObjs
{
    public class Supplier : Person, CRUD
    {
        public string company { get; set; }
        public int contactPerson { get; set; }
        public int idSupplier { get; set; }

        public Supplier() { }

        public Supplier(DataRow dr)
        {
            this.idSupplier = int.Parse(dr["SuppId"].ToString());
            this.company = dr["company"].ToString();
            this.contactPerson = int.Parse(dr["contactPerson"].ToString());
        }

        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> listSupp = new List<Supplier>();
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();

            ds = dc.getDataSet("usp_SelectSuppliersAll", null);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Supplier supp = new Supplier(dr);
                listSupp.Add(supp);
            }

            return listSupp;
        }

        public Supplier retrieve(int id)
        {
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@SuppId", idSupplier);

            ds = dc.getDataSet("usp_SelectSupplier", SqlParams);

            DataRow dr = ds.Tables[0].Rows[0];

            Supplier supp = new Supplier(dr);

            return supp;
        }

        #region CRUD Members

        public void insert()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[3];
            SQLParameters[0] = new SqlParameter("@SuppId", idSupplier);
            SQLParameters[1] = new SqlParameter("@company", company);
            SQLParameters[2] = new SqlParameter("@contactPerson", contactPerson);

            int rowAffected = dc.insertItems("usp_InsertSupplier", CommandType.StoredProcedure, SQLParameters);
        }

        public void update()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[3];
            SQLParameters[0] = new SqlParameter("@SuppId", idSupplier);
            SQLParameters[1] = new SqlParameter("@company", company);
            SQLParameters[2] = new SqlParameter("@contactPerson", contactPerson);

            int rowAffected = dc.insertItems("usp_UpdateSupplier", CommandType.StoredProcedure, SQLParameters);
        }

        public void delete()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[1];
            SQLParameters[0] = new SqlParameter("@SuppId", idSupplier);

            int rowAffected = dc.insertItems("usp_DeleteSupplier", CommandType.StoredProcedure, SQLParameters);
        }

        #endregion
    }
}
