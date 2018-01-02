using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using GreenChits.Common.Constants;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GreenChits.Common.Utility
{
    public static class ExtentionMethods
    {
        public static void SortByAscending<TSource, TValue>(this List<TSource> source, Func<TSource, TValue> selector)
        {
            var comparer = Comparer<TValue>.Default;
            source.Sort((x, y) => comparer.Compare(selector(x), selector(y)));
        }

        public static void SortByDescending<TSource, TValue>(this List<TSource> source, Func<TSource, TValue> selector)
        {
            var comparer = Comparer<TValue>.Default;
            source.Sort((x, y) => comparer.Compare(selector(y), selector(x)));
        }

    }
}
