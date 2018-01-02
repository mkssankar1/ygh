using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace GreenChits.Common.Utility
{
    public static class ExtendEntLib
    {
        public static SqlDataReader AsSqlReader(this IDataReader reader)
        {
            return (SqlDataReader)((RefCountingDataReader)reader).InnerReader;
        }
    }
}
