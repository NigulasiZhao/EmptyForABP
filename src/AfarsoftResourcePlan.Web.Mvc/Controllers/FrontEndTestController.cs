using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AfarsoftResourcePlan.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AfarsoftResourcePlan.Web.Mvc.Controllers
{
    public class FrontEndTestController : AfarsoftResourcePlanControllerBase
    {
        public IActionResult CustomerIndex()
        {
            return View();
        }
        public IActionResult OrganizationIndex()
        {
            return View();
        }
        public IActionResult UsersIndex()
        {
            return View();
        }
        public IActionResult WarehouseIndex()
        {
            return View();
        }
        public IActionResult SupplierIndex()
        {
            return View();
        }
        public IActionResult RolesIndex()
        {
            return View();
        }
        public IActionResult NewSaleOrder()
        {
            return View();
        }
        public IActionResult SaleOrderList()
        {
            return View();
        }
    }
}