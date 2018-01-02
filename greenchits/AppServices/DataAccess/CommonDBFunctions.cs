using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using GreenChits.Common.Utility;
using System.Data;

namespace GreenChits.DataAccess
{
    public static class CommonDBFunctions
    {
        /*public static SqlDataReader ExecuteReader(string spName, DbParameter[] dbparameter)
        {
            DataHelper helper = null;
            string connectionString = Flex.BenefitSystem.Common.Utility.CommonFunctions.GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
                return null;
            helper = new DataHelper(connectionString);
            return helper.ExecuteReader(spName, dbparameter).AsSqlReader();

        }*/

        public static int ExecuteNonQuery(string spName, DbParameter[] dbparameter,bool returnValue= false)
        {
            DataHelper helper = null;
            string connectionString = CommonFunctions.GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
                return 0;

            try
            {
                helper = new DataHelper(connectionString);
                return helper.ExecuteNonQuery(spName, dbparameter, returnValue);
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
        }

        public static object ExecuteScalar(string spName, DbParameter[] dbparameter)
        {
            DataHelper helper = null;
            string connectionString = CommonFunctions.GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
                return 0;

            try
            {
                helper = new DataHelper(connectionString);
                return helper.ExecuteScalar(spName, dbparameter);
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }
        }

        public static DataSet ExecuteDataSet(string spName, DbParameter[] dbparameter)
        {
            DataHelper helper = null;
            string connectionString =CommonFunctions.GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
                return null;

            try
            {
                helper = new DataHelper(connectionString);
                return helper.ExecuteDataSet(spName, dbparameter);
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }

        }

        public static DataSet ExecuteDataSet(string sqlQuery)
        {
            DataHelper helper = null;
            string connectionString = CommonFunctions.GetConnectionString();
            if (string.IsNullOrEmpty(connectionString))
                return null;

            try
            {
                helper = new DataHelper(connectionString);
                return helper.ExecuteDataSet(sqlQuery);
            }
            finally
            {
                if (helper != null)
                    helper.Dispose();
            }

        }       

    }
}
