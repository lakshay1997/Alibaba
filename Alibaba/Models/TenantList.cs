using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudApp.Models
{
    public class TenantList
    {
        public List<TenantData> tenantList { get; set; }
    }
    public class TenantData
    {
        public string tenantname { get; set; }
        public string tenantID { get; set; }
        public string url { get; set; }
        public string Id { get; set; }

    }
}
