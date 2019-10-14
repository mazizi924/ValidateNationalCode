using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace ValidateNationalCode.Infrustructure
{
    public class FormatNationalCodeConstraint : IRouteConstraint
    {
        public string[] ntlidList = new string[] { "0000000000","1111111111","2222222222","3333333333","4444444444"};
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //var r = Regex.IsMatch(values[routeKey].ToString(), @"[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9][0-9]-[0-9]");
              
            if (ntlidList.Contains(values[routeKey].ToString()) )
                return true;
            else
                return false;

        }
    }
}
