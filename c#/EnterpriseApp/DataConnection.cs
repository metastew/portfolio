using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class DataConnection
    {
        private SqlConnection connection = new SqlConnection("Data Source=DAEDALUS-PC\\SQLEXPRESS;Initial Catalog=UnderGuard;Integrated Security=True");
        
        // get connection
        private SqlConnection getConnection() 
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            return connection;
        }

        // insert items
        public int insertItems(string cmdText, CommandType cmdType, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            int retval;

            getConnection();

            prepareCommand(cmd, (SqlTransaction)null, CommandType.StoredProcedure, cmdText, cmdParams);

            retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            connection.Close();

            return retval;
        }

        // get single item
        private Object getSingleItem(SqlConnection conn, CommandType cmdType, string cmdText, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            Object retval;

            prepareCommand(cmd, (SqlTransaction)null, cmdType, cmdText, cmdParams);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return retval;
        }

        // get dataset
        public DataSet getDataSet(string cmdText, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            prepareCommand(cmd, (SqlTransaction)null, CommandType.StoredProcedure, cmdText, cmdParams);

            da = new SqlDataAdapter(cmd);

            da.Fill(ds);
    
            cmd.Parameters.Clear();

            connection.Close();

            return ds;
        }

        // execute transaction
        public int executeTransaction(SqlTransaction transaction, CommandType cmdType, string cmdText, SqlParameter[] cmdParams)
        {
            SqlCommand cmd = new SqlCommand();
            int retval;

            prepareCommand(cmd, transaction, cmdType, cmdText, cmdParams);

            retval = cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

            return retval;
        }

        // prepare commands
        private void prepareCommand(SqlCommand cmd, SqlTransaction transaction, CommandType cmdType, string CmdText, SqlParameter[] cmdParams)
        {
            cmd.Connection = connection;
            cmd.CommandText = CmdText;
            cmd.CommandType = cmdType;
            if (transaction != null)
            {
                cmd.Transaction = transaction;
            }
            if (cmdParams != null)
            {
                attachParameters(cmd, cmdParams);
            }
            

        }
        // attach parameters
        private void attachParameters(SqlCommand cmd, SqlParameter[] cmdParams)
        {
            foreach(SqlParameter parameter in cmdParams)
            {
                cmd.Parameters.Add(parameter);
            }
        }
    }
}
