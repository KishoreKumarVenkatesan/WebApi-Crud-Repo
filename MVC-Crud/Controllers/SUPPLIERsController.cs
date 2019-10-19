using MVC_Crud.Models;
using MVC_Crud.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace MVC_Crud.Controllers
{
    public class SUPPLIERsController : Controller
    {
        // GET: SUPPLIERs
        public ActionResult GetSuppliers()
        {
          SupplierClient CC = new SupplierClient();
            ViewBag.listSupplier = CC.findAll();
            
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public ActionResult Create(SupplierViewModel sup)
        {
            SupplierClient CC = new SupplierClient();
            CC.Create(sup.supplier);
           
            return RedirectToAction("GetSuppliers");
        }

        public ActionResult Delete(string id)
        {
            SupplierClient CC = new SupplierClient();
            CC.Delete(id);
            return RedirectToAction("GetSuppliers");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            SupplierClient CC = new SupplierClient();
            SupplierViewModel SUP = new SupplierViewModel();
            SUP.supplier = CC.find(id);
            return View("Edit", SUP);
        }
        [HttpPost]
        public ActionResult Edit(SupplierViewModel SUP)
        {
            SupplierClient CC = new SupplierClient();
            CC.Edit(SUP.supplier);
            return RedirectToAction("GetSuppliers");
        }

        //IEnumerable<MVCSupplierModels> supList;
        //HttpResponseMessage response = GlobalVariables.WebApiClent.GetAsync("SUPPLIERs").Result;
        //supList = response.Content.ReadAsAsync<IEnumerable<MVCSupplierModels>>().Result;
        //return View(supList);

    }
}