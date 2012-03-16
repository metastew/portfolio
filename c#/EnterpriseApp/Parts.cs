using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace BusinessObjs
{
    public class Part : CRUD
    {
        public string namePart { get; set; }
        public string locationPart { get; set; }
        public int numPart { get; set; }
        public string dateReceived { get; set; }
        public int idSupplier { get; set; }
        public string orderTime { get; set; }
        public int status { get; set; }
        public int idPart { get; set; }

        public Part() { }

        public Part(DataRow dr)
        {
            this.idPart = int.Parse(dr["PartId"].ToString());
            this.namePart = dr["namePart"].ToString();
            this.locationPart = dr["locationPart"].ToString();
            this.numPart = int.Parse(dr["numPart"].ToString());
            this.dateReceived = dr["dateReceived"].ToString();
            this.idSupplier = int.Parse(dr["idSupplier"].ToString());
            this.orderTime = dr["orderTime"].ToString();
            this.status = int.Parse(dr["status"].ToString());
        }

        #region CRUD Members

        public void insert()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[8];
            SqlParams[0] = new SqlParameter("@namePart", namePart);
            SqlParams[1] = new SqlParameter("@numPart", numPart);
            SqlParams[2] = new SqlParameter("@dateReceived", dateReceived);
            SqlParams[3] = new SqlParameter("@orderTime", orderTime);
            SqlParams[4] = new SqlParameter("@status", status);
            SqlParams[5] = new SqlParameter("@idSupplier", idSupplier);
            SqlParams[6] = new SqlParameter("@locationPart", locationPart);
            SqlParams[7] = new SqlParameter("@PartId", idPart);

            int whatev = dc.insertItems("usp_InsertPart", System.Data.CommandType.StoredProcedure, SqlParams);
        }

        public void update()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[8];
            SqlParams[0] = new SqlParameter("@namePart", namePart);
            SqlParams[1] = new SqlParameter("@numPart", numPart);
            SqlParams[2] = new SqlParameter("@dateReceived", dateReceived);
            SqlParams[3] = new SqlParameter("@orderTime", orderTime);
            SqlParams[4] = new SqlParameter("@status", status);
            SqlParams[5] = new SqlParameter("@idSupplier", idSupplier);
            SqlParams[6] = new SqlParameter("@locationPart", locationPart);
            SqlParams[7] = new SqlParameter("@PartId", idPart);

            int whatev = dc.insertItems("usp_UpdatePart", System.Data.CommandType.StoredProcedure, SqlParams);
        }

        public void delete()
        {
            DataConnection dc = new DataConnection();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@PartId", idPart);

            int whatev = dc.insertItems("usp_DeletePart", System.Data.CommandType.StoredProcedure, SqlParams);
        }

        public Part retrieve(int id)
        {
            DataConnection dc = new DataConnection();
            DataSet ds =  new DataSet();
            SqlParameter[] SqlParams = new SqlParameter[1];
            SqlParams[0] = new SqlParameter("@PartId", idPart);

            ds = dc.getDataSet("usp_SelectPart", SqlParams);

            DataRow dr = ds.Tables[0].Rows[0];

            Part part = new Part(dr);

            return part;
        }

        #endregion

        public List<Part> getAllParts()
        {
            List<Part> listPart = new List<Part>();
            DataConnection dc = new DataConnection();
            DataSet ds = new DataSet();

            ds = dc.getDataSet("usp_SelectPartsAll", null);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Part part = new Part(dr);
                listPart.Add(part);
            }

            return listPart;
        }
    }
}
