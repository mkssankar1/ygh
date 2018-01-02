using System;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace GreenChits.DataAccess 
{
    public class DataBase : IDisposable
    {
        #region Fields

        protected SqlDatabase db;
        protected DbConnection connection;
        protected DbTransaction transaction;
        protected int commandTimeOut = 500;

        protected IDataReader outerReader = null;
        
        #endregion Fields
        
        /// <summary>
        /// These are the constants of the DB link in the web.config
        /// </summary>
        //public const string AptWebDB = "aptWeb";
        
        /// <summary>
        /// Creates a DB object
        /// </summary>
        /// <param name="myConnectionString">Dynamic Connection String. </param>
        public DataBase(string myConnectionString)
        {
            try
            {                
                db = new SqlDatabase(myConnectionString);   
                connection = db.CreateConnection();                
                initializeHelper();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Begins a Transaction
        /// </summary>
        public void BeginTransaction()
        {
            try
            {
                transaction = connection.BeginTransaction();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Rolls back a transaction
        /// </summary>
        public void RollBackTransaction()
        {
            try
            {
                transaction.Rollback();
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Commits a transaction
        /// </summary>
        public void CommitTransaction()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                throw;
            }
        }
        private void initializeHelper()
        {
            try
            {
                string cmdTimeOut = ConfigurationManager.AppSettings["CommandTimeOut"];
                if (cmdTimeOut != null)
                    commandTimeOut = int.Parse(cmdTimeOut);

                
            }
            catch
            {
                //could be issue with inproper configuration settings, so leave as it as to the default values
            }
        }
        /// <summary>
        /// Gets the current open transaction
        /// </summary>
        public DbTransaction Transaction
        {
            get{ return transaction ;}
        }

        #region IDisposable Members


        public void Dispose()
        {
            if (transaction != null)
            {                
                transaction.Dispose();
            }
            if (this.connection != null)
            {
                if (this.connection.State != ConnectionState.Closed)
                    this.connection.Close();
                if (outerReader != null)
                {
                    outerReader.Close();
                    outerReader.Dispose();
                    outerReader = null;
                }
                connection.Dispose();
                this.connection = null;
            } 
            this.db = null;
         }

        #endregion
    }
}
