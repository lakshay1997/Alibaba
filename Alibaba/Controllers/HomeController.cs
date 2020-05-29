using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CloudApp.Models;

namespace CloudApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TenantList tenantListobj = new TenantList();
            tenantListobj.tenantList = new List<TenantData>()
            {
                new TenantData()

                {    Id="1",
                    tenantname="Transit(HUB)",
                    tenantID="5b973f99-77df-4beb-b27d-aa0c70b8482c",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(Role-based%20SSO)/ac9bc694-1bdd-48d6-bd0d-afdbdc5dcb58?tenantId=5b973f99-77df-4beb-b27d-aa0c70b8482c",


                },

                new TenantData()

                {   Id="2",
                    tenantname="Type_A_Prod",
                    tenantID="5b973f99-77df-4beb-b27d-aa0c70b8482c",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(EY-ALI-PROD-A)/a0292aa8-7896-43fe-8cbe-b707bfb1dabf?tenantId=5b973f99-77df-4beb-b27d-aa0c70b8482c"
                },

                 new TenantData()

                {   Id="3",
                     tenantname="Type_B_Prod",
                    tenantID="5b973f99-77df-4beb-b27d-aa0c70b8482c",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(EY-ALI-PROD-B)/36a82955-95c2-4747-bea2-c5229b2c37e9?tenantId=5b973f99-77df-4beb-b27d-aa0c70b8482c"
                },
                 new TenantData()
                {  Id="4",
                     tenantname="Type_A_NonProd",
                    tenantID="4667418b-7015-4ceb-b207-2193896769a8",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(EY-ALI-NON-PROD-A)/c214464e-f91a-452a-8670-93338655e186?tenantId=4667418b-7015-4ceb-b207-2193896769a8"
                },
                 new TenantData()

                {    Id="5",
                     tenantname="Type_B_NonProd",
                    tenantID="4667418b-7015-4ceb-b207-2193896769a8",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(EY-ALI-NON-PROD-B)/82527ae3-18f8-4ea8-9375-6954d3d03753?tenantId=4667418b-7015-4ceb-b207-2193896769a8"
                },

                  new TenantData()
                {  Id="6",
                      tenantname="SelfManaged_Dev",
                    tenantID="4667418b-7015-4ceb-b207-2193896769a8",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(Role-based%20SSO)/c46e02f1-93d6-4251-a6a6-32e3ebee0c27?tenantId=4667418b-7015-4ceb-b207-2193896769a8"
                },
                  new TenantData()
                {   Id="7",
                      tenantname="SelfManaged_POC",
                    tenantID="4667418b-7015-4ceb-b207-2193896769a8",
                    url="https://myapps.microsoft.com/signin/Alibaba%20Cloud%20Service%20(Role-based%20SSO)/c46e02f1-93d6-4251-a6a6-32e3ebee0c27?tenantId=4667418b-7015-4ceb-b207-2193896769a8"
                },




            };
            return View(tenantListobj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
