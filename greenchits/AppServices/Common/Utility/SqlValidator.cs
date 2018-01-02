using System;
using System.Collections.Generic;
using Microsoft.Data.Schema.ScriptDom.Sql;
using Microsoft.Data.Schema.ScriptDom;
using System.Linq;
using System.Text;
using System.IO;

namespace GreenChits.Common.Utility
{
    public abstract class SqlValidator
    {
        protected string QueryToValidate
        {
            get;
            set;
        }

        public List<string> ErrorMessageList
        {
            get;
            set;
        }

        public bool QueryValid
        {
            get;
            set;
        }
        public int TotalStatements
        {
            get;
            set;
        }

        public abstract bool Validate();

        protected void ValidateSyntax(out IScriptFragment fragment)
        {
            
            QueryValid = Parse(out fragment);

        }

        protected void ValidateIfQueryIsSelectStatement(IScriptFragment fragment)
        {
            
           QueryValid = IsSelect(fragment);

        }
        protected void ValidateForColumnNameExistence(TSqlScript fragment)
        {
            QueryValid = CheckColumnExistence(fragment);
        }
        protected void ValidateForNoOfStatements(TSqlScript fragment)
        {
            SetNoOfStatements(fragment);
            if (TotalStatements != 1)
            {
                QueryValid = false;
                if (ErrorMessageList == null)
                    ErrorMessageList = new List<string>();
                if (TotalStatements == 0)
                    ErrorMessageList.Add("Query must have atleast one statement");
                else
                    ErrorMessageList.Add("Query must have only one statement");
            }
            else
                QueryValid = true;
        }
        protected bool Parse(out IScriptFragment fragment)
        {
            TSql100Parser parser = new TSql100Parser(false);
            IList<ParseError> errors;
            fragment = parser.Parse(new StringReader(QueryToValidate), out errors);
            if (errors != null && errors.Count > 0)
            {
                List<string> errorList = new List<string>();
                foreach (var error in errors)
                {
                    if (ErrorMessageList == null)
                        ErrorMessageList = new List<string>();
                    ErrorMessageList.Add(error.Message);
                }
               
            }
            if (ErrorMessageList == null)
                return true;
            else
                return false;

        }

        protected bool IsSelect(IScriptFragment fragment)
        {
            var script = fragment as TSqlScript;
            IList<TSqlStatement> statements = null;
            bool isSelectStatement = false;
            int statementNo = 1;
            foreach (var batch in script.Batches)
            {
                statements = batch.Statements;
                foreach (var st in statements)
                {
                    if (st is SelectStatement)
                    {
                        isSelectStatement = true;
                         
                    }
                    else
                    {
                        if (ErrorMessageList == null)
                            ErrorMessageList = new List<string>();
                        ErrorMessageList.Add("Query:#" + statementNo + " is not a select query");
                        isSelectStatement = false;
                        break;
                    }
                    statementNo++;
                }
            }
            return isSelectStatement;

        }

        protected IList<TSqlStatement> GetStatements(TSqlScript script)
        {
            List<TSqlStatement> tsqlStatementList = new List<TSqlStatement>();
            foreach (TSqlBatch batch in script.Batches)
            {
                foreach (TSqlStatement statement in batch.Statements)
                {
                    tsqlStatementList.Add(statement);
                }
            }
            return tsqlStatementList;
        }
        protected bool CheckColumnExistence(TSqlScript fragment)
        {
            bool hasColumnName = true;
            int statementNo =1;
            int invalidStatements = 0;
            IList<TSqlStatement> statements = GetStatements(fragment);
            foreach (var st in statements)
            {
                IList<TSqlFragment> selectStatements = new List<TSqlFragment>();
                var specTemp = ((SelectStatement)st).QueryExpression;
                CheckForQueryExpression(specTemp, ref selectStatements);
                
                foreach (SelectColumn col in selectStatements)
                {
                    if (col.ColumnName != null)
                    {
                        if (((Identifier)col.ColumnName).Value.ToLower() == "entityguid")
                        {
                            hasColumnName = true;
                            break;
                        }
                        else
                        {
                            hasColumnName = false;
                            
                        }
                    }
                    
                }
                if (!hasColumnName)
                {
                    
                    invalidStatements++;
                    if (ErrorMessageList == null)
                        ErrorMessageList = new List<string>();
                    ErrorMessageList.Add("Query does not have Column with Name 'EntityGUID'");
                }
                statementNo++;
            }
            if (invalidStatements > 0)
                return false;
            else
                return true;
        }

        protected void CheckForQueryExpression(object queryExpression, ref IList<TSqlFragment> selectStatements)
        {
            IList<TSqlFragment> statements = new List<TSqlFragment>();
            if (queryExpression.GetType().Equals(typeof(QueryExpression)) || queryExpression.GetType().Equals(typeof(QuerySpecification)))
            {
                statements = ((QuerySpecification)queryExpression).SelectElements;
                foreach (var stmt in statements)
                    selectStatements.Add(stmt);
                //selectStatements = statements;
            }
            else if (queryExpression.GetType().Equals(typeof(BinaryQueryExpression)))
            {
                BinaryQueryExpression experssion = (BinaryQueryExpression)(queryExpression);
                //statements = ((QuerySpecification)(experssion.FirstQueryExpression)).SelectElements;
                //selectStatements.Concat(statements);
                CheckForQueryExpression(experssion.FirstQueryExpression, ref selectStatements);
                CheckForQueryExpression(experssion.SecondQueryExpression, ref selectStatements);
            }
            
            
        }


        protected void SetNoOfStatements(TSqlScript fragment)
        {
            IList<TSqlStatement> statements = GetStatements(fragment);
            TotalStatements = statements.Count();
        }
    }
}
