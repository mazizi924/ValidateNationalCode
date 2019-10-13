using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidateNationalCode.Models
{
    public class RouteSegments
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public Dictionary<string, object> Parameters { get; } = new Dictionary<string, object>();
    }
}
