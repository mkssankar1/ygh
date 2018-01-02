using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace GreenChits.DataAccess
{
    public class DataParameter
    {
        public static DbParameter GetSqlParam (string parameterName, SqlDbType type, int size, object value, ParameterDirection paramDirection)
        {
            DbParameter dbParameter = new SqlParameter(parameterName, type);
            dbParameter.Size = size;
            dbParameter.Value = value;
            dbParameter.Direction = paramDirection;
            return dbParameter;
        }

        public static DbParameter GetSqlParam (string parameterName, SqlDbType type, object value, ParameterDirection paramDirection)
        {
            DbParameter dbParameter = new SqlParameter(parameterName, type);
            dbParameter.Value = value;
            dbParameter.Direction = paramDirection;
            return dbParameter;
        }

        public static DbParameter GetSqlParam(string parameterName, SqlDbType type, object value)
        {
            DbParameter dbParameter = new SqlParameter(parameterName, type);
            dbParameter.Value = value;
            dbParameter.Direction = ParameterDirection.Input;
            return dbParameter;
        }
    }
}