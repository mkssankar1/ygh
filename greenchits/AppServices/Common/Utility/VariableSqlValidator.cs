using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Schema.ScriptDom;
using Microsoft.Data.Schema.ScriptDom.Sql;

namespace GreenChits.Common.Utility
{
    public class VariableSqlValidator : SqlValidator
    {
        public VariableSqlValidator(string queryToValidate)
        {
            QueryToValidate = queryToValidate;
        }
        public override bool Validate()
        {
            IScriptFragment fragment;
            ValidateSyntax(out fragment);
            if (QueryValid)
            {
                ValidateIfQueryIsSelectStatement(fragment);
                if (QueryValid)
                { 
                    if (QueryValid)
                    {
                        ValidateForNoOfStatements(fragment as TSqlScript);
                    }
                }

            }
            return QueryValid;
        }
       
    }
}
