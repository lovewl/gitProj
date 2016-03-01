using System;
using System.Text.RegularExpressions;

namespace HoverTree.Framework
{
    class TypeParse
    {

        #region goto  http://keleyi.com/a/bjae/dq7x4530.htm

        public static int StrToInt(object expression, int defValue)
        {
            if (expression != null)
            {
                return StrToInt(expression.ToString(), defValue);
            }
            return defValue;
        }

        
        private static int StrToInt(string strValue, int defValue)
        {
            if (string.IsNullOrEmpty(strValue) || strValue.Trim().Length >= 11 || !Regex.IsMatch(strValue.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;
            int rv;
            if (Int32.TryParse(strValue, out rv))
                return rv;
            return defValue;
        }
        #endregion
    }
}
