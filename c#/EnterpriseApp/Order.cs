using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace BusinessObjs
{
    public class Order : CRUD
    {
        public string dateCreated { get; set; }
        public int idOrder { get; set; }
        public int idCustomer { get; set; }
        public int status { get; set; }

        public Order() { }

        public Order(DataRow dr)
        {
            this.idOrder = int.Parse(dr["OrderId"].ToString());
            this.idCustomer = int.Parse(dr["CustId"].ToString());
            this.status = int.Parse(dr["status"].ToString());
            this.dateCreated = dr["dateCreated"].ToString();
        }

        #region CRUD Members

        public void insert()
        {
            Order order = new Order();
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[4];
            SqlParams[0] = new SqlParameter("@OrderId", idOrder);
            SqlParams[1] = new SqlParameter("@CustId", idCustomer);
            SqlParams[2] = new SqlParameter("@dateCreated", dateCreated);
            SqlParams[3] = new SqlParameter("@status", status);

            int whatev = dc.insertItems("usp_InsertOrder", CommandType.StoredProcedure, SqlParams);
        }

        public void update()
        {
            Order order = new Order();
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[4];
            SqlParams[0] = new SqlParameter("@OrderId", idOrder);
            SqlParams[1] = new SqlParameter("@CustId", idCustomer);
            SqlParams[2] = new SqlParameter("@dateCreated", dateCreated);
            SqlParams[3] = new SqlParameter("@status", status);

            int whatev = dc.insertItems("usp_UpdateOrder", CommandType.StoredProcedure, SqlParams);
        }

        public void delete()
        {
            Order order = new Order();
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@OrderId", idOrder);

            int whatev = dc.insertItems("usp_DeleteOrder", CommandType.StoredProcedure, SqlParams);
        }

        public Order retrieve(int id)
        {
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@OrderId", idOrder);

            ds = dc.getDataSet("usp_SelectOrder", SqlParams);

            DataRow dr = ds.Tables[0].Rows[0];

            Order order = new Order(dr);

            return order;
        }

        public List<Order> GetAllOrders()
        {
            List<Order> listOrders = new List<Order>();
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();

            ds = dc.getDataSet("usp_SelectOrdersAll", null);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Order order = new Order(dr);
                listOrders.Add(order);
            }

            return listOrders;
        }

        #endregion
    }
}
