using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Web.Models;
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
        [DontWrapResult]
        public ActionResult GetIndex()
        {
            var data = new List<object>(){new { id=0,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=1,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=2,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=3,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=4,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=5,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=6,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=7,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
                new { id=8,goodsName="Arbet",goodsCode=1, classification="男",goodsArticleNumber = 0,goodsSpecification="20g/袋",goodsUnit="袋",auxiliaryUnit= "斤",goodsPrice=10},
            };
            //var total = data.Count;
            //var footer = new List<object>(){
            //    new { OutStorageAmount=691.1234, ReturnAmount= 0, SaleAmount= 850.6834, SaleGoodsOrderAmount= 45954.06 }
            //};
            return Json(data);
        }
    }
}