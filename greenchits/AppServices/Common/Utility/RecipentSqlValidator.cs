using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.Schema.ScriptDom.Sql;
using Microsoft.Data.Schema.ScriptDom;

namespace GreenChits.Common.Utility
{
   public class RecipentSqlValidator :SqlValidator
    {
        public RecipentSqlValidator(string queryToValidate)
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
                    //ValidateForColumnNameExistence(fragment as TSqlScript);
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
