using System.Text;
using System.Data;
using System.Data.SqlClient;
using DataAccess;
using System.Collections.Generic;

namespace BusinessObjs
{
    public class Customer : Person, CRUD
    {

        public int creditCardNum { get; set; }
        public int cardStatus { get; set; }
        public int customerId { get; set; }
        public int personId { get; set; }

        public Customer() { }

        public Customer(DataRow dr)
        {
            this.customerId = int.Parse(dr["CustId"].ToString());
            this.creditCardNum = int.Parse(dr["creditCardNum"].ToString());
            this.cardStatus = int.Parse(dr["statusCard"].ToString());
        }

        public List<Customer> getAllCustomers()
        {
            List<Customer> listCust = new List<Customer>();
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();

            ds = dc.getDataSet("usp_SelectCustomersAll", null);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Customer cust = new Customer(dr);
                listCust.Add(cust);
            }

            return listCust;
        }

        public Customer retrieve(int id)
        {
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@CustId", customerId);

            ds = dc.getDataSet("usp_SelectCustomer", SqlParams);

            DataRow dr = ds.Tables[0].Rows[0];

            Customer cust = new Customer(dr);

            return cust;

        }
        
        #region CRUD Members
        
        public void insert()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[4];
            SQLParameters[0] = new SqlParameter("@CustId", customerId);
            SQLParameters[1] = new SqlParameter("@idPerson", idPerson);
            SQLParameters[2] = new SqlParameter("@creditCardNum", creditCardNum);
            SQLParameters[3] = new SqlParameter("@statusCard", cardStatus);

            int rowAffected = dc.insertItems("usp_InsertCustomer", CommandType.StoredProcedure, SQLParameters);
        }

        public void update()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[4];
            SQLParameters[0] = new SqlParameter("@CustId", customerId);
            SQLParameters[1] = new SqlParameter("@idPerson", idPerson);
            SQLParameters[2] = new SqlParameter("@creditCardNum", creditCardNum);
            SQLParameters[3] = new SqlParameter("@statusCard", cardStatus);

            int rowAffected = dc.insertItems("usp_UpdateCustomer", CommandType.StoredProcedure, SQLParameters);
        }

        public void delete()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SQLParameters = new SqlParameter[1];
            SQLParameters[0] = new SqlParameter("@CustId", customerId);

            int rowAffected = dc.insertItems("usp_DeleteCustomer", CommandType.StoredProcedure, SQLParameters);
        }

        #endregion
    }
}
