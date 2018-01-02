using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;


namespace GreenChits.DataAccess
{
    public class DataHelper : DataBase, IDisposable
    {
        public DataHelper(string dbConString)
            : base(dbConString)
        {
        }

        public virtual IDataReader ExecuteReader(string sql)
        {

            DbCommand dbCmd = db.GetSqlStringCommand(sql);
            dbCmd.CommandTimeout = commandTimeOut;

            IDataReader reader = db.ExecuteReader(dbCmd);
            outerReader = reader;
            return reader;
        }

        private DbCommand BuildCommand(String spName, DbParameter[] dbParameters)
        {
            DbCommand dbCmd = db.GetStoredProcCommand(spName);
            dbCmd.CommandTimeout = commandTimeOut;
            dbCmd.CommandType = CommandType.StoredProcedure;
            if (dbParameters != null)
                dbCmd.Parameters.AddRange(dbParameters);
            return dbCmd;
        }

        public virtual IDataReader ExecuteReader(String spName, DbParameter[] dbParameters)
        {
            IDataReader reader = null;
            DbCommand dbCmd = BuildCommand(spName, dbParameters);
            if (transaction != null)
                reader = db.ExecuteReader(dbCmd, transaction);
            else
                reader = db.ExecuteReader(dbCmd);
            outerReader = reader;
            return reader;
        }

        public virtual IDataReader ExecuteReader(String spName, DbParameter[] dbParameters, CommandBehavior commandBehavior)
        {
            IDataReader reader = null;
            DbCommand dbCmd = BuildCommand(spName, dbParameters);
            reader = dbCmd.ExecuteReader(commandBehavior);
            outerReader = reader;
            return reader;
        }

        public virtual object ExecuteScalar(String spName, DbParameter[] dbParameters)
        {
            object obj = null;
            DbCommand dbCmd = BuildCommand(spName, dbParameters);
            if (transaction != null)
                obj = db.ExecuteScalar(dbCmd, transaction);
            else
                obj = db.ExecuteScalar(dbCmd);
            return obj;
        }

        public virtual DataSet ExecuteDataSet(string sql)
        {
            DbCommand dbCmd = db.GetSqlStringCommand(sql);
            dbCmd.CommandTimeout = commandTimeOut;
            DataSet ds = db.ExecuteDataSet(dbCmd);
            return ds;
        }

        public virtual DataSet ExecuteDataSet(String spName, DbParameter[] dbParameters)
        {
            DataSet ds = null;
            DbCommand dbCmd = BuildCommand(spName, dbParameters);
            if (transaction != null)
                ds = db.ExecuteDataSet(dbCmd, transaction);
            else
                ds = db.ExecuteDataSet(dbCmd);
            return ds;
        }

        public virtual int ExecuteNonQuery(String spName, DbParameter[] dbParameters,bool Returnvalue = false)
        {
            int rowsAffected = 0;
            DbCommand dbCmd = BuildCommand(spName, dbParameters);
            if (transaction != null)
                rowsAffected = db.ExecuteNonQuery(dbCmd, transaction);
            else if (Returnvalue)
            {
               db.ExecuteNonQuery(dbCmd);
               rowsAffected = Convert.ToInt32(dbCmd.Parameters["RETURN_VALUE"].Value.ToString());

            }else
                rowsAffected = db.ExecuteNonQuery(dbCmd);
            return rowsAffected;
        }
    }
}
